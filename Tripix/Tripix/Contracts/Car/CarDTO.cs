using System.ComponentModel.DataAnnotations;
using Tripix.Abstractions.Consts;

namespace Tripix.Contracts.Car
{
    public class CarDTO
    {
        [Required]
        [MaxLength(20), MinLength(5)]

        public string Name { get; set; }

        [Required]
        [AllowedValues("Manual", "Automatic")]
        public string Gearbox_Type { get; set; }

        [Required]
        [AllowedValues("SUV", "Hatchback", "Coupe", "Sedan")]
        public CarTypes CarType { get; set; }
        public decimal? Discount { get; set; }
        public string Merchant_Name { get; set; } = "Tripix";
        public string Merchant_Phone { get; set; } = "01020652199";

        public DateOnly CreatedAt = DateOnly.FromDateTime(DateTime.Now);

        [Range(1000, 10000, ErrorMessage = "Motor Capacity Must Be Between 1000 And 10000")]
        public string Motor_Capacity { get; set; }
        public string Year { get; set; }
        public string Model { get; set; }
        public string? Color { get; set; }
        public string Description { get; set; }
        public string Prand { get; set; }
        public decimal Price { get; set; }
        public List<IFormFile> CarImages { get; set; }
    }
}
