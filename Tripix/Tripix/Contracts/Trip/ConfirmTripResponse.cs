namespace Tripix.Contracts.Trip
{
    public class ConfirmTripResponse
    {
        public int TripId { get; set; }
        public string DriverName { get; set; }
        public string DriverId { get; set; }
        public double Price { get; set; }
        public string CarName { get; set; }
        public string DriverPhoneNumber { get; set; }
        public string UserPhoneNumber { get; set; }
        public double UserLatitude { get; set; }
        public double UserLongitude { get; set; }
        public double DriverLatitude { get; set; }
        public double DriverLongitude { get; set; }
    }
}
