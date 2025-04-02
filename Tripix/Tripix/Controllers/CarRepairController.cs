using Microsoft.AspNetCore.Mvc;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarRepairController : ControllerBase
    {
        public IActionResult GetRepairs ()
        {
            return Ok("Repairs");
        }
        public IActionResult GetRepair ()
        {
            return Ok("Repair");
        }
        public IActionResult AddRepair ()
        {
            return Ok("Repair added");
        }
        public IActionResult UpdateRepair ()
        {
            return Ok("Repair updated");
        }
        public IActionResult DeleteRepair ()
        {
            return Ok("Repair deleted");
        }
        public IActionResult BookRepair ()
        {
            return Ok("Repair booked");
        }
    }
}
