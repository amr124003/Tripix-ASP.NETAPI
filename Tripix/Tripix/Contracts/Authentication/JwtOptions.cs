using System.ComponentModel.DataAnnotations;

namespace Tripix.Contracts.Authentication
{
    public class JwtOptions
    {
        [Required]
        public string SecretKey { get; init; } = string.Empty;
        [Required]
        public string Issure {  get; init; } = string.Empty;
        [Required]
        public string Audienece {  get; init; } = string.Empty;
        [Range(1,60)]
        public int ExpireMinutes { get; init; }
    }
}
