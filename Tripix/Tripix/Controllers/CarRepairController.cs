using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using Tripix.Abstractions;
using Tripix.Contracts.CarRepair;
using Tripix.Contracts.Common;
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
        
        public async Task<IActionResult> BookRepair ( BookingTurnDTO model )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitofwork.repairService.BookingTurn(UserId!, model);

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
        [HttpPost("Get-Repairs")]
        public async Task<IActionResult> GetRepairs (RequestFilter model , CancellationToken canToken)
        {
            var res = await unitofwork.repairService.GetRepairBookings(model , canToken);

            return Ok(res);
        }
        [HttpGet("GetTurns")]
        
        public async Task<IActionResult> GetTurns()
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitofwork.repairService.GetTurns(UserId!);

            return res.IsSuccess ? Ok(res?.Value) : res.ToProblem();
        }
        [HttpDelete("CancelTurn/{Id}")]
        public async Task<IActionResult> CancelTurn(int Id)
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

            var res = await unitofwork.repairService.CancelTurn(UserId!, Id);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
    }
}
