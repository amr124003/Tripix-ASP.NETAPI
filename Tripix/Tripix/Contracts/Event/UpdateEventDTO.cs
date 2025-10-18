using Tripix.Abstractions.Consts;

namespace Tripix.Contracts.Event
{
    public class UpdateEventDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public IFormFile Image { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public double EventLatitude { get; set; }
        public double EventLongitude { get; set; }
        public Governates Governate { get; set; }
    }
}
