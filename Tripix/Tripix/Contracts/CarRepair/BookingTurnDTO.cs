namespace Tripix.Contracts.CarRepair
{
    public class BookingTurnDTO
    {
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string CarType { get; set; }
        public DateTime RepairTime { get; set; }
    }
}
