using Tripix.Abstractions.Consts;

namespace Tripix.Entities
{
    public class CarsForrRent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int? Rate { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal HourlyPrice { get; set; }
        public CarForRentStatus Status { get; set; } = CarForRentStatus.Avilable;   
    }
}
