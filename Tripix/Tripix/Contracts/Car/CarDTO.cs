using System.ComponentModel.DataAnnotations;
using Tripix.Abstractions.Consts;
using Tripix.Attributes;

namespace Tripix.Contracts.Car
{
    public class CarDTO
    {
        [Required]
        [MaxLength(20), MinLength(5)]
        public string CarName { get; set; }

        [Required]
        public GearboxTypes Gearbox_Type { get; set; }

        [Required]
        public CarTypes CarType { get; set; }
        public decimal? Discount { get; set; }
        public int Rate { get; set; }
        public string Merchant_Name { get; set; } = "Tripix";
        public string Merchant_Phone { get; set; } = "01020652199";

        public DateTime CreatedAt = DateTime.UtcNow;

        [ValidMotorCapacity]
        public string Motor_Capacity { get; set; }
        public string CarYear { get; set; }
        public string CarModel { get; set; }
        public string CarDescription { get; set; }
        public string CarPrand { get; set; }
        public decimal CarPrice { get; set; }
        public List<IFormFile> CarImages { get; set; }
    }
}
