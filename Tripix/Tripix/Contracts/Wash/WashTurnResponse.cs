namespace Tripix.Contracts.Wash
{
    public class WashTurnResponse
    {
        public int TurnId { get; set; }
        public string UserName { get; set; }
        public DateTime TurnDate { get; set; }
        public string UserPhoneNumber { get; set; }
        public string CarType { get; set; }
    }
}
