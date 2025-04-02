using Microsoft.AspNetCore.Mvc;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        public IActionResult GetNotifications ()
        {
            return Ok("Notifications");
        }
        public IActionResult GetNotification ()
        {
            return Ok("Messages");
        }
        public IActionResult GetAlerts ()
        {
            return Ok("Alerts");
        }
        public IActionResult GetAD ()
        {
            return Ok("AD");
        }
    }
}
