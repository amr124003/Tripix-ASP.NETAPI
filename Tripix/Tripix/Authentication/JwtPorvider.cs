using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Tripix.Contracts.Authentication;
using Tripix.Entities;

namespace Tripix.Authentication
{
    public class JwtProvider : IJwtProvider
    {
        private readonly IOptions<JwtOptions> options;

        public JwtProvider ( IOptions<JwtOptions> options )
        {
            this.options = options;
        }



        public (string token, int Expiresin) generateToken ( ApplicationUser user, IEnumerable<string> roles, IEnumerable<string> permissions )
        {
            Claim[] claims = [
                new (JwtRegisteredClaimNames.Sub,user.Id),
                new(JwtRegisteredClaimNames.Email , user.Email!),
                new (JwtRegisteredClaimNames.GivenName,user.Name ?? "User"),
                new (JwtRegisteredClaimNames.Jti , Guid.NewGuid().ToString()),
                new (nameof(roles) , string.Join(",", roles)),
                new (nameof(permissions),string.Join(",",permissions))
             ];

            var symetricSecKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(options.Value.SecretKey));

            var signingcredentials = new SigningCredentials(symetricSecKey, SecurityAlgorithms.HmacSha256);

            var ExpirationData = DateTime.UtcNow.AddMinutes(options.Value.ExpireMinutes);

            var token = new JwtSecurityToken(
                issuer: options.Value.Issure,
                audience: options.Value.Audienece,
                claims: claims,
                signingCredentials: signingcredentials,
                expires: ExpirationData
            );

            return (token: new JwtSecurityTokenHandler().WriteToken(token), Expiresin: options.Value.ExpireMinutes * 60);
        }

        public string? ValidateToken ( string token )
        {
            var tokenhandler = new JwtSecurityTokenHandler();
            var symetricseckey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(options.Value.SecretKey));

            try
            {
                tokenhandler.ValidateToken(token, new TokenValidationParameters
                {
                    IssuerSigningKey = symetricseckey,
                    ValidateIssuerSigningKey = true,
                    ValidateLifetime = false,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var JwtTokem = (JwtSecurityToken)validatedToken;
                return JwtTokem.Claims.First(x => x.Type == JwtRegisteredClaimNames.Sub).Value;
            }
            catch
            {
                return null;
            }

        }
    }
}
