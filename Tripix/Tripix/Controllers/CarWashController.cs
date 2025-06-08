using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Tripix.Abstractions;
using Tripix.Contracts.Wash;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarWashController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public CarWashController ( IUnitOfWork unitOfWork )
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpPost("BookWashTurn")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> BookTurn ( AddWashDTO model )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var response = await unitOfWork.WashServiceRepo.BookingTurn(UserId!, model);

            return response.IsSuccess ? Ok(response) : response.ToProblem();
        }
        [HttpGet("GetWashTurn/{TurnId}")]
        [Authorize]
        public async Task<IActionResult> GetTurnDetails ( int TurnId )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var response = await unitOfWork.WashServiceRepo.GetTurnDetails(TurnId, UserId!);

            return response.IsSuccess ? Ok(response.Value) : response.ToProblem();
        }
        [HttpPut("UpdateBooking")]
        [Authorize]
        public async Task<IActionResult> UpdateTurn ( UpdateWashTurnDTO model )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var response = await unitOfWork.WashServiceRepo.UpdateTurn(UserId, model);

            return response.IsSuccess ? Ok(response.Value) : response.ToProblem();
        }
        [HttpDelete("CencelBooking")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteTurn ( int Id )
        {
            var response = await unitOfWork.WashServiceRepo.DeleteTurn(Id);

            return response.IsSuccess ? Ok(response) : response.ToProblem();

        }
        [HttpDelete("CancelTurn")]
        public async Task<IActionResult> CancelTurn ( int Id )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var response = await unitOfWork.WashServiceRepo.CancelTurn(UserId!, Id);

            return response.IsSuccess ? Ok(response) : response.ToProblem();
        }
        [HttpGet("GetWashBookings")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetTurns ()
        {
            var response = await unitOfWork.WashServiceRepo.GetTurns();

            return Ok(response);
        }
    }
}
