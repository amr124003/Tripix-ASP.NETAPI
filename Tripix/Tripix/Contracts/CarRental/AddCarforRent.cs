using System.ComponentModel.DataAnnotations;

namespace Tripix.Contracts.CarRental
{
    public class AddCarForRent
    {

        [MinLength(5)]
        [MaxLength(20)]
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public string CarColor { get; set; }
        public int? CarRate { get; set; }
        public string CarDescription { get; set; }
        public decimal HourlyPrice { get; set; }
        public IFormFile Image { get; set; }
    }
}
