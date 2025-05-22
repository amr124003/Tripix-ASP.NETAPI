using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Tripix.Abstractions;
using Tripix.Authentication;
using Tripix.Context;
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
        private readonly ApplicationDbcontext context;
        private readonly UserManager<ApplicationUser> usermanger;
        private readonly IJwtProvider jwtprovider;
        private readonly IHubContext<UserHub> hubcontext;

        public DriverController ( IUnitOfWork unitOfWork, ApplicationDbcontext context, UserManager<ApplicationUser> usermanger, IJwtProvider jwtprovider, IHubContext<UserHub> hubcontext )
        {
            this.unitOfWork = unitOfWork;
            this.context = context;
            this.usermanger = usermanger;
            this.jwtprovider = jwtprovider;
            this.hubcontext = hubcontext;
        }

        [HttpPost("RegisterDriver")]
        public async Task<IActionResult> RegisterDriver ( [FromForm] DriverRegisterDTO model )
        {
            var res  = await unitOfWork.driverService.DriverRegister (model);

            return res.IsSuccess ? Ok(res) : res.ToProblem();    

        }
        
        
        [HttpPut("UpdateDriver")]
        public IActionResult UpdateDriver ( int Id )
        {
            return Ok("Driver updated");
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
        public IActionResult GetDriver ( int Id )
        {
            return Ok("Driver");
        }
        [HttpGet("Drivers")]
        public IActionResult GetDrivers ()
        {
            return Ok("Drivers");
        }
        [HttpGet("DriverTrips")]
        public IActionResult GetDriverTrips ( int Id )
        {
            return Ok("Driver trips");
        }
        [HttpPost("AcceptDriver")]
        public IActionResult AcceptDriverRequest ( string Email )
        {
            return Ok("Driver trip request accepted");
        }
        [HttpPost("RejectDriver")]
        public IActionResult RejectDriverRequest ( string Email )
        {
            return Ok("Driver trip request rejected");
        }
        [HttpPost("DriverStatistics")]
        public IActionResult DriverStatistics ( int Id )
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
            var authHeader = Request.Headers["Authorization"].FirstOrDefault();
            var token = "";

            if (authHeader != null && authHeader.StartsWith("Bearer "))
            {
                token = authHeader.Substring("Bearer ".Length).Trim();
            }

            var driverId = jwtprovider.ValidateToken(token);

            var confirmedTripResponse = await unitOfWork.driverService.ConfirmTrip(model, driverId);

            await hubcontext.Clients.Group($"User {model.PhoneNumber}")
                   .SendAsync("NewDriver", confirmedTripResponse);

            return Ok(confirmedTripResponse);
        }
        [HttpGet("GetAvilableTrips")]
        public async Task<IActionResult> GetAvilableTrips ()
        {
            try
            {
                var authHeader = Request.Headers["Authorization"].FirstOrDefault();
                var token = "";

                if (authHeader != null && authHeader.StartsWith("Bearer "))
                {
                    token = authHeader.Substring("Bearer ".Length).Trim();
                }

                var trips = await unitOfWork.driverService.AvilableTrips(token);

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




        private void SetRefreshTokenCookie ( string refreshToken )
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,   // „‰⁄ «·Ê’Ê· „‰ JavaScript
                Secure = true,     // ≈—”«· «·ﬂÊﬂÌ ›ﬁÿ ⁄»— HTTPS
                SameSite = SameSiteMode.Strict,
                Expires = DateTime.UtcNow.AddDays(15)
            };

            Response.Cookies.Append("Driver-Ref-Token", refreshToken, cookieOptions);
        }

    }
}
