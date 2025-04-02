#nullable disable
using Google.Apis.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Tripix.Context;
using Tripix.Entities;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> userManager;

        private readonly SignInManager<ApplicationUser> signinmanger;
        private readonly RoleManager<IdentityRole> rolemanger;
        private readonly ApplicationDbcontext context;

        public AuthController ( UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signinmanger, RoleManager<IdentityRole> rolemanger, ApplicationDbcontext context )
        {
            this.userManager = userManager;
            this.signinmanger = signinmanger;
            this.rolemanger = rolemanger;
            this.context = context;
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register ( [FromBody] RegisterModel model )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }

            var user = new ApplicationUser { UserName = model.Username, Email = model.Email };
            var result = await userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                return BadRequest(result);
            }

            await userManager.AddToRoleAsync(user, "User");

            var token = GenerateJwtToken(user);

            var Refrechtoken = GenerateRefreshToken();

            user.REFTokens.Add(new RefreshTokens { CreatedDate = DateTime.UtcNow, ExpiredDate = DateTime.UtcNow.AddDays(15), RefreshToken = Refrechtoken });
            await userManager.UpdateAsync(user);

            SetRefreshTokenCookie(Refrechtoken);


            return Ok(new { token });
        }


        [HttpPost("Login")]
        public async Task<IActionResult> Login ( [FromBody] LoginModel model )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }
            var user = await userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                return Unauthorized(new { message = "Email Not Found You Need To Register" });
            }

            var result = await signinmanger.CheckPasswordSignInAsync(user, model.Password, false);
            if (!result.Succeeded)
            {
                return Unauthorized(new { message = "Invalid Email Or Password" });
            }

            var role = userManager.GetRolesAsync(user).Result.FirstOrDefault();

            var token = GenerateJwtToken(user);
            var Refrechtoken = GenerateRefreshToken();

            user.REFTokens.Add(new RefreshTokens { CreatedDate = DateTime.UtcNow, ExpiredDate = DateTime.UtcNow.AddDays(15), RefreshToken = Refrechtoken });
            await userManager.UpdateAsync(user);

            SetRefreshTokenCookie(Refrechtoken);

            return Ok(new { Token = token, Role = role });
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpPost("AssignRole")]
        public async Task<IActionResult> AsignRole ( [FromBody] AssignRoleModel model )
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }
            var user = await userManager.FindByEmailAsync(model.Email);

            if (user == null)
            {
                return NotFound("User Not Found");
            }

            if (!await rolemanger.RoleExistsAsync(model.Role))
            {
                return BadRequest("Invalid Role");
            }

            await userManager.AddToRoleAsync(user, model.Role);
            return Ok(new { message = $"Role {model.Role} Assigned To {user.UserName}" });
        }

        [Authorize(Roles = "SuperAdmin")]
        [HttpPost("AddAdmin")]
        public async Task<IActionResult> AddAdmin ( [FromBody] AddAdminModel model )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(model);
            }

            var admin = new ApplicationUser { Email = model.Email, UserName = model.Username };
            var result = await userManager.CreateAsync(admin, model.Password);

            if (!result.Succeeded)
            {
                return BadRequest(result);
            }

            await userManager.AddToRoleAsync(admin, "Admin");
            return Ok(new { message = "Admin Is Created" });
        }

        [HttpGet("GetAdmins")]
        [Authorize(Roles = "Admin,SuperAdmin")]
        public async Task<IActionResult> GetAdmins ()
        {
            var result = userManager.GetUsersInRoleAsync("Admin");
            return Ok(result);
        }

        [HttpPost("GoogleLogin")]
        public async Task<IActionResult> GoogleLogin ( [FromBody] GoogleAuthDTO model )
        {
            var clientId = Environment.GetEnvironmentVariable("GoogleClientId");

            if (string.IsNullOrEmpty(clientId))
            {
                return StatusCode(500, new { message = "Google Client ID is not set" });
            }

            var settings = new GoogleJsonWebSignature.ValidationSettings();


            GoogleJsonWebSignature.Payload payload;

            try
            {
                payload = await GoogleJsonWebSignature.ValidateAsync(model.TokenID, settings);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Token Validation Error: {ex.Message}");
                return Unauthorized(new { message = "Invalid Token" });
            }

            var user = await userManager.FindByEmailAsync(payload.Email);

            if (user == null)
            {
                ApplicationUser newUser = new()
                {
                    Email = payload.Email,
                    UserName = payload.Email
                };

                var result = await userManager.CreateAsync(newUser);

                if (!result.Succeeded)
                {
                    return BadRequest(new { message = "Failed to create user" });
                }

                user = await userManager.FindByEmailAsync(payload.Email); // تأكيد استرجاع المستخدم
            }

            var token = GenerateJwtToken(user);

            return Ok(new { token });
        }

        [HttpGet]
        public async Task<IActionResult> Refreshtoken ()
        {
            var refreshToken = Request.Cookies["refreshToken"];
            if (string.IsNullOrEmpty(refreshToken))
            {
                return Unauthorized(new { message = "Refresh Token Not Found" });
            }
            var user = userManager.Users.FirstOrDefault(u => u.REFTokens.Any(t => t.RefreshToken == refreshToken));
            if (user == null)
            {
                return Unauthorized(new { message = "Invalid Refresh Token" });
            }
            var token = GenerateJwtToken(user);
            var Refrechtoken = GenerateRefreshToken();
            user.REFTokens.Add(new RefreshTokens { CreatedDate = DateTime.UtcNow, ExpiredDate = DateTime.UtcNow.AddDays(15), RefreshToken = Refrechtoken });
            await userManager.UpdateAsync(user);
            SetRefreshTokenCookie(Refrechtoken);
            return Ok(new { token });
        }

        private string GenerateJwtToken ( ApplicationUser user )
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("JWTSecret")));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var roles = userManager.GetRolesAsync(user).Result;

            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Sub, user.Email),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()) ,
            new Claim(ClaimTypes.Name, user.UserName),
            }.ToList();

            var exp = DateTime.UtcNow.AddHours(1);

            claims.AddRange(roles.Select(role => new Claim(ClaimTypes.Role, role)));

            var token = new JwtSecurityToken(
                claims: claims,
                expires: exp,
                signingCredentials: creds
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private string GenerateRefreshToken ()
        {
            return Convert.ToBase64String(RandomNumberGenerator.GetBytes(64));
        }

        // دالة لتخزين Refresh Token في كوكي
        private void SetRefreshTokenCookie ( string refreshToken )
        {
            var cookieOptions = new CookieOptions
            {
                HttpOnly = true,   // منع الوصول من JavaScript
                Secure = true,     // إرسال الكوكي فقط عبر HTTPS
                SameSite = SameSiteMode.Strict,
                Expires = DateTime.UtcNow.AddDays(15)
            };
            Response.Cookies.Append("refreshToken", refreshToken, cookieOptions);
        }
    }
}
