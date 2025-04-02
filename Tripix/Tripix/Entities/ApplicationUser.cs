using Microsoft.AspNetCore.Identity;

namespace Tripix.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public List<RefreshTokens> REFTokens { get; set; }
    }
}
