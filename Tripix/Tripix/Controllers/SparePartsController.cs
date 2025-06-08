using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using Tripix.Abstractions;
using Tripix.Contracts.Common;
using Tripix.Contracts.SpareParts;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SparePartsController : ControllerBase
    {
        private readonly IUnitOfWork unitofWork;

        public SparePartsController(IUnitOfWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }
        [HttpGet("SpareParts")]
        public async Task<IActionResult> GetSpareParts (RequestFilter model , CancellationToken canToken)
        {
            var res = await unitofWork.SparePartRepo.GetAll(model , canToken);

            return Ok(res);
        }
        [HttpGet("SparePart/{Id}")]
        public async Task<IActionResult> GetSparePart (int Id)
        {
            var res = await unitofWork.SparePartRepo.GetSparePart(Id);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpPost("AddSparePart")]
        public async Task<IActionResult> AddSparePart ( AddSparePartDTO model , CancellationToken canToken)
        {
            var res = await unitofWork.SparePartRepo.AddSparePart(model , canToken);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpPut("UpdateSparaParts")]
        public async Task<IActionResult> UpdateSparePart (UpdateSparePart model)
        {
            var res = await unitofWork.SparePartRepo.UpdateSparePart(model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpDelete("DeleteSparePart")]
        public async Task<IActionResult> DeleteSparePart ( int Id )
        {
            var res = await unitofWork.SparePartRepo.DeleteSparePart(Id);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpPost("OrderSpareParts")]
        [Authorize]
        public async Task<IActionResult> OrderSparePart ( SparePartOrderDTO model )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var res = await unitofWork.SparePartRepo.OrderSparePart(UserId!, model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpPost("GetOrders")]
        [Authorize]
        public async Task<IActionResult> GetOrders (RequestFilter model , CancellationToken canToken)
        {
            var res = await unitofWork.SparePartRepo.GetOrders(model, canToken);

            return Ok(res);
        }
        [HttpGet("GetOrder/{Id}")]
        [Authorize]
        public async Task<IActionResult> GetOrder ( int Id , CancellationToken canToken)
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var res = await unitofWork.SparePartRepo.GetOrder(UserId, Id, canToken);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpDelete("CancelOrder/{Id}")]
        public async Task<IActionResult> CancelOrder ( int Id  , CancellationToken canToken)
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var res = await unitofWork.SparePartRepo.CancelSparePartOrder(UserId, Id, canToken);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpDelete("DeleteOrder/{Id}")]
        public async Task<IActionResult> DeleteOrderAsync (int Id)
        {
            var res = await unitofWork.SparePartRepo.DeleteOrder(Id);

            return res.IsSuccess ? Ok(res) : res.ToProblem();

        }
        [HttpGet("GetUserOrders")]
        public async Task<IActionResult> GetUserOrderAsync(CancellationToken canToken)
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var res = await unitofWork.SparePartRepo.GetUserOrders(UserId!, canToken);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpPut("UpdateUserOrder")]
        public async Task<IActionResult> UpdateUserOrderAsync (UpdateSparePartOrder model)
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitofWork.SparePartRepo.UpdateOrder(UserId!, model);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
    }
}
