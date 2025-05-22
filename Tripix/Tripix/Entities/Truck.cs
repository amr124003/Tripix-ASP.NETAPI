using System.ComponentModel.DataAnnotations;

namespace Tripix.Entities
{
    public class Truck : Vehicle
    {
        [AllowedValues("Small", "Large")]
        public string? TruckType { get; set; }
        public int? Rate { get; set; }
        public decimal? LoadCapacity { get; set; }
        public string Motor_Capacity { get; set; }
        public decimal? Discount { get; set; }
    }
}
