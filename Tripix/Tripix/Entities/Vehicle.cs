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
        public List<VehicleImage> VehicleImages { get; set; } = new();
        public decimal Price { get; set; }
        public string? Prand { get; set; }
        public List<VehicleBookings> VehicleBooking { get; set; } = new();

        [AllowedValues("Manual", "Automatic")]
        public GearboxTypes? Gearbox_Type { get; set; } = GearboxTypes.Automatic;
        public VehicleStatus Status { get; set; } = VehicleStatus.Avilable;
        public int LikeCounter { get; set; } = 0;
        public string? Merchant_Name { get; set; } = "Tripix";
        public string? Merchant_Phone { get; set; } = "01020652199";
        public DateTime CreatedAt { get; set; } 
        public string Merchant_Logo { get; set; } = "/Images/TripixLogo.png";
        public int? Rate { get; set; }
        public decimal? Discount { get; set; } = 0;
        public int Views { get; set; } = 0;
    }
}
