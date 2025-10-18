using System.ComponentModel.DataAnnotations;
using Tripix.Abstractions.Consts;

namespace Tripix.View_Models
{
    public class AddWashDTO
    {
        public string? UserName { get; set; }
        public string? UserPhone { get; set; }
        public DateTime TurnDate { get; set; }
        public CarFuelTypes CarType { get; set; }
        public PricingPlan PricingPlan { get; set; }
    }
}
