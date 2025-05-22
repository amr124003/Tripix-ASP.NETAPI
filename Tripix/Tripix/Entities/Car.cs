using System.ComponentModel.DataAnnotations;
using Tripix.Abstractions.Consts;

namespace Tripix.Entities
{
    public class Car : Vehicle
    {
        [AllowedValues("Manual", "Automatic")]
        public GearboxTypes? Gearbox_Type { get; set; }
        public int? Rate { get; set; }

        [AllowedValues("SUV", "Hatchback", "Coupe", "Sedan" )]
        public CarTypes? CarType { get; set; }
        public decimal? Discount { get; set; }
        public string? Merchant_Name { get; set; } = "Tripix";
        public string? Merchant_Phone { get; set; } = "01020652199";
        public DateOnly? CreatedAt { get; set; }
        public string Merchant_Logo { get; set; } = "/Images/TripixLogo.png";
        public string Motor_Capacity { get; set; }
    }
}
