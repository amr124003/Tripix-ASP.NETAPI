using Microsoft.AspNetCore.Mvc;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarWashController : ControllerBase
    {
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
