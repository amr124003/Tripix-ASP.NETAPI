using System.ComponentModel.DataAnnotations;
using Tripix.Abstractions.Consts;

namespace Tripix.Entities
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Year { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string? Color { get; set; }
        public string Description { get; set; }
        public List<VehicleImage> VehicleImages { get; set; }
        public decimal Price { get; set; }
        public string Prand { get; set; }
        
        [AllowedValues("Used", "New")]
        public string Condition { get; set; }
        public VehicleBookings VehicleBooking { get; set; }
        public VehicleStatus Status { get; set; } = VehicleStatus.Avilable;
        public int LikeCounter { get; set; } = 0;
    }
}
