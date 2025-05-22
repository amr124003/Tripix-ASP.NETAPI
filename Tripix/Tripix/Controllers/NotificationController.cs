using Microsoft.AspNetCore.Mvc;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        [HttpGet("Notifications")]
        public IActionResult GetNotifications ()
        {
            return Ok("Notifications");
        }
        [HttpGet("Notification")]
        public IActionResult GetNotification ()
        {
            return Ok("Messages");
        }
        [HttpGet("Alerts")]
        public IActionResult GetAlerts ()
        {
            return Ok("Alerts");
        }
        [HttpGet("DisplayAD")]
        public IActionResult GetAD ()
        {
            return Ok("AD");
        }
    }
}
