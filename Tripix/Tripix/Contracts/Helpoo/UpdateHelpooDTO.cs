namespace Tripix.Contracts.Helpoo
{
    public class UpdateHelpooDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPhone { get; set; }
        public string UserEmail { get; set; }
        public double UserLatitude { get; set; }
        public double UserLongitude { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}
