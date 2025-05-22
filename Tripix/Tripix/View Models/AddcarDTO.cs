using System.ComponentModel.DataAnnotations;

namespace Tripix.View_Models
{
    public class AddcarDTO
    {
        [Required]
        [MinLength(5)]
        [MaxLength(20)]
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        [Range(2, 5)]
        public int? Rate { get; set; }
        [Required]
        [MinLength(10)]
        public string Description { get; set; }
        public List<IFormFile> Images { get; set; }
        [Required]
        public decimal Price { get; set; }
        public decimal? Discount { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string Prand { get; set; }
        [Required]
        [Range(1000, 3000)]
        public string Motor_Capacity { get; set; }
        [Required]
        [AllowedValues("Used", "New")]
        public string Condition { get; set; }
        [Required]
        [AllowedValues("Manual", "Automatic")]
        public string? Gearbox_Type { get; set; }
        [Required]
        [AllowedValues("SUV", "Hatchback", "Coupe", "Sedan")]
        public string? CarType { get; set; }
    }
}
