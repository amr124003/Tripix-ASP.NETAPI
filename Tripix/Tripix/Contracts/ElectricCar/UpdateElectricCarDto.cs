using System.ComponentModel.DataAnnotations;
using Tripix.Abstractions.Consts;

namespace Tripix.Contracts.ElectricCar
{
    public class UpdateElectricCarDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string Model { get; set; }
        public string? Color { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Prand { get; set; }
        public MotorbikeTypes? MotorbikeType { get; set; }
        public int? Rate { get; set; }
        public decimal? Discount { get; set; }
        public DateOnly? CreatedAt { get; set; }
        public string Merchant_Logo { get; set; } = "/Images/TripixLogo.png";
        public List<IFormFile> Images { get; set; }
        public int? BatteryCapacity { get; set; }
        public int? TravelRange { get; set; }

        public string? Interior { get; set; }
        public int? ChargingTime { get; set; }
        public int? Power { get; set; }
        [AllowedValues("SUV", "Hatchback", "Coupe", "Sedan")]
        public string? CarType { get; set; }
    }
}
