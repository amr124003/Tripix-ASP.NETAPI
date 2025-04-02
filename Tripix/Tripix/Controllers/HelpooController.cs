using Microsoft.AspNetCore.Mvc;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelpooController : ControllerBase
    {
        public IActionResult AddHelpoo ()
        {
            return Ok("Helpoo added");
        }
        public IActionResult UpdateHelpoo ()
        {
            return Ok("Helpoo updated");
        }
        public IActionResult DeleteHelpoo ()
        {
            return Ok("Helpoo deleted");
        }
        public IActionResult LikeHelpoo ()
        {
            return Ok("Helpoo liked");
        }
        public IActionResult GetHelpooComments ()
        {
            return Ok("Helpoo comments");
        }
        public IActionResult GetHelpooComment ()
        {
            return Ok("Helpoo comment");
        }
        public IActionResult AddHelpooComment ()
        {
            return Ok("Helpoo comment added");
        }
        public IActionResult UpdateHelpooComment ()
        {
            return Ok("Helpoo comment updated");
        }
        public IActionResult DeleteHelpooComment ()
        {
            return Ok("Helpoo comment deleted");
        }
        public IActionResult LikeHelpooComment ()
        {
            return Ok("Helpoo comment liked");
        }
        public IActionResult BookTurn ()
        {
            return Ok("Turn booked");
        }
        public IActionResult GetTurnDetails ()
        {
            return Ok("Turn");
        }
        public IActionResult UpdateTurn ()
        {
            return Ok("Turn updated");
        }
        public IActionResult DeleteTurn ()
        {
            return Ok("Turn deleted");
        }
        public IActionResult GetTurns ()
        {
            return Ok("Turns");
        }
        public IActionResult GetTurn ()
        {
            return Ok("Turn");
        }
        public IActionResult Cancelturn ()
        {
            return Ok("Turn canceled");
        }
    }
}
