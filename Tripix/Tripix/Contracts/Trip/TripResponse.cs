namespace Tripix.Contracts.Trip
{
    public class TripResponse
    {
        public string UserName { get; set; }
        public string UserId { get; set; }
        public int? TripId { get; set; }
        public string? DriverId { get; set; }
        public double? PickupLatitude { get; set; }
        public double? PickupLongitude { get; set; }
        public double? DestinationLatitude { get; set; }
        public double? DestinationLongitude { get; set; }
        public DateTime TripDate { get; set; } = DateTime.UtcNow;
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
        public decimal Price { get; set; }
    }
}
