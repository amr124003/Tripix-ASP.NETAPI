#nullable disable
using Microsoft.AspNetCore.Mvc;
using Tripix.Abstractions;
using Tripix.Contracts.Authentication;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public AuthController ( IUnitOfWork unitOfWork )
        {

            this.unitOfWork = unitOfWork;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register ( [FromBody] RegisterModel model )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }

            var authresult = await unitOfWork.authService.RegisterAsync(model);

            return authresult.IsSuccess ? Ok(authresult) : authresult.ToProblem();

        }


        [HttpPost("Login")]
        public async Task<IActionResult> Login ( [FromBody] LoginModel model, CancellationToken cancellationToken )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }

            var authResult = await unitOfWork.authService.GetTokenAsync(model, cancellationToken);

            if (!authResult.IsSuccess)
            {
                return authResult.ToProblem();
            }
            var Authresponse = authResult.Value;

            if (Authresponse.RefreshToken != null)
            {
                if (Authresponse.Roles.Any(x => x == "Driver"))
                {
                    SetRefreshTokenCookieForDriver(Authresponse.RefreshToken);
                }
                else
                {
                    SetRefreshTokenCookieForUser(Authresponse.RefreshToken);
                }
            }

            return authResult.IsSuccess ? Ok(Authresponse) : authResult.ToProblem();
        }

        [HttpGet("RefreshToken")]
        
        public async Task<IActionResult> Refreshtoken ()
        {
            var authHeader = Request.Headers["Authorization"].FirstOrDefault();
            var token = "";

            if (authHeader != null && authHeader.StartsWith("Bearer "))
            {
                token = authHeader.Substring("Bearer ".Length).Trim();
                // ﬂœÂ „⁄«ﬂ «· token ›Ì «·„ €Ì— token
            }

            var refreshToken = Request.Cookies["refreshToken"];



            var authResult = await unitOfWork.authService.GetRefreshtoken(refreshToken , token);

            var AuthResponse = authResult.Value;

            if (authResult.IsSuccess)
            {
                if (AuthResponse.Roles.Any(x => x == "Driver"))
                {
                    SetRefreshTokenCookieForDriver(AuthResponse.RefreshToken);
                }
                else
                {
                    SetRefreshTokenCookieForUser(AuthResponse.RefreshToken);
                }
            }

            return authResult.IsSuccess ? Ok(AuthResponse) : authResult.ToProblem();
        }
        [HttpPost("Revoe-Refresh-Token")]
        public async Task<IActionResult> RevokeRefreshToken ( [FromBody] RevokeDTO model )
        {
            var Token = model.Token ?? Request.Cookies["refreshToken"];

            if (Token == null) { return BadRequest("Refresh Token Is Required"); }

            var authResult = await unitOfWork.authService.RevokeRefreshTokenAsync(model.Token);

            return authResult ? Ok() : BadRequest("Invalid Refresh Token");
        }

        [HttpPost("Confirm-Email")]
        public async Task<IActionResult> confirmEmail ( [FromBody] ConfirmationEmailRequest request )
        {
            var authResult = await unitOfWork.authService.ConfirmEmailAsync(request);

            var RefreshToken = authResult.Value.RefreshToken;

            SetRefreshTokenCookieForUser(RefreshToken);

            return authResult.IsSuccess ? Ok(authResult.Value) : authResult.ToProblem();
        }

        [HttpPost("Resend-ConfirmationOTP")]
        public async Task<IActionResult> ResendConfirmEmail ( [FromBody] ResendConfirmationEmailRequest model )
        {
            var authResult = await unitOfWork.authService.ResendConfirmEmailAsync(model);

            return authResult.IsSuccess ? Ok(authResult) : authResult.ToProblem();
        }
        [HttpPost("Forget-Password")]
        public async Task<IActionResult> ForgetPassword ( [FromBody] SendResetPasswordRequest model )
        {
            var authResult = await unitOfWork.authService.SendResetPasswordCodeAsync(model);

            return authResult.IsSuccess ? Ok(authResult) : authResult.ToProblem();
        }

        [HttpPost("Reset-Password")]
        public async Task<IActionResult> ResetPassword ( [FromBody] ResetPasswordRequest model )
        {
            var authResult = await unitOfWork.authService.ResetPassowrdAsync(model);

            return authResult.IsSuccess ? Ok(authResult) : authResult.ToProblem();
        }



        [HttpPost("GoogleLogin")]
        public async Task<IActionResult> GoogleLogin ( [FromBody] GoogleAuthDTO model )
        {
            var authResult = await unitOfWork.authService.GoogleLogin(model);

            var refreshtoken = authResult.Value.RefreshToken;

            SetRefreshTokenCookieForUser(refreshtoken);

            return authResult.IsSuccess ? Ok(authResult.Value) : authResult.ToProblem();
        }

        private void SetRefreshTokenCookieForUser ( string refreshToken )
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,     // „‰⁄ «·Ê’Ê· „‰ JavaScript
                Expires = DateTime.UtcNow.AddDays(15),
                SameSite = SameSiteMode.None,  // «·”„«Õ »≈—”«· «·ﬂÊﬂÌ“ ⁄»— «·œÊ„Ì‰«  «·„Œ ·›…
                Secure = false       // ·«  ” Œœ„ Secure Â‰« ·Ê ﬂ‰  ⁄·Ï HTTP
            };

            Response.Cookies.Append("refreshToken", refreshToken, cookieOptions);
        }

        private void SetRefreshTokenCookieForDriver ( string refreshToken )
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,     // „‰⁄ «·Ê’Ê· „‰ JavaScript
                Expires = DateTime.UtcNow.AddDays(15),
                SameSite = SameSiteMode.None,  // «·”„«Õ »≈—”«· «·ﬂÊﬂÌ“ ⁄»— «·œÊ„Ì‰«  «·„Œ ·›…
                Secure = false       // ·«  ” Œœ„ Secure Â‰« ·Ê ﬂ‰  ⁄·Ï HTTP
            };

            Response.Cookies.Append("Driver-Ref-Token", refreshToken, cookieOptions);
        }
    }
}
