using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Tripix.Abstractions;
using Tripix.Contracts.Common;
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
        
        public async Task<IActionResult> BookTurn ( AddWashDTO model )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var response = await unitOfWork.WashServiceRepo.BookingTurn(UserId!, model);

            return response.IsSuccess ? Ok(response) : response.ToProblem();
        }
        [HttpGet("GetWashTurn/{TurnId}")]
        
        public async Task<IActionResult> GetTurnDetails ( int TurnId )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var response = await unitOfWork.WashServiceRepo.GetTurnDetails(TurnId, UserId!);

            return response.IsSuccess ? Ok(response.Value) : response.ToProblem();
        }
        [HttpPut("UpdateBooking")]
        
        public async Task<IActionResult> UpdateTurn ( UpdateWashTurnDTO model )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var response = await unitOfWork.WashServiceRepo.UpdateTurn(UserId, model);

            return response.IsSuccess ? Ok(response.Value) : response.ToProblem();
        }
        [HttpDelete("CencelBooking")]
        
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
        [HttpPost("GetWashBookings")]
        
        public async Task<IActionResult> GetTurns (RequestFilter model , CancellationToken canToken)
        {
            var response = await unitOfWork.WashServiceRepo.GetTurns(model , canToken);

            return Ok(response);
        }
        [HttpGet("GetUserTurns")]
        public async Task<IActionResult> GetUserTurns(CancellationToken canToken)
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitOfWork.WashServiceRepo.GetUserTurn(UserId!, canToken);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }

    }
}
