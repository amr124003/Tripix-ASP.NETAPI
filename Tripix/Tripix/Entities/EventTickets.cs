

namespace Tripix.Entities
{
    public class EventTickets
    {
        public int Id { get; set; }
        public Event Event { get; set; }
        public int EventId { get; set; }
        public DateTime EventDate { get; set; }
        public ApplicationUser User { get; set; }
        public int UserId { get; set; }
        public string UserPhone { get; set; }
        public string UserEmail { get; set; }
        public bool IsExpired  => DateTime.UtcNow > EventDate;
        public string UserName { get; set; }
        public string EventAddress { get; set; }
    }
}
