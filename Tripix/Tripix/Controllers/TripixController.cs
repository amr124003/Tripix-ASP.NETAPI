using Mapster;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Security.Claims;
using Tripix.Abstractions;
using Tripix.Contracts.Driver;
using Tripix.Contracts.Trip;
using Tripix.Entities;
using Tripix.Hubs;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripixController : ControllerBase
    {

        private readonly IHubContext<RideHub> hubcontext;
        private readonly IUnitOfWork unitOfWork;

        public TripixController ( IHubContext<RideHub> hubcontext, IUnitOfWork unitOfWork )
        {
            this.hubcontext = hubcontext;
            this.unitOfWork = unitOfWork;
        }

        [HttpPost("OrderTrip")]
        public async Task<IActionResult> OrderTrip ( OrderTripDTO model )
        {
            var authHeader = Request.Headers["Authorization"].FirstOrDefault();
            var token = "";

            if (authHeader != null && authHeader.StartsWith("Bearer "))
            {
                token = authHeader.Substring("Bearer ".Length).Trim();
                
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var tripResponse = await unitOfWork.tripService.OrderTripAsync(token, model);

            if (!tripResponse.IsSuccess) { return tripResponse.ToProblem(); }

            LocationDTO location = new(model.PickupLatitude, model.PickupLongitude);

            var Drivers = await unitOfWork.driverService.GetNearsetDriversAsync(location);

            if (!Drivers.Any()) { return BadRequest("Not Availbale Drivers Yet"); }

            var trip = tripResponse.Value.Adapt<Trip>();

            foreach (var driver in Drivers)
            {
                await hubcontext.Clients.Group($"Driver {driver.Id}")
                    .SendAsync("NewTrip", tripResponse.Value);

                await unitOfWork.driverService.SetTripAsAvailable(trip, driver);
            }

            return tripResponse.IsSuccess ? Ok(tripResponse) : tripResponse.ToProblem();
        }

        [HttpPost("GetTripDetails")]
        public async Task<IActionResult> GetTripDetails ( GetTripDetails model )
        {
            var Res = await unitOfWork.tripService.GetTripDetails(model);

            return Res.IsSuccess ? Ok(Res.Value) : Res.ToProblem();
        }
        [HttpPost("CancelTrip")]
        
        public async Task<IActionResult> CancelTrip ( int TripId )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitOfWork.tripService.CancelTrip(UserId!, TripId);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpPost("Confirm-Driver")]
        public async Task<IActionResult> ConfirmDriver ( confirmDriverDTO model )
        {
            var res = await unitOfWork.tripService.ConfirmDriver(model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
    }
}
