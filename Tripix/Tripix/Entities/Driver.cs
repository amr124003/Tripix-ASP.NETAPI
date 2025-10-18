using Tripix.Abstractions.Consts;

namespace Tripix.Entities
{
    public class Driver : ApplicationUser
    {
        public string? DriverFaceID { get; set; }
        public string? DriverLicense { get; set; }
        public string? CriminalRecord { get; set; }
        public string? DriverImage { get; set; }
        public string? CarName { get; set; }
        public string? CarModel { get; set; }
        public List<VehicleImage> CarImage { get; set; } = new();
        public List<CarlicenseImage> CarLicense { get; set; } = new();
        public string? CarType { get; set; }
        public string? CarBrand { get; set; }
        public DateTime EnrollDate { get; set; } = DateTime.UtcNow;
        public string? ConnectionId { get; set; }
        public string? CarDescription { get; set; }
        public bool IsConfirmed { get; set; } = true;
        public DriverStatus? Status { get; set; }
        public DriverLocation Location { get; set; } = new(0, 0);
        public int CompleltedSteps { get; set; } = 0;
        public List<Rating> RatesRecieved { get; set; } = new();
        public List<PassengerOpinion> passengerOpinions { get; set; } = new();
        public int CancellationCount { get; set; } = 0;
        public int RejectAfterAccept {  get; set; } = 0;
        public int AcceptCount { get; set; } = 0;
        public List<Complains> Complains { get; set; } = new();
    }
}
