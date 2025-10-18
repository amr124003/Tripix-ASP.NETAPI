using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using System.Security.Claims;
using System.Threading.Tasks;
using Tripix.Abstractions;
using Tripix.Contracts.Car;
using Tripix.Contracts.Common;
using Tripix.Services.Interfaces;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsedVehicleController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public UsedVehicleController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpPost("SellCar")]
        
        public async Task<IActionResult> Sellcar([FromForm]SellCarDto model, CancellationToken canToken)
        {
            var res = await unitOfWork.carRepo.SellCar(model, canToken);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpPost("GetUsedCars")]
        public async Task<IActionResult> GetUsedCars(RequestFilter model, CancellationToken canToken)
        {
            var usedId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var res = await unitOfWork.carRepo.GetUsedVehicles(usedId, model, canToken);
            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
    }
}
