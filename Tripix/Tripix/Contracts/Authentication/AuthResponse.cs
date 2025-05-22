using System.Text.Json.Serialization;

namespace Tripix.Contracts.Authentication
{
    public class AuthResponse ()
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string? Email { get; set; }
        public string Token { get; set; }
        public List<string> Roles { get; set; }
        public int ExpiredIn { get; set; }
        [JsonIgnore]
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiredIn { get; set; }
    }
}
