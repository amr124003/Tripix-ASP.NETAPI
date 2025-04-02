using Microsoft.AspNetCore.Mvc;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        public IActionResult GetSedanCars ()
        {
            return Ok("Sedan cars");
        }
        public IActionResult GetHatchbackCars ()
        {
            return Ok("Hatchback cars");
        }
        public IActionResult GetSUVCars ()
        {
            return Ok("SUV cars");
        }
        public IActionResult GetCoupeCars ()
        {
            return Ok("Coupe cars");
        }
        public IActionResult AddCar ()
        {
            return Ok("Car added");
        }
        public IActionResult UpdateCar ()
        {
            return Ok("Car updated");
        }
        public IActionResult DeleteCar ()
        {
            return Ok("Car deleted");
        }
        public IActionResult BookCar ()
        {
            return Ok("Car booked");
        }
        public IActionResult Sellcar ()
        {
            return Ok("Car sold");
        }
        public IActionResult LikeCar ()
        {
            return Ok("Car Loved");
        }
    }
}
