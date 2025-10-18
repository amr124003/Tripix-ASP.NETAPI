using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using Tripix.Abstractions;
using Tripix.Authentication;
using Tripix.Contracts.OpinionComplains;
using Tripix.Contracts.Trip;
using Tripix.Contracts.User;
using Tripix.Services.Interfaces;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IUnitOfWork unitOfwork;

        public AccountController(IUnitOfWork unitOfwork)
        {

            this.unitOfwork = unitOfwork;
        }
        [HttpPost("Send-MSG")]
        public async Task<IActionResult> SendMSG(UserSendMSGDTO model)
        {
            var res = await unitOfwork.userService.SendMessage(model);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpPost("Get-Trip-Details")]
        public async Task<IActionResult> GetTripDetails(GetTripDetails model)
        {
            var Res = await unitOfwork.userService.GetTripDetails(model);

            return Res.IsSuccess ? Ok(Res.Value) : Res.ToProblem();
        }
        [HttpPost("CommentToTip")]
        public IActionResult CommentToTip()
        {
            var userid = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            return Ok();
        }

    }
}
