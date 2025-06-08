using Microsoft.AspNetCore.Mvc;
using OpenQA.Selenium.DevTools.V132.DOM;
using Org.BouncyCastle.Crypto.Engines;
using Stripe;
using System.Security.Claims;
using System.Threading.Tasks;
using Tripix.Abstractions;
using Tripix.Contracts.Common;
using Tripix.Contracts.Tips;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public TipsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpPost("GetTips")]
        public async Task<IActionResult> GetTips(RequestFilter model , CancellationToken canToken)
        {
            var res = await unitOfWork.TipRepo.GetTips(model, canToken);

            return Ok(res);
        }
        [HttpGet("GetTip/{Id}")]
        public async Task<IActionResult> GetTip (int Id , CancellationToken canToken)
        {
            var res = await unitOfWork.TipRepo.GetTip(Id, canToken);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpPost("AddTip")]
        public async Task<IActionResult> AddTip (AddTipDTO model , CancellationToken canToken)
        {
            var res = await unitOfWork.TipRepo.AddTip(model ,canToken);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpPut("UpdateTip")]
        public async Task<IActionResult> UpdateTip(UpdateTipDTO model , CancellationToken canToken)
        {
            var res = await unitOfWork.TipRepo.UpdateTip(model , canToken);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpDelete("DeleteTip")]
        public async Task<IActionResult> DeleteTip (int Id)
        {
            var res = await unitOfWork.TipRepo.DeleteTip(Id);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpPost("LikeTip")]
        public async Task<IActionResult> LikeTip (int Id , CancellationToken canToken)
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitOfWork.TipRepo.LikeTip(UserId!, Id, canToken);

            return res.IsSuccess ? Ok(res) : res.ToProblem();

        }
        [HttpGet("DislikeTip")]
        public async Task<IActionResult> Dislike(int Id , CancellationToken canToken)
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitOfWork.TipRepo.DislikeTip(UserId!, Id , canToken);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        public async Task<IActionResult> CommentToTip(CommentDto model , CancellationToken canToken)
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitOfWork.TipRepo.CommentToTip(UserId!, model, canToken);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpPut("UpdateComment")]
        public async Task<IActionResult> Updatecomment(UpdateCommentDTO model , CancellationToken canToken)
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitOfWork.TipRepo.UpdateComment(UserId! , model , canToken);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpDelete("DeleteComment/{Id}")]
        public async Task<IActionResult> DeleteComment(int Id)
        {
            var res = await unitOfWork.TipRepo.DeleteComment(Id);

            return Ok(res);
        }
        [HttpDelete("DeleteUserComment/{Id}")]
        public async Task<IActionResult> DeleteUserComment(int Id , CancellationToken canToken)
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitOfWork.TipRepo.DeleteUserComment(UserId!, Id , canToken);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
    }
}
