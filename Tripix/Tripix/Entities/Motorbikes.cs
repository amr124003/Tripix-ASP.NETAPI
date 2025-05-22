using System.ComponentModel.DataAnnotations;

namespace Tripix.Entities
{
    public class Motorbikes : Vehicle
    {
        [AllowedValues("Standard", "Cruiser", "Sport", "Off_road")]
        public string? MotorbikeType { get; set; }
        public int? Rate { get; set; }
        public string Motor_Capacity { get; set; }
        public decimal? Discount { get; set; }
    }
}
