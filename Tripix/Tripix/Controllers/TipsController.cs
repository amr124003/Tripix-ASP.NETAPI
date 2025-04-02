using Microsoft.AspNetCore.Mvc;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipsController : ControllerBase
    {
        public IActionResult GetTips ()
        {
            return Ok("Tips");
        }
        public IActionResult GetTip ()
        {
            return Ok("Tip");
        }
        public IActionResult AddTip ()
        {
            return Ok("Tip added");
        }
        public IActionResult UpdateTip ()
        {
            return Ok("Tip updated");
        }
        public IActionResult DeleteTip ()
        {
            return Ok("Tip deleted");
        }
        public IActionResult LikeTip ()
        {
            return Ok("Tip liked");
        }
    }
}
