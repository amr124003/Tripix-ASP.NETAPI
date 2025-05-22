using Microsoft.AspNetCore.Mvc;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SparePartsController : ControllerBase
    {
        [HttpGet("SpareParts")]
        public IActionResult GetSpareParts ()
        {
            return Ok("Spare parts");
        }
        [HttpGet("Oils")]
        public IActionResult GetOils ()
        {
            return Ok("Oils");
        }
        [HttpGet("Accessories")]
        public IActionResult GetAccessories ()
        {
            return Ok("Accessories");
        }
        [HttpGet("Tyres")]
        public IActionResult GetTyres ()
        {
            return Ok("Tyres");
        }
        [HttpGet("ElectricSpareParts")]
        public IActionResult ElectricSpareParts ()
        {
            return Ok("Electric spare parts");
        }
        [HttpGet("SparePart")]
        public IActionResult GetSparePart ()
        {
            return Ok("Spare part");
        }
        [HttpPost("AddSparePart")]
        public IActionResult AddSparePart (AddSparePartDTO model)
        {
            return Ok("Spare part added");
        }
        [HttpPut("UpdateSparaParts")]
        public IActionResult UpdateSparePart (int Id)
        {
            return Ok("Spare part updated");
        }
        [HttpDelete("DeleteSparePart")]
        public IActionResult DeleteSparePart (int Id)
        {
            return Ok("Spare part deleted");
        }
        [HttpPost("OrderSpareParts")]
        public IActionResult OrderSparePart (SparePartOrderDTO model)
        {
            return Ok("Spare part booked");
        }

    }
}
