using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto;
using System.Security.Claims;
using System.Threading.Tasks;
using Tripix.Abstractions;
using Tripix.Contracts.Jop;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JopsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public JopsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet("Jops")]
        public async Task<IActionResult> GetJops()
        {
            var res = await unitOfWork.JopRepo.GetJopsAsync();

            return Ok(res);

        }
        [HttpPost("AddJop")]
        public async Task<IActionResult> AddJop(AddJopDTO model)
        {
            var res = await unitOfWork.JopRepo.AddJop(model);

            return Ok(res);
        }
        [HttpPut("UpdateJop")]
        public async Task<IActionResult> UpdateJop(UpdateJopDTO model)
        {
            var res = await unitOfWork.JopRepo.UpdateJopAsync(model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpDelete("DeleteJop")]
        public async Task<IActionResult> DeleteJop(int Id)
        {
            var res = await unitOfWork.JopRepo.DeleteJop(Id);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpPost("ApplyForJop")]
        public async Task<IActionResult> Apply_for_job([FromForm] ApplyForJopDTO model, CancellationToken canToken)
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var res = await unitOfWork.JopRepo.ApplyForJopAsync(UserId, model, canToken);

            return res.IsSuccess ? Ok(res) : res.ToProblem() ;
        }
        [HttpGet("JopApplications")]
        public async Task<IActionResult> GetJopApplications()
        {
            var res = await unitOfWork.JopRepo.GetJopApplicationsAsync();

            return Ok(res);
        }
        [HttpDelete("RejectJopApplication/{Id}")]
        public async Task<IActionResult> RejectJopApplication(int Id)
        {
            var res = await unitOfWork.JopRepo.RejectJopApplicationAsync(Id);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpPost("AcceptJopApplication")]
        public async Task<IActionResult> AcceptJopApplication(AcceptJopApplicationDTO model)
        {
            var res = await unitOfWork.JopRepo.AcceptJopApplicationAsync(model.JopApplicationId);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpGet("GetJopApplications")]
        public async Task<IActionResult> GetJopUserApplications()
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var res = await unitOfWork.JopRepo.GetUserJopApplications(UserId!);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpDelete("DeleteJopApplication/{Id}")]
        public async Task<IActionResult> DeleteJopApplication(int Id , CancellationToken canToken)
        {
            var res = await unitOfWork.JopRepo.DeleteJopApplicaiton(Id , canToken);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
    }
}
