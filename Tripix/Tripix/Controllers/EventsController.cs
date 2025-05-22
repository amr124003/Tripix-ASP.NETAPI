using Microsoft.AspNetCore.Mvc;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        [HttpGet("Events")]
        public IActionResult GetEvents ()
        {
            return Ok("Events");
        }
        [HttpGet("Event")]
        public IActionResult GetEvent ()
        {
            return Ok("Event");
        }
        [HttpPost("AddEvent")]
        public IActionResult AddEvent ( AddEventDTO model )
        {
            return Ok("Event added");
        }
        [HttpPut("UpdateEvent/{Id}")]
        public IActionResult UpdateEvent ( int Id )
        {
            return Ok("Event updated");
        }
        [HttpDelete("DeleteEvent")]
        public IActionResult DeleteEvent ( int Id )
        {
            return Ok("Event deleted");
        }
        [HttpPost("BookingTicket")]
        public IActionResult BookingEventTicket ( BookingEventDTO model )
        {
            return Ok("Event booked");
        }
    }
}
