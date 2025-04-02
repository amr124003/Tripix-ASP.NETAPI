using Microsoft.AspNetCore.Mvc;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarRentController : ControllerBase
    {
        public IActionResult GetAvailable ()
        {
            return Ok("Available cars");
        }
        public IActionResult GetRented ()
        {
            return Ok("Rented cars");
        }
        public IActionResult RentCar ()
        {
            return Ok("Car rented");
        }
        public IActionResult ReturnCar ()
        {
            return Ok("Car returned");
        }
        public IActionResult AddCarForRent ()
        {
            return Ok("Car added");
        }
        public IActionResult UpdateCarForRent ()
        {
            return Ok("Car updated");
        }
        public IActionResult DeleteCarForRent ()
        {
            return Ok("Car deleted");
        }
    }
}
