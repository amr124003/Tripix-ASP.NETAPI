namespace Tripix.Contracts.CarRental
{
    public class RentCarDTO
    {
        public int CarId { get; set; }
        public string? Name { get; set; }
        public string? Phone { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime EndDate { get; set; } = DateTime.Now.AddHours(5);
    }
}
