using Microsoft.AspNetCore.Mvc;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        public IActionResult GetEvents ()
        {
            return Ok("Events");
        }
        public IActionResult GetEvent ()
        {
            return Ok("Event");
        }
        public IActionResult AddEvent ()
        {
            return Ok("Event added");
        }
        public IActionResult UpdateEvent ()
        {
            return Ok("Event updated");
        }
        public IActionResult DeleteEvent ()
        {
            return Ok("Event deleted");
        }
        public IActionResult BookEvent ()
        {
            return Ok("Event booked");
        }
    }
}
