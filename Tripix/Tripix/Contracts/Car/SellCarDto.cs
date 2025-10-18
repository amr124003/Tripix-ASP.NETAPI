using OpenQA.Selenium.DevTools.V132.Network;
using OpenQA.Selenium.Interactions;
using Tripix.Abstractions.Consts;

namespace Tripix.Contracts.Car
{
    public class SellCarDto
    {
        public List<IFormFile> CarImages { get; set; }
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public string Year { get; set; }
        public int KilometersDriven { get; set; }
        public decimal Price { get; set; }
        public string Condition { get; set; }
        public GearboxTypes GearboxTypes { get; set; }
        public CarTypes CarTypes { get; set; }
        public string CarDescription { get; set; }
        public string? Motor_Capacity { get; set; }
        public CarFuelTypes CarFuelTypes { get; set; }
        public string SellerName { get; set; }
        public string SellerPhone { get; set; }
        public string SellerEmail { get; set; }
        public double Location_Latitude { get; set; }
        public double Location_Longitude { get; set; }
    }
}
