namespace Tripix.Contracts.Trip
{
    public class confirmDriverDTO
    {
        public int? TripId { get; set; }
        public string PhoneNumber { get; set; }
        public string DriverId { get; set; }
        public double PickupLatitude { get; set; }
        public double PickupLongitude { get; set; }
        public double? DestinationLatitude { get; set; }
        public double? DestinationLongitude { get; set; }
        public double DriverLatitude { get; set; }
        public double DriverLongitude { get; set; }
        public double Price { get; set; }
        public DateTime TripDate { get; set; } = DateTime.Now;
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
    }
}
