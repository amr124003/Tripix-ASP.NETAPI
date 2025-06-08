namespace Tripix.Entities
{
    public class CarRent
    {
        public int Id { get; set; }
        public int CarID { get; set; }
        public ApplicationUser User { get; set; }
        public string UserId { get; set; }
        public CarsForrRent Car { get; set; }
        public string CarName { get; set; }
        public decimal RentPrice  { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string TenantName { get; set; }
        public string TenantEmail { get; set; }
        public string TenantPhone { get; set; }
    }
}
