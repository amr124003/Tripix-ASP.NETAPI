namespace Tripix.View_Models
{
    public class OrderHelpooDTO
    {
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }
        public string? UserPhone { get; set; }
        public DateTime OrderTime { get; set; } = DateTime.Now;
        public double UserLongitude { get; set; }
        public double UserLatitude { get; set; }
    }
}
