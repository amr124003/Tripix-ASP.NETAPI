using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Tripix.Abstractions;
using Tripix.Services.Interfaces;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IUnitOfWork unitofWork;

        public VehicleController ( IUnitOfWork unitofWork )
        {
            this.unitofWork = unitofWork;
        }
        [HttpPost("BookVehicle/{CarId}")]
        [Authorize]
        public async Task<IActionResult> BookVehicle ( int CarId )
        {
            var Userd = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var response = await unitofWork.VehicleRepo.BookVehicle(Userd!, CarId);

            return response.IsSuccess ? Ok(response.Value) : response.ToProblem();
        }
        [HttpPost("LikeCar/{CarId}")]
        [Authorize]
        public async Task<IActionResult> LikeCar ( int CarId )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var response = await unitofWork.VehicleRepo.LikeVehicle(UserId, CarId);

            return response.IsSuccess ? Ok(response) : response.ToProblem();
        }
    }
}
