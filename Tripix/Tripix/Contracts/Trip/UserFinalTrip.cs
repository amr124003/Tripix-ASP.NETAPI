namespace Tripix.Contracts.Trip
{
    public class UserFinalTrip
    {
        public double PickupLatitude { get; set; }
        public double PickupLongitude { get; set; }
        public double DistinationLatitude { get; set; }
        public double DistinationLongitude { get; set; }
        public double DriverLatitude { get; set; }
        public double DriverLongitude { get; set; }
        public string DriverId { get; set; }
        public string DriverName { get; set; }
        public string DriverPhoneNumber { get; set; }
        public double Price { get; set; }
    }
}
