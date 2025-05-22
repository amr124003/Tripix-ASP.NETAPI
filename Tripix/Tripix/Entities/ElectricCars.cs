using System.ComponentModel.DataAnnotations;
using Tripix.Abstractions.Consts;

namespace Tripix.Entities
{
    public class ElectricCars : Vehicle
    {
        public int? BatteryCapacity { get; set; }
        public GearboxTypes? Gearbox_Type { get; set; }
        public int? TravelRange { get; set; }
        public int? Rate { get; set; }
        public string? Interior { get; set; }
        public int? ChargingTime { get; set; }
        public int? Power { get; set; }
        [AllowedValues("SUV", "Hatchback", "Coupe", "Sedan")]
        public CarTypes? CarType { get; set; }
        public decimal? Discount { get; set; }
    }
}
