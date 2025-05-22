using Tripix.Entities;

namespace Tripix.Authentication
{
    public interface IJwtProvider
    {
        public (string token, int Expiresin) generateToken ( ApplicationUser user, IEnumerable<string> Roles, IEnumerable<string> permissions );
        public string? ValidateToken(string token);
    }
}
