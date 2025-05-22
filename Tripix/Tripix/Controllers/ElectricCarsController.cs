using Microsoft.AspNetCore.Mvc;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectricCarsController : ControllerBase
    {
        [HttpGet("BEVCars")]
        public IActionResult GetBEVCars ()
        {
            return Ok("BEV cars");
        }
        [HttpGet("PHEVCars")]
        public IActionResult GetPHEVCars ()
        {
            return Ok("PHEV cars");
        }
        [HttpGet("HEVCars")]
        public IActionResult GetHEVCars ()
        {
            return Ok("HEV cars");
        }
        [HttpPost("AddElctricCar")]
        public IActionResult AddElectricCar ( ElectricCarDTO model )
        {
            return Ok("Electric car added");
        }
        [HttpPut("UpdateElectricCar")]
        public IActionResult UpdateElectricCar ( int Id )
        {
            return Ok("Electric car updated");
        }
        [HttpDelete("DeleteElectricCar")]
        public IActionResult DeleteElectricCar ( int Id )
        {
            return Ok("Electric car deleted");
        }
        [HttpPost("BookingElectricCar")]
        public IActionResult BookingElectricCar ( CarBookingDTO model )
        {
            return Ok("Electric car booked");
        }
    }
}
