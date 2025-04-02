using Microsoft.AspNetCore.Mvc;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        public IActionResult RegisterDriver ()
        {
            return Ok("Driver registered");
        }
        public IActionResult LoginDriver ()
        {
            return Ok("Driver logged in");
        }
        public IActionResult UpdateDriver ()
        {
            return Ok("Driver updated");
        }
        public IActionResult DeleteDriver ()
        {
            return Ok("Driver deleted");
        }
        public IActionResult GetDriver ()
        {
            return Ok("Driver");
        }
        public IActionResult GetDrivers ()
        {
            return Ok("Drivers");
        }
        public IActionResult GetDriverTrips ()
        {
            return Ok("Driver trips");
        }
        public IActionResult GetDriverTrip ()
        {
            return Ok("Driver trip");
        }
        public IActionResult GetDriverApplications ()
        {
            return Ok("Driver trip request");
        }
        public IActionResult AcceptDriverRequest ()
        {
            return Ok("Driver trip request accepted");
        }
        public IActionResult RejectDriverRequest ()
        {
            return Ok("Driver trip request rejected");
        }
        public IActionResult DriverStatistics ()
        {
            return Ok("Driver statistics");
        }
        public IActionResult DisplayTrip ()
        {
            return Ok("Trip displayed");
        }
    }
}
