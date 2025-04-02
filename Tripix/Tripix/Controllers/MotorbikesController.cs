using Microsoft.AspNetCore.Mvc;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorbikesController : ControllerBase
    {
        public IActionResult GetStandardMotorbikes ()
        {
            return Ok("Standard motorbikes");
        }
        public IActionResult GetCruiserMotorbikes ()
        {
            return Ok("Cruiser motorbikes");
        }
        public IActionResult GetSportMotorbikes ()
        {
            return Ok("Sport motorbikes");
        }
        public IActionResult GetOff_RoadMotorbikes ()
        {
            return Ok("Off_Road motorbikes");
        }
        public IActionResult AddMotorbike ()
        {
            return Ok("Motorbike added");
        }
        public IActionResult UpdateMotorbike ()
        {
            return Ok("Motorbike updated");
        }
        public IActionResult DeleteMotorbike ()
        {
            return Ok("Motorbike deleted");
        }
        public IActionResult BookMotorbike ()
        {
            return Ok("Motorbike booked");
        }

    }
}
