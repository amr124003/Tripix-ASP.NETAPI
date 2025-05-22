using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Tripix.Abstractions;
using Tripix.Contracts.CarRental;
using Tripix.Services.Interfaces;

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
        [HttpPost("ReturnedCars")]
        [Authorize]
        public async Task<IActionResult> GetRented ( CancellCarForRent model )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitOfWork.RentService.GetCarRented(UserId);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpPost("RentCar")]
        [Authorize]
        public async Task<IActionResult> RentCar ( RentCarDTO model )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitOfWork.RentService.Rentcar(UserId, model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpPost("ReturnCar")]
        public async Task<IActionResult> ReturnCar ( int Id )
        {
            var res = await unitOfWork.RentService.CancellCarforRent(Id);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpPost("AddCarForRent")]
        public async Task<IActionResult> AddCarForRent ( AddCarforRent model )
        {
            var res = await unitOfWork.RentService.AddCar(model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpPut("UpdateCarForRent")]
        public async Task<IActionResult> UpdateCarForRent ( UpdateCarForRentDTO model )
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
    }
}
