using Google.Apis.Auth;
using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using Tripix.Abstractions;
using Tripix.Authentication;
using Tripix.Context;
using Tripix.Contracts.Authentication;
using Tripix.Entities;
using Tripix.Errors;
using Tripix.Extentions;
using Tripix.Services.Interfaces;
using Tripix.View_Models;



namespace Tripix.Services.Repositories
{
    public class AuthService : IAuthService
    {
        private readonly UserManager<ApplicationUser> usermanger;
        private readonly SignInManager<ApplicationUser> signinmanger;
        private readonly ApplicationDbcontext context;
        private readonly IJwtProvider jwtprovider;
        private readonly IHttpContextAccessor httpcontext;
        private readonly IDistributedCache cache;

        public AuthService ( UserManager<ApplicationUser> usermanger, SignInManager<ApplicationUser> Signinmanger, ApplicationDbcontext context, IJwtProvider jwtprovider, IHttpContextAccessor Httpcontext, IDistributedCache Cache )
        {
            this.usermanger = usermanger;
            signinmanger = Signinmanger;
            this.context = context;
            this.jwtprovider = jwtprovider;
            httpcontext = Httpcontext;
            cache = Cache;
        }
        public async Task<Result<AuthResponse>> GetTokenAsync ( LoginModel model, CancellationToken cancellationtoken )
        {
            var Authresponse = new AuthResponse();
            var user = await usermanger.Users.Include(x => x.REFTokens).FirstAsync(x => x.Email == model.Email);

            if (user == null)
            {
                return Result.Failure<AuthResponse>(UserErrors.UserNotFound);
            }

            if (!await usermanger.CheckPasswordAsync(user, model.Password))
            {
                return Result.Failure<AuthResponse>(UserErrors.InvalidCredentials);
            }

            if (!user.EmailConfirmed)
            {
                return Result.Failure<AuthResponse>(UserErrors.UnconfirmedEmail);
            }

            if (user.IsDisabled)
            {
                return Result.Failure<AuthResponse>(UserErrors.DisabledUser);
            }

            var res = await signinmanger.PasswordSignInAsync(user, model.Password, model.RememberMe, true);

            if (res.Succeeded)
            {
                var userRoles = await usermanger.GetRolesAsync(user);

                var userpermissions = await context.Roles
                    .Join(context.RoleClaims, role => role.Id, claim => claim.RoleId,
                    ( role, claim ) => new { role, claim })
                    .Where(x => userRoles.Contains(x.role.Name!))
                    .Select(x => x.claim.ClaimValue!)
                    .Distinct()
                    .ToListAsync(cancellationtoken);

                var (token, expiresin) = jwtprovider.generateToken(user, userRoles, userpermissions);

                Authresponse.Name = user.Name;
                Authresponse.Email = user.Email;
                Authresponse.Token = token;
                Authresponse.Roles = userRoles.ToList();
                Authresponse.ExpiredIn = expiresin;


                if (user.REFTokens.Any(x => x.IsActive))
                {
                    var refreshtoken = user.REFTokens.FirstOrDefault(x => x.IsActive);
                    Authresponse.RefreshToken = refreshtoken.RefreshToken;
                    Authresponse.RefreshTokenExpiredIn = refreshtoken.ExpiredDate;
                }
                else
                {
                    var RefreshToken = GenerateRefreshToken();
                    Authresponse.RefreshToken = RefreshToken.RefreshToken;
                    Authresponse.RefreshTokenExpiredIn = RefreshToken.ExpiredDate;



                    user.REFTokens.Add(RefreshToken);

                    await usermanger.UpdateAsync(user);
                }
                return Result.Success(Authresponse);
            }

            return Result.Failure<AuthResponse>(res.IsNotAllowed ? UserErrors.DisabledUser : UserErrors.InvalidCredentials);
        }
        public async Task<Result<AuthResponse>?> GetRefreshtoken (string RefToken ,  string Token, CancellationToken cencellationtoken )
        {
            var UserId = jwtprovider.ValidateToken(Token);
            var AuthResponse = new AuthResponse();

            var user = await usermanger.FindByIdAsync(UserId);

            if (user == null)
            {
                return Result.Failure<AuthResponse>(UserErrors.UserNotFound);
            }

            var refreshtoken = user.REFTokens.FirstOrDefault(x => x.RefreshToken == RefToken);

            if (!refreshtoken.IsActive)
            {
                return Result.Failure<AuthResponse>(UserErrors.InActiveRefreshToken);
            }

            var userRoles = await usermanger.GetRolesAsync(user);

            var userpermissions = await context.Roles.
                Join(context.RoleClaims, role => role.Id, claim => claim.RoleId,
                ( role, claim ) => new { role, claim })
                .Where(x => userRoles.Contains(x.role.Name!))
                .Select(x => x.claim.ClaimValue)
                .Distinct()
                .ToListAsync(cencellationtoken);

            var (token, expiresin) = jwtprovider.generateToken(user, userRoles, userpermissions!);

            var newRefreshtoken = GenerateRefreshToken();
            var refreshTokenExpiration = DateTime.UtcNow.AddDays(15);



            user.REFTokens.Add(new RefreshTokens
            {
                RefreshToken = newRefreshtoken.RefreshToken,
                ExpiredDate = refreshTokenExpiration,
            });

            await usermanger.UpdateAsync(user);
            AuthResponse.Name = user.Name;
            AuthResponse.Email = user.Email;
            AuthResponse.Token = token;
            AuthResponse.ExpiredIn = expiresin;
            AuthResponse.RefreshToken = newRefreshtoken.RefreshToken;
            AuthResponse.RefreshTokenExpiredIn = refreshTokenExpiration;

            return Result.Success(AuthResponse);
        }

        public async Task<Result> RegisterAsync ( RegisterModel model, CancellationToken token = default )
        {
            var foundeduser = await usermanger.FindByEmailAsync(model.Email);

            if (foundeduser != null) { return Result.Failure(UserErrors.DuplicatedEmail); }
            if (usermanger.Users.Any(x => x.PhoneNumber == model.Phone)) { return Result.Failure(UserErrors.DuplicatedPhone); }
            var user = model.Adapt<ApplicationUser>();
            user.Name = user.UserName.GetNameFromUserName();
            user.EmailConfirmed = false;

            var result = await usermanger.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await usermanger.AddToRoleAsync(user, "User");
                var fromEmail = Environment.GetEnvironmentVariable("superAdminEmail");
                var fromPassword = Environment.GetEnvironmentVariable("SMTPPassword");

                Console.WriteLine($"FromEmail: {fromEmail}");
                Console.WriteLine($"FromPassword: {fromPassword}");


                if (!model.Email.IsValidEmail())
                {
                    return Result.Failure(UserErrors.InvalidOTP);
                }

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(fromEmail, fromPassword),
                    EnableSsl = true,
                };

                string subject = "🔐 Your Tripix OTP Code";

                var otp = GenerateOtp();




                string templatepath = Path.Combine(Directory.GetCurrentDirectory(), "Templates", "OTP_Email.html");
                string template = System.IO.File.ReadAllText(templatepath);
                string body = template.Replace("{{otp}}", otp);


                var mailMessage = new MailMessage
                {
                    From = new MailAddress(fromEmail, "Tripix Support"),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true,
                };

                mailMessage.ReplyToList.Add(new MailAddress(fromEmail));
                mailMessage.Headers.Add("X-Priority", "1");
                mailMessage.Headers.Add("X-MSMail-Priority", "High");
                mailMessage.Headers.Add("Importance", "High");
                mailMessage.To.Add(model.Email);
                await smtpClient.SendMailAsync(mailMessage);

                var otpObject = new OTPObject
                {
                    OTP = otp
                };
                var CacheOptions = new DistributedCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(DateTime.Now.AddDays(1).Subtract(DateTime.Now).TotalSeconds),
                    SlidingExpiration = null
                };

                var jsonData = JsonConvert.SerializeObject(otpObject);
                await cache.SetStringAsync($"OTP{user.Name}", jsonData, CacheOptions);
                return Result.Success();
            }
            var error = result.Errors.FirstOrDefault();

            return Result.Failure(new Error(error.Code, error.Description, StatusCodes.Status400BadRequest));
        }



        public async Task<bool> RevokeRefreshTokenAsync ( string refreshToken, CancellationToken cancellationToken = default )
        {
            var user = usermanger.Users.FirstOrDefault(x => x.REFTokens.Any(x => x.RefreshToken == refreshToken));

            if (user == null) { return false; }

            var RefreshToken = user.REFTokens.SingleOrDefault(x => x.RefreshToken == refreshToken);

            RefreshToken.RevokeTime = DateTime.UtcNow;
            await usermanger.UpdateAsync(user);

            return true;

        }

        public async Task<Result<AuthResponse>> ConfirmEmailAsync ( ConfirmationEmailRequest request )
        {
            var Authrepsponse = new AuthResponse();
            var user = await usermanger.FindByEmailAsync(request.Email);

            if (user == null) { return Result.Failure<AuthResponse>(UserErrors.UserNotFound); }

            if (user.EmailConfirmed)
            {
                return Result.Failure<AuthResponse>(UserErrors.Alreadyconfirmed);
            }

            var OTP = request.OTP;

            var SavedOTP = await cache.GetStringAsync($"OTP{user.Name}");

            var RedisOTP = "";

            if (SavedOTP != null)
            {
                var otpobj = JsonConvert.DeserializeObject<OTPObject>(SavedOTP);
                RedisOTP = otpobj.OTP;

            }

            if (OTP != RedisOTP)
            {
                return Result.Failure<AuthResponse>(UserErrors.InvalidOTP);
            }

            user.EmailConfirmed = true;

            await usermanger.UpdateAsync(user);
            await cache.RemoveAsync($"OTP{user.Name}");

            var UserRoles = await usermanger.GetRolesAsync(user);

            var UserPermissions = await context.Roles
                .Join(context.RoleClaims, role => role.Id, claim => claim.RoleId,
                ( role, claim ) => new { role, claim })
                .Where(x => UserRoles.Contains(x.role.Name!))
                 .Select(x => x.claim.ClaimValue)
                 .Distinct()
                 .ToListAsync();

            var (token, Expiresin) = jwtprovider.generateToken(user, UserRoles, UserPermissions!);
            var Refreshtoken = GenerateRefreshToken();
            var RefreshtokenExpiration = DateTime.UtcNow.AddDays(15);

            user.REFTokens.Add(Refreshtoken);
            await usermanger.UpdateAsync(user);

            Authrepsponse.Token = token;
            Authrepsponse.ExpiredIn = Expiresin;
            Authrepsponse.RefreshToken = Refreshtoken.RefreshToken;
            Authrepsponse.RefreshTokenExpiredIn = RefreshtokenExpiration;
            Authrepsponse.Roles = UserRoles.ToList();
            Authrepsponse.Name = user.Name;
            Authrepsponse.Email = user.Email;


            return Result.Success(Authrepsponse);
        }

        public async Task<Result> ResendConfirmEmailAsync ( ResendConfirmationEmailRequest request )
        {
            var user = await usermanger.FindByEmailAsync(request.Email);
            var fromEmail = Environment.GetEnvironmentVariable("superAdminEmail");
            var fromPassword = Environment.GetEnvironmentVariable("SMTPPassword");

            Console.WriteLine($"FromEmail: {fromEmail}");
            Console.WriteLine($"FromPassword: {fromPassword}");


            if (request.Email.IsValidEmail())
            {
                return Result.Failure(UserErrors.InvalidOTP);
            }

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromEmail, fromPassword),
                EnableSsl = true,
            };

            string subject = "🔐 Your Tripix OTP Code";

            var otp = GenerateOtp();




            string templatepath = Path.Combine(Directory.GetCurrentDirectory(), "Templates", "OTP_Email.html");
            string template = System.IO.File.ReadAllText(templatepath);
            string body = template.Replace("{{otp}}", otp);


            var mailMessage = new MailMessage
            {
                From = new MailAddress(fromEmail, "Tripix Support"),
                Subject = subject,
                Body = body,
                IsBodyHtml = true,
            };

            mailMessage.ReplyToList.Add(new MailAddress(fromEmail));
            mailMessage.Headers.Add("X-Priority", "1");
            mailMessage.Headers.Add("X-MSMail-Priority", "High");
            mailMessage.Headers.Add("Importance", "High");
            mailMessage.To.Add(request.Email);
            await smtpClient.SendMailAsync(mailMessage);

            var otpObject = new OTPObject
            {
                OTP = otp
            };
            var CacheOptions = new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(DateTime.Now.AddDays(1).Subtract(DateTime.Now).TotalSeconds),
                SlidingExpiration = null
            };

            var jsonData = JsonConvert.SerializeObject(otpObject);
            await cache.SetStringAsync($"OTP{user.Name}", jsonData, CacheOptions);
            return Result.Success();
        }

        public async Task<Result> SendResetPasswordCodeAsync ( SendResetPasswordRequest request )
        {
            var user = await usermanger.FindByEmailAsync(request.Email);
            var fromEmail = Environment.GetEnvironmentVariable("superAdminEmail");
            var fromPassword = Environment.GetEnvironmentVariable("SMTPPassword");

            Console.WriteLine($"FromEmail: {fromEmail}");
            Console.WriteLine($"FromPassword: {fromPassword}");


            if (request.Email.IsValidEmail())
            {
                return Result.Failure(UserErrors.InvalidOTP);
            }

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromEmail, fromPassword),
                EnableSsl = true,
            };

            string subject = "🔐 Your Tripix OTP Code";

            var otp = GenerateOtp();




            string templatepath = Path.Combine(Directory.GetCurrentDirectory(), "Templates", "OTP_Email.html");
            string template = System.IO.File.ReadAllText(templatepath);
            string body = template.Replace("{{otp}}", otp);


            var mailMessage = new MailMessage
            {
                From = new MailAddress(fromEmail, "Tripix Support"),
                Subject = subject,
                Body = body,
                IsBodyHtml = true,
            };

            mailMessage.ReplyToList.Add(new MailAddress(fromEmail));
            mailMessage.Headers.Add("X-Priority", "1");
            mailMessage.Headers.Add("X-MSMail-Priority", "High");
            mailMessage.Headers.Add("Importance", "High");
            mailMessage.To.Add(request.Email);
            await smtpClient.SendMailAsync(mailMessage);

            var otpObject = new OTPObject
            {
                OTP = otp
            };
            var CacheOptions = new DistributedCacheEntryOptions
            {
                AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(DateTime.Now.AddDays(1).Subtract(DateTime.Now).TotalSeconds),
                SlidingExpiration = null
            };

            var jsonData = JsonConvert.SerializeObject(otpObject);
            await cache.SetStringAsync($"ResetPasswordOTP{user.Name}", jsonData, CacheOptions);
            return Result.Success();
        }

        public async Task<Result> ResetPassowrdAsync ( ResetPasswordRequest request )
        {
            var user = await usermanger.FindByEmailAsync(request.Email);
            if (user == null) { return Result.Failure(UserErrors.UserNotFound); }
            if (user.IsDisabled) { return Result.Failure(UserErrors.DisabledUser); }
            if (!user.EmailConfirmed) { return Result.Failure(UserErrors.UnconfirmedEmail); }

            var OTP = request.OTP;

            var SavedOTP = await cache.GetStringAsync($"ResetPasswordOTP{user.Name}");

            var RedisOTP = "";

            if (SavedOTP != null)
            {
                var otpobj = JsonConvert.DeserializeObject<OTPObject>(SavedOTP);
                RedisOTP = otpobj.OTP;

            }

            if (OTP != RedisOTP)
            {
                return Result.Failure(UserErrors.InvalidOTP);
            }

            user.PasswordHash = usermanger.PasswordHasher.HashPassword(user, request.NewPassword);
            await usermanger.UpdateAsync(user);

            await cache.RemoveAsync($"ResetPasswordOTP{user.Name}");

            return Result.Success();
        }



        public async Task<Result<AuthResponse>> GoogleLogin ( GoogleAuthDTO model, CancellationToken cancellationToken = default )
        {
            var authresponse = new AuthResponse();
            var clientId = Environment.GetEnvironmentVariable("GoogleClientId");

            if (string.IsNullOrEmpty(clientId))
            {
                return Result.Failure<AuthResponse>(UserErrors.InvalidGoogleToken);
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
                return Result.Failure<AuthResponse>(UserErrors.InvalidGoogleToken);
            }

            var user = await usermanger.FindByEmailAsync(payload.Email);

            if (user == null)
            {
                ApplicationUser newUser = new()
                {
                    Email = payload.Email,
                    UserName = payload.Email.GetUserNameFromEmail(),
                };

                newUser.Name = newUser.UserName.GetNameFromUserName();

                var result = await usermanger.CreateAsync(newUser);

                if (!result.Succeeded)
                {
                    return Result.Failure<AuthResponse>(UserErrors.FailedToCreateUser);
                }

                user = await usermanger.FindByEmailAsync(payload.Email);
                await usermanger.AddToRoleAsync(user, "User");
            }

            var userRoles = await usermanger.GetRolesAsync(user);

            var userpermissions = await context.Roles
                .Join(context.RoleClaims, role => role.Id, claim => claim.RoleId,
                ( role, claim ) => new { role, claim })
                .Where(x => userRoles.Contains(x.role.Name!))
                .Select(x => x.claim.ClaimValue)
                .Distinct()
                .ToListAsync(cancellationToken);

            var (token, ExpiresIn) = jwtprovider.generateToken(user, userRoles, userpermissions);

            var RefreshToken = GenerateRefreshToken();

            authresponse.Token = token;
            authresponse.ExpiredIn = ExpiresIn;
            authresponse.RefreshToken = RefreshToken.RefreshToken;
            authresponse.RefreshTokenExpiredIn = DateTime.UtcNow.AddDays(15);
            authresponse.Roles = userRoles.ToList();
            authresponse.Name = user.Name;
            authresponse.Email = user.Email;

            return Result.Success(authresponse);
        }
        private RefreshTokens GenerateRefreshToken ()
        {
            return new RefreshTokens
            {
                RefreshToken = Convert.ToBase64String(RandomNumberGenerator.GetBytes(64)),
                ExpiredDate = DateTime.UtcNow.AddDays(15),
                CreatedDate = DateTime.UtcNow,
            };

        }



        private string GenerateOtp ( int length = 4 )
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
