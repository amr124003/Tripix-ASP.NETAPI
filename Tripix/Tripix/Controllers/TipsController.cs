using Microsoft.AspNetCore.Mvc;
using Stripe;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipsController : ControllerBase
    {
        [HttpGet("Tips")]
        public IActionResult GetTips ()
        {
            return Ok("Tips");
        }
        [HttpGet("Tip")]
        public IActionResult GetTip ()
        {
            return Ok("Tip");
        }
        [HttpPost("AddTip")]
        public IActionResult AddTip (AddTipDTO model)
        {
            return Ok("Tip added");
        }
        [HttpPut("UpdateTip")]
        public IActionResult UpdateTip (int Id)
        {
            return Ok("Tip updated");
        }
        [HttpDelete("DeleteTip")]
        public IActionResult DeleteTip (int Id)
        {
            return Ok("Tip deleted");
        }
        [HttpPost("LikeTip")]
        public IActionResult LikeTip (int Id)
        {
            return Ok("Tip liked");
        }
        [HttpGet("DislikeTip")]
        public IActionResult Dislike(int Id)
        {
            return Ok();
        }
    }
}
