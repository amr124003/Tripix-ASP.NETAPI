namespace Tripix.Entities
{
    public class HelpooOrders
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public DateTime OrderTime { get; set; } = DateTime.UtcNow;
        public double UserLongitude { get; set; }
        public double UserLatitude { get; set; }
    }
}
