using Tripix.Abstractions.Consts;

namespace Tripix.Entities
{
    public class Trip
    {
        public int Id { get; set; }
        public string? UserId { get; set; }
        public ApplicationUser? User { get; set; }
        public Location PickupLocation { get; set; }
        public Location DestinationLocation { get; set; }
        public DateTime TripDate { get; set; } = DateTime.UtcNow;
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string Phonenumber { get; set; }
        public TripStatus Status { get; set; }
        public double Price { get; set; }
    }
}
