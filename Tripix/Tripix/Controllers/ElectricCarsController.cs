using Microsoft.AspNetCore.Mvc;
using Tripix.Abstractions;
using Tripix.Contracts.Common;
using Tripix.Contracts.ElectricCar;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ElectricCarsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public ElectricCarsController (IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpPost("GetElectricCars")]
        public async Task<IActionResult> GetElectricCars ( RequestFilter model )
        {
            var response = await unitOfWork.ElectricCarRepo.GetAll(model);

            return Ok(response);
        }

        [HttpPost("AddElctricCar")]
        public async Task<IActionResult> AddElectricCar ( AddElectricCatDTO model )
        {
            var response = await unitOfWork.ElectricCarRepo.AddCar(model);

            return response.IsSuccess ? Ok(response.Value) : response.ToProblem();
        }
        [HttpPut("UpdateElectricCar")]
        public async Task<IActionResult> UpdateElectricCar ( UpdateElectricCarDto model )
        {
            var response = await unitOfWork.ElectricCarRepo.UpdateCar(model);

            return response.IsSuccess ? Ok(response.Value) : response.ToProblem();
        }
        [HttpDelete("DeleteElectricCar")]
        public async Task<IActionResult> DeleteElectricCar ( int Id )
        {
            var response = await unitOfWork.ElectricCarRepo.DeleteCar(Id);

            return response.IsSuccess ? Ok(response) : response.ToProblem();
        }
        [HttpGet("GetBrands")]
        public async Task<IActionResult> GetBrands ()
        {
            var response = await unitOfWork.ElectricCarRepo.GetBrands();

            return Ok(response);
        }
    }
}
