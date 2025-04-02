using Microsoft.AspNetCore.Mvc;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripixController : ControllerBase
    {
        public IActionResult BookTrip ()
        {
            return Ok("Trip booked");
        }
        public IActionResult GetTripDetails ()
        {
            return Ok("Trip");
        }
        public IActionResult UpdateTrip ()
        {
            return Ok("Trip updated");
        }
        public IActionResult DeleteTrip ()
        {
            return Ok("Trip deleted");
        }
        public IActionResult GetTrips ()
        {
            return Ok("Trips");
        }
        public IActionResult GetTrip ()
        {
            return Ok("Trip");
        }
        public IActionResult CancelTrip ()
        {
            return Ok("Trip canceled");
        }
    }
}
