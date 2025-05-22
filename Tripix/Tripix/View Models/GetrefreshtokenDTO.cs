using System.ComponentModel.DataAnnotations;

namespace Tripix.View_Models
{
    public class GetrefreshtokenDTO
    {
        [Required]
        public string Token { get; set; }
        [Required]
        public string RefreshToken { get; set; }
    }
}
