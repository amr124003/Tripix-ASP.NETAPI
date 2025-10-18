using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using Tripix.Abstractions;
using Tripix.Contracts.CarRental;
using Tripix.Services.Interfaces;
using Tripix.Services.Repositories;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarRentController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public CarRentController ( IUnitOfWork unitOfWork )
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet("AvilableCars")]
        public async Task<IActionResult> GetAvailable ()
        {
            var res = await unitOfWork.RentService.GetAvilableCars();

            return Ok(res);
        }
        [HttpGet("GetRentedCars")]
        
        public async Task<IActionResult> GetRentedCars (  )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitOfWork.RentService.GetCarsRented(UserId!);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpPost("RentCar")]
        
        public async Task<IActionResult> RentCar ( RentCarDTO model )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitOfWork.RentService.Rentcar(UserId!, model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpPost("ReturnCar")]
        
        public async Task<IActionResult> ReturnCar ( CancellCarForRent model )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var res = await unitOfWork.RentService.CancellCarforRent(UserId!, model);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpPost("AddCarForRent")]
        
        public async Task<IActionResult> AddCarForRent([FromForm] AddCarForRent model, CancellationToken canToken)
        {
            var res = await unitOfWork.RentService.AddCar(model);
            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpPut("UpdateCarForRent")]
        public async Task<IActionResult> UpdateCarForRent ([FromForm] UpdateCarForRentDTO model )
        {
            var res = await unitOfWork.RentService.UpdateCarForRent(model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpDelete("DeleteCarForRent")]
        public async Task<IActionResult> DeleteCarForRent ( int Id )
        {
            var res = await unitOfWork.RentService.DeleteCarForRent(Id);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpDelete("DeleteRent/{Id}")]
        public async Task<IActionResult> DeleteRent(int Id)
        {
            var res =await unitOfWork.RentService.DelelteRent(Id);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        
    }
}
