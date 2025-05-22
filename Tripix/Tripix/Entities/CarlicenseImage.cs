namespace Tripix.Entities
{
    public class CarlicenseImage
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public string ImageUrl { get; set; }
        public Driver Driver { get; set; }
    }
}
