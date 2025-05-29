using System.ComponentModel.DataAnnotations;

namespace Tripix.Contracts.Motorbikes
{
    public class AddMotorbikeDTO
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public string Model { get; set; }
        public string? Color { get; set; }
        public string Description { get; set; }
        public List<IFormFile> VehicleImages { get; set; }
        public decimal Price { get; set; }
        public string Prand { get; set; }

        [AllowedValues("Used", "New")]
        public string Condition { get; set; }
        public string? MotorbikeType { get; set; }
        public int? Rate { get; set; }
        public string Motor_Capacity { get; set; }
        public decimal? Discount { get; set; }
    }
}
