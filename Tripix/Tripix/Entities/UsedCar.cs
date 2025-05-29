using System.ComponentModel.DataAnnotations;
using Tripix.Abstractions.Consts;

namespace Tripix.Entities
{
    public class UsedCar : Vehicle
    {
        [AllowedValues("Like New", "Very Good", "Good")]
        public string Condition { get; set; }
        public int KilometersDriven { get; set; }
        public GearboxTypes? Gearbox_Type { get; set; }

        [AllowedValues("Sedan", "Hatchback", "SUV", "Coupe")]
        public CarTypes? CarType { get; set; }
        public string? FuelType { get; set; }
        public string? Motor_Capacity { get; set; }
        public CarLocation? CarLocation { get; set; }
    }
}
