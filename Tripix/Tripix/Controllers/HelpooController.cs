using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Threading.Tasks;
using Tripix.Abstractions;
using Tripix.Contracts.Helpoo;
using Tripix.Services.Interfaces;
using Tripix.Services.Repositories;
using Tripix.View_Models;


namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelpooController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public HelpooController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpPost("OrderHelpoo")]
        [Authorize]
        public async Task<IActionResult> OrderHelpoo(OrderHelpooDTO model)
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

            var res = await unitOfWork.HelpooService.OrderHelpoo(UserId, model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpGet("OrderDetails")]
        [Authorize]
        public async Task<IActionResult> GetOrderDetails(int Id)
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitOfWork.HelpooService.GetOrderDetails(Id, UserId!);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpPut("UpdateOrder")]
        [Authorize]
        public async Task<IActionResult> UpdateTurn(UpdateHelpooDTO model)
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitOfWork.HelpooService.UpdateOrderDetials(UserId!, model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpDelete("CancelOrder")]
        public async Task<IActionResult> DeleteTurnAsync(int Id)
        {
            var res = await unitOfWork.HelpooService.DeleteOrder(Id);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpGet("HelpooOrders")]
        public IActionResult GetOrders()
        {
            var res = unitOfWork.HelpooService.GetOrders();

            return Ok(res);
        }
        [HttpPost("CencelOrder")]
        public async Task<IActionResult> Cancelturn(int Id)
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;

            var res = await unitOfWork.HelpooService.CancelOrder(UserId, Id);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }

    }
}
