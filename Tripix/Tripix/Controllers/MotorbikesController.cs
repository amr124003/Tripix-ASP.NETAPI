using Microsoft.AspNetCore.Mvc;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorbikesController : ControllerBase
    {
        [HttpGet("StandardMotorbikes")]
        public IActionResult GetStandardMotorbikes ()
        {
            return Ok("Standard motorbikes");
        }
        [HttpGet("CruiserMotorbikes")]
        public IActionResult GetCruiserMotorbikes ()
        {
            return Ok("Cruiser motorbikes");
        }
        [HttpGet("SportMotorbikes")]
        public IActionResult GetSportMotorbikes ()
        {
            return Ok("Sport motorbikes");
        }
        [HttpGet("Off_RoadMotorbikes")]
        public IActionResult GetOff_RoadMotorbikes ()
        {
            return Ok("Off_Road motorbikes");
        }
        [HttpPost("AddMotorbike")]
        public IActionResult AddMotorbike (AddmotorbikesDTO model)
        {
            return Ok("Motorbike added");
        }
        [HttpPut("UpdateMotorbike")]
        public IActionResult UpdateMotorbike (int Id)
        {
            return Ok("Motorbike updated");
        }
        [HttpDelete("DeleteMotorbike")]
        public IActionResult DeleteMotorbike (int Id)
        {
            return Ok("Motorbike deleted");
        }
        [HttpPost("BookingMotorbike")]
        public IActionResult BookMotorbike ()
        {
            return Ok("Motorbike booked");
        }

    }
}
