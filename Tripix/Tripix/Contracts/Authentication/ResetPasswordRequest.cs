using System.ComponentModel.DataAnnotations;

namespace Tripix.Contracts.Authentication
{
    public class ResetPasswordRequest
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [MinLength(4)]
        public string OTP { get; set; }
        [Required(ErrorMessage = "Password Is Required")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long.")]
        [MaxLength(25, ErrorMessage = "Password must not exceed 25 characters.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]+$",
            ErrorMessage = "Password must contain at least one uppercase letter, one lowercase letter, one number, and one special character.")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Confirm Password Is Required")]
        [Compare("NewPassword", ErrorMessage = "Passwords do not match")]
        [DataType(DataType.Password)]
        public string ConfirmNewPassword { get; set; }
    }
}
