using Tripix.Abstractions.Consts;

namespace Tripix.Contracts.CarRental
{
    public class AddCarforRent
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int? Rate { get; set; }
        public string Description { get; set; }
        public IFormFile Image { get; set; }
        public decimal HourlyPrice { get; set; }
    }
}
