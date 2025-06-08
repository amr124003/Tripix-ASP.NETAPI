using Microsoft.AspNetCore.Http;

namespace Tripix.Contracts.Driver
{
    public class UpdateDriverData
    {
        public IFormFile DriverImage { get; set; }
        public string Name { get; set; }
        public string PhoneNumber  { get; set; }
        public string Email { get; set; }
    }
}
