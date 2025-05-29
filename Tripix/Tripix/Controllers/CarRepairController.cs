using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Tripix.Abstractions;
using Tripix.Contracts.CarRepair;
using Tripix.Services.Interfaces;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarRepairController : ControllerBase
    {
        private readonly IUnitOfWork unitofwork;

        public CarRepairController ( IUnitOfWork unitofwork )
        {
            this.unitofwork = unitofwork;
        }
        [HttpPost("BookRepairTurn")]
        [Authorize]
        public async Task<IActionResult> BookRepair ( BookingTurnDTO model )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitofwork.repairService.BookingTurn(UserId, model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }

        [HttpPut("UpdateRepairTurn")]
        public async Task<IActionResult> UpdateTurn ( UpdateTurnDTO model )
        {
            var res = await unitofwork.repairService.UpdateTurn(model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpDelete("DeleteRepairTurn")]
        public async Task<IActionResult> DeleteTurn ( int Id )
        {
            var res = await unitofwork.repairService.DeleteTurn(Id);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpGet("Get-Repairs")]
        public async Task<IActionResult> GetRepairs ()
        {
            var res = await unitofwork.repairService.GetRepairBookings();

            return Ok(res);
        }
    }
}
