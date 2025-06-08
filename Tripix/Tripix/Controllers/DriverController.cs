using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Tripix.Abstractions;
using Tripix.Authentication;
using Tripix.Contracts.Driver;
using Tripix.Entities;
using Tripix.Hubs;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IJwtProvider jwtprovider;
        private readonly IHubContext<UserHub> hubcontext;

        public DriverController ( IUnitOfWork unitOfWork, IJwtProvider jwtprovider, IHubContext<UserHub> hubcontext )
        {
            this.unitOfWork = unitOfWork;

            this.jwtprovider = jwtprovider;
            this.hubcontext = hubcontext;
        }

        [HttpPost("RegisterDriver")]
        public async Task<IActionResult> RegisterDriver ( [FromForm] DriverRegisterDTO model )
        {
            var res = await unitOfWork.driverService.DriverRegister(model);

            return res.IsSuccess ? Ok(res) : res.ToProblem();

        }
        [HttpPut("UpdateDriver")]
        [Authorize]
        public async Task<IActionResult> UpdateDriver ( UpdateDriverData model )
        {
            var DriverId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

            var res = await unitOfWork.driverService.UpdateDriverData(DriverId, model);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpDelete("DeleteDriver")]
        public IActionResult DeleteDriver ( int Id )
        {
            return Ok("Driver deleted");
        }
        [HttpPost("Send-MSG")]
        public async Task<IActionResult> SendMSG ( DriverSendMSGDTO model )
        {
            var res = await unitOfWork.driverService.SendMessage(model);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpGet("Driver")]
        public async Task<IActionResult> GetDriver ( string Id )
        {
            var res = await unitOfWork.driverService.GetDriverData(Id);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpGet("Drivers")]
        public async Task<IActionResult> GetDrivers ()
        {
            var res = await unitOfWork.driverService.GetDrivers();

            return Ok(res);
        }
        [HttpPost("AcceptDriver")]
        public async Task<IActionResult> AcceptDriverRequest ( GetDriverDTO model )
        {
            var res = await unitOfWork.driverService.AcceptDriver(model.DriverId);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpPost("RejectDriver")]
        public async Task<IActionResult> RejectDriverRequest ( GetDriverDTO model )
        {
            var res = await unitOfWork.driverService.RejectDriver(model.DriverId);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpPost("DriverStatistics")]
        public IActionResult DriverStatistics ( GetDriverDTO model )
        {
            return Ok("Driver statistics");
        }
        [HttpPost("Update-Driver-Location")]
        public async Task<IActionResult> UpdateDriverLocation ( DriverLocation model )
        {
            if (!ModelState.IsValid) { return BadRequest(ModelState); }

            var driverToken = Request.Cookies["Driver-Ref-Token"];

            var UpdateStatus = await unitOfWork.driverService.UpdateDriverLocationAsync(driverToken!, model);

            return UpdateStatus ? Ok() : BadRequest(ModelState);
        }

        [HttpPost("Confirm-Trip")]
        public async Task<IActionResult> ConfirmTrip ( confirmTripDto model )
        {
            var DriverId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

            var confirmedTripResponse = await unitOfWork.driverService.ConfirmTrip(model, DriverId);

            await hubcontext.Clients.Group($"User {model.PhoneNumber}")
                   .SendAsync("NewDriver", confirmedTripResponse);

            return Ok(confirmedTripResponse);
        }
        [HttpGet("GetAvilableTrips")]
        public async Task<IActionResult> GetAvilableTrips ()
        {
            try
            {
                string DriverId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

                var trips = await unitOfWork.driverService.AvilableTrips(DriverId);

                return Ok(trips);
            }
            catch (DbUpdateConcurrencyException dbex)
            {
                return StatusCode(409, new
                {
                    message = "Concurrency issue occurred",
                    error = dbex.Message
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    message = "Unexpected error occurred",
                    error = ex.Message
                });
            }
        }

    }
}
