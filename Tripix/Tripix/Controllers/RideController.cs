using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Tripix.Hubs;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RideController : ControllerBase
    {
        private readonly IHubContext<RideHub> hubcontext;

        public RideController (IHubContext<RideHub> Hubcontext)
        {
            hubcontext = Hubcontext;
        }
        [HttpPost("Update-location")]
        public IActionResult UpdateDriverLocation ( [FromBody] DriverLocationDTO model)
        {
            if (model == null || string.IsNullOrEmpty(model.RideID))
            {
                return BadRequest("Invalid data.");
            }
            // Send the driver's location to all clients in the ride group
            hubcontext.Clients.Group(model.RideID).SendAsync("ReceiveDriverLocation", model.Latitude, model.Longitude);
            return Ok("Driver location updated successfully.");
        }
    }
}
