using System.ComponentModel.DataAnnotations;
using Tripix.Entities;

namespace Tripix.View_Models
{
    public class AddmotorbikesDTO
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int? Rate { get; set; }
        public string Description { get; set; }
        public List<VehicleImage> Image { get; set; }
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        public string Prand { get; set; }
        public string Motor_Capacity { get; set; }

        [AllowedValues("Used", "New")]
        public string Condition { get; set; }

        [AllowedValues("Standard", "Cruiser", "Sport", "Off_road")]
        public string MotorbikeType { get; set; }
    }
}
