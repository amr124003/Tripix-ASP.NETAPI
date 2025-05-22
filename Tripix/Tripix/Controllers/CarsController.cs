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
        private readonly ICarRepo carRepo;

        public CarsController ( ICarRepo CarRepo )
        {
            carRepo = CarRepo;
        }
        [HttpPost("GetCars")]
        public async Task<IActionResult> GetCars ( RequestFilter model )
        {
            var res = await carRepo.GetCars(model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpPost("AddCar")]
        public async Task<IActionResult> AddNewCar ( CarDTO model )
        {
            var res = await carRepo.AddCar(model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpPut("UpdateNewCar")]
        public async Task<IActionResult> UpdateCar ( int Id, CarDTO model )
        {
            var res = await carRepo.UpdateCar(Id, model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpDelete("DeleteNewCar")]
        public async Task<IActionResult> DeleteCar ( int Id )
        {
            var res = await carRepo.DeleteCar(Id);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpPost("BookCar")]
        [Authorize]
        public async Task<IActionResult> BookingCar ( BookCarDto model )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var res = await carRepo.BookingCar(UserId, model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpPost("SellCar")]
        public IActionResult Sellcar ()
        {
            return Ok("Car sold");
        }
        [HttpPost("LikeCar")]
        [Authorize]
        public async Task<IActionResult> LikeCar ( LikeCarDTO model )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)!.Value;
            var res = await carRepo.LikeCar(UserId, model);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpGet("GetPrands")]
        public async Task<IActionResult> Getbrands()
        {
            var res = await carRepo.GetBrands();

            return Ok(res);
        }
    }
}
