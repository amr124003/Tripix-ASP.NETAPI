using Microsoft.AspNetCore.Mvc;

namespace Tripix.Abstractions
{
    public static class ResultExtentions
    {
        public static ObjectResult ToProblem ( this Result result )
        {
            if (result.IsSuccess) { throw new InvalidOperationException("Success Can't be a Problem"); }

            var problem = Results.Problem(statusCode: result.Error.StatusCode);
            var problemDetails = problem.GetType().GetProperty(nameof(ProblemDetails))!.GetValue(problem) as ProblemDetails;

            problemDetails.Extensions = new Dictionary<string, object?>
        {
            {
                "errors" , new[]
                {
                    result.Error.code,
                    result.Error.Description,
                }
            }
        };

            return new ObjectResult(problemDetails);
        }
    }
}
