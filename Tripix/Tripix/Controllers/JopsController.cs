using Microsoft.AspNetCore.Mvc;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JopsController : ControllerBase
    {
        [HttpGet("Jops")]
        public IActionResult GetJops ()
        {
            return Ok();
        }
        [HttpPost("AddJop")]
        public IActionResult AddJop (AddJopDTO model)
        {
            return Ok();
        }
        [HttpPut("UpdateJop")]
        public IActionResult UpdateJop (int Id)
        {
            return Ok();
        }
        [HttpDelete("DeleteJop")]
        public IActionResult DeleteJop (int Id)
        {
            return Ok();
        }
        [HttpPost("ApplyForJop")]
        public IActionResult Apply_for_job (ApplyForJopDTO model)
        {
            return Ok();
        }
        [HttpGet("JopApplications")]
        public IActionResult GetJopApplications ()
        {
            return Ok();
        }
    }
}
