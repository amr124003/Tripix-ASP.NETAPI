namespace Tripix.Contracts.Wash
{
    public class UpdateWashTurnDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public DateTime TurnDate { get; set; } = DateTime.Now;
        public string UserPhone { get; set; }
        public string CarType { get; set; }
        public string PricingPlan { get; set; }
    }
}
