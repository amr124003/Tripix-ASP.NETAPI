using Mapster;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Tripix.Abstractions;
using Tripix.Contracts.Driver;
using Tripix.Contracts.Trip;
using Tripix.Entities;
using Tripix.Hubs;
using Tripix.Services;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripixController : ControllerBase
    {
        private readonly ITripRepo tripRepo;
        private readonly IDriverRepo driverRepo;
        private readonly IHubContext<RideHub> hubcontext;

        public TripixController ( ITripRepo tripRepo, IDriverRepo DriverRepo, IHubContext<RideHub> hubcontext )
        {
            this.tripRepo = tripRepo;
            driverRepo = DriverRepo;
            this.hubcontext = hubcontext;
        }

        [HttpPost("OrderTrip")]
        public async Task<IActionResult> OrderTrip ( OrderTripDTO model )
            {
            var authHeader = Request.Headers["Authorization"].FirstOrDefault();
            var token = "";

            if (authHeader != null && authHeader.StartsWith("Bearer "))
            {
                token = authHeader.Substring("Bearer ".Length).Trim();
                // ﬂœÂ „⁄«ﬂ «· token ›Ì «·„ €Ì— token
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var tripResponse = await tripRepo.OrderTripAsync(token, model);

            if (!tripResponse.IsSuccess) { return tripResponse.ToProblem(); }

            LocationDTO location = new(model.PickupLatitude, model.PickupLongitude);

            var Drivers = await driverRepo.GetNearsetDriversAsync(location);

            if (!Drivers.Any()) { return BadRequest("Not Availbale Drivers Yet"); }

            var trip = tripResponse.Value.Adapt<Trip>();

            foreach (var driver in Drivers)
            {
                await hubcontext.Clients.Group($"Driver {driver.Id}")
                    .SendAsync("NewTrip", tripResponse.Value);

                await driverRepo.SetTripAsAvailable(trip, driver);
            }

            return tripResponse.IsSuccess ? Ok(tripResponse) : tripResponse.ToProblem();
        }

        [HttpPost("GetTripDetails")]
        public async Task<IActionResult> GetTripDetails ( GetTripDetails model )
        {
            var Res = await tripRepo.GetTripDetails(model);

            return Res.IsSuccess ? Ok(Res.Value) : Res.ToProblem();
        }
        [HttpPut("UpdateTrip")]
        public IActionResult UpdateTrip ( int TripId )
        {
            return Ok("Trip updated");
        }
        [HttpDelete("DeleteTrip")]
        public IActionResult DeleteTrip ( int TripId )
        {
            return Ok("Trip deleted");
        }
        [HttpGet("Trips")]
        public IActionResult GetTrips ()
        {
            return Ok("Trips");
        }
        [HttpPost("CancelTrip")]
        public IActionResult CancelTrip ( int TripId )
        {
            return Ok("Trip canceled");
        }
        [HttpPost("Confirm-Driver")]
        public async Task<IActionResult> ConfirmDriver ( confirmDriverDTO model )
        {
            var res = await tripRepo.ConfirmDriver(model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
    }
}
