using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Tripix.Abstractions;
using Tripix.Authentication;
using Tripix.Contracts.Trip;
using Tripix.Contracts.User;
using Tripix.Services.Interfaces;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IUserRepo userRepo;

        public AccountController (IUserRepo userRepo)
        {
            this.userRepo = userRepo;
        }
        [HttpPost("Send-MSG")]
        public async Task<IActionResult> SendMSG ( UserSendMSGDTO model )
        {
            var res = await userRepo.SendMessage(model);

            return res.IsSuccess ? Ok (res) : res.ToProblem();
        }
        [HttpPost("Get-Trip-Details")]
        public async Task<IActionResult> GetTripDetails (GetTripDetails model)
        {
            var Res = await userRepo.GetTripDetails(model);

            return Res.IsSuccess ? Ok(Res.Value) : Res.ToProblem(); 
        }
    }
}
