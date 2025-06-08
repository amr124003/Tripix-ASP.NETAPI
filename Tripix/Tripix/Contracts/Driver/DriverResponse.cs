namespace Tripix.Contracts.Driver
{
    public class DriverResponse
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email  { get; set; }
        public string PhoneNumber { get; set; }
        public string DriverImage { get; set; }
        public string CarModel { get; set; }
        public string CarName { get; set; }
        public string DriverFaceId { get; set; }
        public string DriverLicense {  get; set; }
        public List<string> CarLicense { get; set; }
        public List<string> CarImages { get; set; }
        public string DriverStatus { get; set; }
        public int Tripcounter { get; set; }
    }
}
