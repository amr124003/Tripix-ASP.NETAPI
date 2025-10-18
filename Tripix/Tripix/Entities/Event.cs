using System.ComponentModel.DataAnnotations.Schema;

namespace Tripix.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; } 
        public string Location { get; set; }
        public Location EventLocation { get; set; }
        public List<Hotel> Hotels { get; set; } = new();
    }
}
