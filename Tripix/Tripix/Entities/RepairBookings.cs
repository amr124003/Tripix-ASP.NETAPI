using OpenQA.Selenium.DevTools.V132.DOM;
using Tripix.Abstractions.Consts;

namespace Tripix.Entities
{
    public class RepairBookings
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime RepairDate { get; set; } = DateTime.UtcNow;
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public CarFuelTypes CarType { get; set; }
        public PricingPlan PricingPlan { get; set; }
    }
}
