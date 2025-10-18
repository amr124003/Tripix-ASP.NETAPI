using Tripix.Abstractions.Consts;

namespace Tripix.Entities
{
    public class WashBooking
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public DateTime TurnDate { get; set; } = DateTime.Now;
        public string UserPhone { get; set; }
        public CarFuelTypes CarType { get; set; }
        public PricingPlan PricingPlan { get; set; }
    }
}
