using Microsoft.AspNetCore.Mvc;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectricCarsController : ControllerBase
    {
        public IActionResult GetBEVCars ()
        {
            return Ok("BEV cars");
        }
        public IActionResult GetPHEVCars ()
        {
            return Ok("PHEV cars");
        }
        public IActionResult GetHEVCars ()
        {
            return Ok("HEV cars");
        }
        public IActionResult GetFCEVCars ()
        {
            return Ok("FCEV cars");
        }
        public IActionResult AddElectricCar ()
        {
            return Ok("Electric car added");
        }
        public IActionResult UpdateElectricCar ()
        {
            return Ok("Electric car updated");
        }
        public IActionResult DeleteElectricCar ()
        {
            return Ok("Electric car deleted");
        }
        public IActionResult BookElectricCar ()
        {
            return Ok("Electric car booked");
        }
    }
}
