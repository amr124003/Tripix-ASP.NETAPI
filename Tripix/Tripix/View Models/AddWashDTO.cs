using System.ComponentModel.DataAnnotations;

namespace Tripix.View_Models
{
    public class AddWashDTO
    {
        public string? UserName { get; set; }
        public string? UserPhone { get; set; }
        public DateTime TurnDate { get; set; }
        public string CarType { get; set; }
        public string PricingPlan { get; set; }
    }
}
