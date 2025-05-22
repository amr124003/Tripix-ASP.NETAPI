using System.ComponentModel.DataAnnotations;

namespace Tripix.View_Models
{
    public class FilterationModel
    {
        [AllowedValues("All" , "New" , "Used")]
        public string condittion {  get; set; }

        public string CarName { get; set; }

        public string BrandName { get; set; }

        public decimal StartPrice { get; set; }
        public decimal EndPrice { get; set; }

    }
}
