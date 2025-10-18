using Tripix.Abstractions.Consts;

namespace Tripix.Contracts.ElectricCar
{
    public class ElectricCarsResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public string Model { get; set; }
        public string? Color { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsLiked { get; set; }
        public string Prand { get; set; }
        public CarTypes? CarType { get; set; }
        public int? Rate { get; set; }
        public decimal? Discount { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Merchant_Logo { get; set; } = "/Images/TripixLogo.png";
        public List<string> ImagesUrls { get; set; }

        public bookingCategory VehicleCategory = bookingCategory.ElectricCar;
    }
}
