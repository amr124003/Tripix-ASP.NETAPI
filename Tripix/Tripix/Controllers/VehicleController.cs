using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using Tripix.Abstractions;
using Tripix.Contracts.Vehicle;
using Tripix.Services.Interfaces;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly IUnitOfWork unitofWork;

        public VehicleController(IUnitOfWork unitofWork)
        {
            this.unitofWork = unitofWork;
        }
        [HttpPost("BookVehicle")]
        
        public async Task<IActionResult> BookVehicle(VehicleDTO model)
        {
            var Userd = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var response = await unitofWork.VehicleRepo.BookVehicle(Userd!, model.VehicleId);

            return response.IsSuccess ? Ok(response.Value) : response.ToProblem();
        }
        [HttpPost("LikeVehicle")]
        
        public async Task<IActionResult> LikeCar(VehicleDTO model)
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var response = await unitofWork.VehicleRepo.LikeVehicle(UserId!, model.VehicleId);

            return response.IsSuccess ? Ok(response) : response.ToProblem();
        }
        [HttpPost("Dislike")]
        
        public async Task<IActionResult> DisLike(VehicleDTO model)
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var response = await unitofWork.VehicleRepo.DisLikeVehicle(UserId!, model.VehicleId);

            return response.IsSuccess ? Ok(response) : response.ToProblem();
        }
        [HttpGet("GetVehicleBookings/{Category}")]
        public async Task<IActionResult> GetVehicleBookings(string Category)
        {
            var res = await unitofWork.VehicleRepo.GetVehcileBookings(Category);

            return Ok(res);
        }
        [HttpDelete("DeleteBookings/{Id}")]
        public async Task<IActionResult> DeleteBookings (int Id)
        {
            var res =await unitofWork.VehicleRepo.DeleteBooking(Id);

            return res.IsSuccess ? Ok(res) : res.ToProblem(); 
        }
    }
}
