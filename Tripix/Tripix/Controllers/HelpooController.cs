using Microsoft.AspNetCore.Mvc;
using Tripix.View_Models;


namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelpooController : ControllerBase
    {
        [HttpGet("HelpooComments")]
        public IActionResult GetHelpooComments ()
        {
            return Ok("Helpoo comments");
        }
        [HttpPost("AddHelpooComment")]
        public IActionResult AddHelpooComment (AddCommentDTO model)
        {
            return Ok("Helpoo comment added");
        }
        [HttpPut("UpdateComment")]
        public IActionResult UpdateHelpooComment (int Id)
        {
            return Ok("Helpoo comment updated");
        }
        [HttpDelete("DeleteComment")]
        public IActionResult DeleteHelpooComment (int Id)
        {
            return Ok("Helpoo comment deleted");
        }
        [HttpPost("LikeComment")]
        public IActionResult LikeHelpooComment (int Id)
        {
            return Ok("Helpoo comment liked");
        }
        [HttpPost("DisLikeComment")]
        public IActionResult DislikeHelpooComment ( int Id )
        {
            return Ok("Helpoo comment Disliked");
        }
        [HttpPost("OrderHelpoo")]
        public IActionResult OrderHelpoo (OrderHelpooDTO model)
        {
            return Ok("Turn booked");
        }
        [HttpGet("OrderDetails")]
        public IActionResult GetOrderDetails (int Id)
        {
            return Ok("Turn");
        }
        [HttpPut("UpdateOrder")]
        public IActionResult UpdateTurn (int Id)
        {
            return Ok("Turn updated");
        }
        [HttpDelete("CancelOrder")]
        public IActionResult DeleteTurn (int Id)
        {
            return Ok("Turn deleted");
        }
        [HttpGet("HelpooOrders")]
        public IActionResult GetOrders ()
        {
            return Ok("Turns");
        }
        [HttpPost("CencelOrder")]
        public IActionResult Cancelturn (int Id)
        {
            return Ok("Turn canceled");
        }
    }
}
