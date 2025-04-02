using Microsoft.AspNetCore.Mvc;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SparePartsController : ControllerBase
    {
        public IActionResult GetSpareParts ()
        {
            return Ok("Spare parts");
        }
        public IActionResult GetOils ()
        {
            return Ok("Oils");
        }
        public IActionResult GetAccessories ()
        {
            return Ok("Accessories");
        }
        public IActionResult GetTyres ()
        {
            return Ok("Tyres");
        }
        public IActionResult ElectricSpareParts ()
        {
            return Ok("Electric spare parts");
        }
        public IActionResult GetSparePart ()
        {
            return Ok("Spare part");
        }
        public IActionResult AddSparePart ()
        {
            return Ok("Spare part added");
        }
        public IActionResult UpdateSparePart ()
        {
            return Ok("Spare part updated");
        }
        public IActionResult DeleteSparePart ()
        {
            return Ok("Spare part deleted");
        }
        public IActionResult BookSparePart ()
        {
            return Ok("Spare part booked");
        }

    }
}
