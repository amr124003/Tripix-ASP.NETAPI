using Microsoft.AspNetCore.Mvc;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileAppADSController : ControllerBase
    {
        public IActionResult DowloadMobileApp ()
        {
            return Ok("Mobile app downloaded");
        }
    }
}
