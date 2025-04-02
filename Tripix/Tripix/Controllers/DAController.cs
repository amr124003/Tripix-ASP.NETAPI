using Microsoft.AspNetCore.Mvc;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DAController : ControllerBase
    {
        public IActionResult GetTrendingProducts ()
        {
            return Ok("Products");
        }
        public IActionResult GetNewArrivalsProducts ()
        {
            return Ok();
        }
        public IActionResult GetTopRatedProducts ()
        {
            return Ok();
        }
        public IActionResult BestSellerProducts ()
        {
            return Ok();
        }
        public IActionResult Gettestimonial ()
        {
            return Ok();
        }
    }
}
