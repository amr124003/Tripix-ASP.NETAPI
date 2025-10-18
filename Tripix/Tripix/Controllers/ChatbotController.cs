#nullable disable
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Text.Json;
using Tripix.Context;
using Tripix.Entities;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatbotController : ControllerBase
    {
        private readonly string mistralApiKey = Environment.GetEnvironmentVariable("mistralApiKey");
        private readonly string cohereApiKey = Environment.GetEnvironmentVariable("cohereApiKey");
        private readonly ApplicationDbcontext context;

        private List<Question> questions = new();

        public ChatbotController ( ApplicationDbcontext context )
        {
            this.context = context;
            questions = context.Questions.ToList();

        }

        [HttpPost("ask")]
        public async Task<IActionResult> AskChatbot ( [FromBody] ChatRequest request )
        {

            if (string.IsNullOrWhiteSpace(request.Message))
            {
                return BadRequest("Can't generate Response For Empty Question.");
            }

            var bestMatch = await FindBestMatchingQuestion(request.Message);
            if (bestMatch != null)
            {
                return Ok(new { reply = bestMatch.Answer });
            }

            string generatedResponse = await GetResponseFromMistral(request.Message);
            return Ok(new { reply = generatedResponse });
        }

        [HttpPost]
        public IActionResult AddQuestion ( string ques, string res )
        {
            var question = new Question
            {
                question = ques,
                Response = res
            };
            context.Add(question);
            context.SaveChanges();

            return Ok();
        }

        [HttpGet]
        public IActionResult GetAllQuestions ()
        {
            return Ok(context.Questions.ToList());
        }

        private async Task<QuestionAnswer> FindBestMatchingQuestion ( string userQuestion )
        {
            var exactMatch = questions.FirstOrDefault(q =>
                q.question.Trim().Equals(userQuestion.Trim(), StringComparison.OrdinalIgnoreCase));

            if (exactMatch != null)
            {
                return new QuestionAnswer
                {
                    Question = exactMatch.question,
                    Answer = exactMatch.Response
                };
            }
            var client = new RestClient("https://api.cohere.ai/v1/embed");
            var restRequest = new RestRequest();
            restRequest.Method = Method.Post;
            restRequest.AddHeader("Authorization", $"Bearer {cohereApiKey}");
            restRequest.AddHeader("Content-Type", "application/json");

            
            var rquestions = questions.Select(q => q.question).ToArray();

            var requestBody = new
            {
                texts = rquestions.Append(userQuestion).ToArray(),
                model = "embed-multilingual-v2.0"
            };

            restRequest.AddJsonBody(requestBody);
            var response = await client.ExecuteAsync(restRequest);

            if (!response.IsSuccessful)
            {
                return null;
            }

            var jsonResponse = JsonDocument.Parse(response.Content);
            var embeddings = jsonResponse.RootElement.GetProperty("embeddings").EnumerateArray().ToList();

            if (embeddings.Count == 0)
            {
                return null;
            }

            
            var userEmbedding = embeddings.Last().EnumerateArray().Select(e => e.GetDouble()).ToArray();

            
            var questionEmbeddings = embeddings.Take(embeddings.Count - 1).ToList();

            double maxSimilarity = 0.0;
            QuestionAnswer bestMatch = null;

            for (int i = 0; i < questions.Count; i++)
            {
                double similarity = CosineSimilarity(
                    userEmbedding,
                    questionEmbeddings[i].EnumerateArray().Select(e => e.GetDouble()).ToArray()
                );

                if (similarity > maxSimilarity && similarity > 0.85)
                {
                    maxSimilarity = similarity;
                    bestMatch = new QuestionAnswer
                    {
                        Question = questions[i].question,
                        Answer = questions[i].Response
                    };
                }
            }

            return bestMatch;
        }

        private double CosineSimilarity ( double[] vec1, double[] vec2 )
        {
            double dotProduct = 0.0, magA = 0.0, magB = 0.0;

            for (int i = 0; i < vec1.Length; i++)
            {
                dotProduct += vec1[i] * vec2[i];
                magA += Math.Pow(vec1[i], 2);
                magB += Math.Pow(vec2[i], 2);
            }

            return dotProduct / (Math.Sqrt(magA) * Math.Sqrt(magB));
        }


        private async Task<string> GetResponseFromMistral ( string userQuestion )
        {
            try
            {
                var client = new RestClient("https://api.mistral.ai/v1/chat/completions");
                var restRequest = new RestRequest();
                restRequest.Method = Method.Post;
                restRequest.AddHeader("Authorization", $"Bearer {mistralApiKey}");
                restRequest.AddHeader("Content-Type", "application/json");

                var requestBody = new
                {
                    model = "mistral-small",
                    messages = new[]
                    {
                        new { role = "user", content = userQuestion }
                    },
                    max_tokens = 200,
                    temperature = 0.7
                };

                restRequest.AddJsonBody(requestBody);
                var response = await client.ExecuteAsync(restRequest);

                if (!response.IsSuccessful)
                {
                    Console.WriteLine("Field to Call Tripix Support");
                    return "Can't generate Response Now";
                }

                var jsonResponse = JsonDocument.Parse(response.Content);
                string generatedText = jsonResponse.RootElement
                    .GetProperty("choices")[0]
                    .GetProperty("message")
                    .GetProperty("content")
                    .GetString();

                Console.WriteLine($"Tripix Response: {generatedText}");
                return generatedText;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Field to Call Tripix Support: {ex.Message}");
                return "Can't generate Response Now.";
            }
        }
    }
}