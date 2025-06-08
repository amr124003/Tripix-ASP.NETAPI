using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
    public class CarsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public CarsController (IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpPost("GetCars")]
        public async Task<IActionResult> GetCars ( RequestFilter model )
        {
            var res = await unitOfWork.carRepo.GetCars(model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpPost("AddCar")]
        public async Task<IActionResult> AddNewCar ( CarDTO model )
        {
            var res = await unitOfWork.carRepo.AddCar(model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpPut("UpdateNewCar")]
        public async Task<IActionResult> UpdateCar ( int Id, CarDTO model )
        {
            var res = await unitOfWork.carRepo.UpdateCar(Id, model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpGet("GetCar/{Id}")]
        public async Task<IActionResult> GetCar(int Id)
        {
            var res = await  unitOfWork.carRepo.GetCar(Id);

            return res.IsSuccess ? Ok(res.IsSuccess) : res.ToProblem();
        }
        [HttpDelete("DeleteNewCar")]
        public async Task<IActionResult> DeleteCar ( int Id )
        {
            var res = await unitOfWork.carRepo.DeleteCar(Id);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        
        [HttpPost("SellCar")]
        public IActionResult Sellcar ()
        {
            return Ok("Car sold");
        }
        
        [HttpGet("GetPrands")]
        public async Task<IActionResult> Getbrands()
        {
            var res = await unitOfWork.carRepo.GetBrands();

            return Ok(res);
        }
    }
}
