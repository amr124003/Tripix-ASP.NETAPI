namespace Tripix.Contracts.CarRental
{
    public class UpdateCarForRentDTO
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public string CarColor { get; set; }
        public int? CarRate { get; set; }
        public string CarDescription { get; set; }
        public IFormFile Image { get; set; }
        public decimal HourlyPrice { get; set; }
    }
}
