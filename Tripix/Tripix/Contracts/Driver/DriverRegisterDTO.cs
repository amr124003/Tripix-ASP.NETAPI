using System.ComponentModel.DataAnnotations;

namespace Tripix.Contracts.Driver
{
    public class DriverRegisterDTO
    {
        public string? UserName { get; set; }
        public string? PhoneNumber { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string? Password { get; set; }

        [Compare(nameof(Password))]
        public string? ConfirmPassword { get; set; }
        public IFormFile? Image { get; set; }
        public IFormFile? FaceID { get; set; }
        public IFormFile? DriverLicense { get; set; }
        public List<IFormFile>? CarLicenseImages { get; set; }
        public List<IFormFile>? CarImages { get; set; }
        public IFormFile? CriminalRecord { get; set; }

    }
}
