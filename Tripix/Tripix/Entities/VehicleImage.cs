namespace Tripix.Entities
{
    public class VehicleImage
    {
        public int Id { get; set; }
        public int? VehicleId { get; set; }
        public int? DriverId { get; set; }
        public Vehicle? Vehicle { get; set; }
        public Driver? Driver { get; set; }
        public string ImageUrl { get; set; }

    }
}
