using Microsoft.AspNetCore.Mvc;
using Tripix.Abstractions;
using Tripix.Contracts.Common;
using Tripix.Contracts.Motorbikes;
using Tripix.Services.Interfaces;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotorbikesController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public MotorbikesController ( IUnitOfWork unitOfWork )
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpPost("GetMotorbikes")]
        public async Task<IActionResult> GetMotorbikes ( [FromBody] RequestFilter filters )
        {
            var response = await unitOfWork.MotorbikeRepo.GetAll(filters);

            return Ok(response);
        }
        [HttpPost("AddMotorbike")]
        public async Task<IActionResult> AddMotorbike ( [FromBody] AddMotorbikeDTO model )
        {
            var response = await unitOfWork.MotorbikeRepo.AddMotorbike(model);

            return response.IsSuccess ? Ok(response.Value) : response.ToProblem();
        }
        [HttpPut("UpdateMotorbike")]
        public async Task<IActionResult> UpdateMotorbike ( [FromBody] UpdateMotorbikeDTO model )
        {
            var response = await unitOfWork.MotorbikeRepo.UpdateMotorbike(model);

            return response.IsSuccess ? Ok(response.Value) : response.ToProblem();
        }
        [HttpDelete("DeleteMotorbike/{Id}")]
        public async Task<IActionResult> DeleteMotorbikeAsync ( int Id )
        {
            var response = await unitOfWork.MotorbikeRepo.DeleteMotorbike(Id);

            return response.IsSuccess ? Ok(response) : response.ToProblem();
        }
        [HttpGet("GetMotorbikesBrands")]
        public async Task<IActionResult> Getbrands ()
        {
            var res = await unitOfWork.MotorbikeRepo.GetBrands();

            return Ok(res);
        }


    }
}
