using Org.BouncyCastle.Security;
using Tripix.Abstractions.Consts;

namespace Tripix.View_Models
{
    public class AddEventDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public IFormFile Image { get; set; }
        public DateTime Date { get; set; }
        public double EventLatitude { get; set; }
        public double EventLongitude { get; set; }
        public string Location { get; set; }
        public Governates Governate { get; set; }
    }
}
