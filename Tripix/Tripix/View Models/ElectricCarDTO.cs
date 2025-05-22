using System.ComponentModel.DataAnnotations;
using Tripix.Entities;

namespace Tripix.View_Models
{
    public class ElectricCarDTO
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int? Rate { get; set; }
        public string Description { get; set; }
        public List<IFormFile> Image { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public string Prand { get; set; }
        public string Motor_Capacity { get; set; }

        [AllowedValues("Used", "New")]
        public string Condition { get; set; }
        public int? BatteryCapacity { get; set; }
        public int? Range { get; set; }
        public int? ChargingTime { get; set; }
        public int? Power { get; set; }
        [AllowedValues("BEVs", "PHEVs", "HEVs")]
        public string? Type { get; set; }
    }
}
