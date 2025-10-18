using System.ComponentModel.DataAnnotations;
using Tripix.Abstractions.Consts;

namespace Tripix.Contracts.ElectricCar
{
    public class UpdateElectricCarDto
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string CarYear { get; set; }
        public string CarModel { get; set; }
        public string CarDescription { get; set; }
        public decimal CarPrice { get; set; }
        public string CarPrand { get; set; }
        public int? Rate { get; set; }
        public decimal? Discount { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.UtcNow;
        public string Merchant_Logo { get; set; } = "/Images/TripixLogo.png";
        public List<IFormFile> CarImages { get; set; }
        public int? BatteryCapacity { get; set; }
        public int? TravelRange { get; set; }
        public string? Interior { get; set; }
        public int? ChargingTime { get; set; }
        public int? CarPower { get; set; }
        public CarTypes? CarType { get; set; }
    }
}
