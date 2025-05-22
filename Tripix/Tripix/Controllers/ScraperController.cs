using Microsoft.AspNetCore.Mvc;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ScraperController : ControllerBase
    {
        private readonly HttpClient httpclient;

        public ScraperController ( HttpClient _httpclient )
        {
            httpclient = _httpclient;



            httpclient.DefaultRequestHeaders.Add("User-Agent",
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 " +
                "(KHTML, like Gecko) Chrome/122.0.0.0 Safari/537.36");
            httpclient.DefaultRequestHeaders.Add("Accept", "application/json, text/plain, */*");
            httpclient.DefaultRequestHeaders.Add("Referer", "https://www.contactcars.com/used-cars");
            httpclient.DefaultRequestHeaders.Add("Origin", "https://www.contactcars.com");
            httpclient.DefaultRequestHeaders.Add("Accept-Language", "en-US,en;q=0.9,ar;q=0.8");

            // ·Ê ·”Â ›Ì Forbidden° Ã—»  ÷Ì› Cookie
            httpclient.DefaultRequestHeaders.Add("Cookie", "__cf_bm=XXX; %5B%5B%22AKsRol_tz8AhfBOJ843aW_BQ5NbAIF8nbguLSWz0cAoN8VEV-t2KveaPlaZvSqP7mY8fkZ-Qv3VTL7kdsBlsrWuzkj-pwx8Effv5EYz5RLEB02-ApugYhgX2eu7LlKX2RF7ZRtjI67hQzdojktDY5SkOX0oH8l10cQ%3D%3D%22%5D%5D");
        }
        [HttpGet("scrape")]
        public async Task<IActionResult> ScrapeCars ( int page = 1 )
        {

            var result = await GetUsedCarsAsync(page);

            return Content(result, "application/json");
        }

        private async Task<string> GetUsedCarsAsync ( int page = 1 )
        {
            var url = $"https://www.contactcars.com/api/v2/used-cars?page={page}&page_size=20";
            var response = await httpclient.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return json;
            }

            return $"Error: {response.StatusCode}";
        }
    }

    public class CarDto
    {
        public string Name { get; set; }
        public string Price { get; set; }
        public string ImageUrl { get; set; }
    }
}
