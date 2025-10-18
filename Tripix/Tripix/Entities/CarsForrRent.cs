using Tripix.Abstractions.Consts;

namespace Tripix.Entities
{
    public class CarsForrRent
    {
        public int Id { get; set; }
        public string  CarName { get; set; }
        public string CarModel { get; set; }
        public string CarColor { get; set; }
        public int? CarRate { get; set; }
        public string CarDescription { get; set; }
        public string CarImage { get; set; }
        public decimal HourlyPrice { get; set; }
        public CarForRentStatus Status { get; set; } = CarForRentStatus.Avilable;   
    }
}
