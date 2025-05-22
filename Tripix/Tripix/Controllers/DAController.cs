using Microsoft.AspNetCore.Mvc;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DAController : ControllerBase
    {
        [HttpGet("TrendingProducts")]
        public IActionResult GetTrendingProducts ()
        {
            return Ok("Products");
        }
        [HttpGet("NewArrivalsProducts")]
        public IActionResult GetNewArrivalsProducts ()
        {
            return Ok();
        }
        [HttpGet("TopRatedProducts")]
        public IActionResult GetTopRatedProducts ()
        {
            return Ok();
        }
        [HttpGet("BestSellerProducts")]
        public IActionResult BestSellerProducts ()
        {
            return Ok();
        }
        [HttpGet("Gettestimonial")]
        public IActionResult Gettestimonial ()
        {
            return Ok();
        }
    }
}
