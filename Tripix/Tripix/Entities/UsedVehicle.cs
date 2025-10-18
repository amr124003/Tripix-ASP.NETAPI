using System.ComponentModel.DataAnnotations;
using Tripix.Abstractions.Consts;

namespace Tripix.Entities
{
    public class UsedVehicle : Vehicle
    {
        [AllowedValues("Like New", "Very Good", "Good")]
        public string Condition { get; set; }
        public int KilometersDriven { get; set; }
        public GearboxTypes? Gearbox_Type { get; set; }

        [AllowedValues("Sedan", "Hatchback", "SUV", "Coupe")]
        public CarTypes? CarType { get; set; }
        public CarFuelTypes? FuelType { get; set; }
        public string? Motor_Capacity { get; set; }
        public CarLocation? CarLocation { get; set; }
        public string SellerName { get; set; } = "Tripix";
        public string SellerPhone { get; set; } = "01557373720";
        public string SellerEmail { get; set; } = "tripixv911@gmail.com";
    }
}
