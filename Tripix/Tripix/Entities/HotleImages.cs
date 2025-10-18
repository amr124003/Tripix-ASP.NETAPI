using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace Tripix.Entities
{
    public class HotleImages
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public string ImageUrl { get; set;  }
    }
}
