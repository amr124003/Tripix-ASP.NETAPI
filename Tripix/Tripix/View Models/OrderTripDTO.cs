namespace Tripix.View_Models
{
    public class OrderTripDTO
    {
        public int? TripId { get; set; }
        public double PickupLatitude { get; set; }
        public double PickupLongitude { get; set; }
        public double DestinationLatitude { get; set; }
        public double DestinationLongitude { get; set; }
        public DateTime TripDate { get; set; }
        public string? FirstName { get; set; } = string.Empty;
        public string? LastName { get; set; } = string.Empty;
        public string? PhoneNumber { get; set; } = string.Empty;
    }
}
