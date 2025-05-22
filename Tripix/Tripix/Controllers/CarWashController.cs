using Microsoft.AspNetCore.Mvc;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarWashController : ControllerBase
    {
        [HttpPost("BookWashTurn")]
        public IActionResult BookTurn ( AddWashDTO model )
        {
            return Ok("Turn booked");
        }
        [HttpGet("GetWashTurn")]
        public IActionResult GetTurnDetails ()
        {
            return Ok("Turn");
        }
        [HttpPut("UpdateBooking")]
        public IActionResult UpdateTurn ( int Id )
        {
            return Ok("Turn updated");
        }
        [HttpDelete("CencelBooking")]
        public IActionResult DeleteTurn ( int Id )
        {
            return Ok("Turn deleted");
        }
        [HttpGet("GetWashBookings")]
        public IActionResult GetTurns ()
        {
            return Ok("Turns");
        }
        [HttpGet("GetWashBooking")]
        public IActionResult GetTurn ( int Id )
        {
            return Ok("Turn");
        }
        [HttpDelete("CancelTurn")]
        public IActionResult Cancelturn ( int Id )
        {
            return Ok("Turn canceled");
        }
    }
}
