namespace Tripix.View_Models
{
    public class RegisterDriverDTO
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public IFormFile DriverFaceID { get; set; }
        public List<IFormFile> DriverLicense { get; set; }
        public string CriminalRecord { get; set; }
        public string DriverImage { get; set; }
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public List<IFormFile> CarImage { get; set; }
        public List<IFormFile> CarLicense { get; set; }
        public string CarType { get; set; }
        public string CarBrand { get; set; }
        public string CarDescription { get; set; }
    }
}
