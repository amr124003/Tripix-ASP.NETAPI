namespace Tripix.Entities
{
    public class BookingEventTicket
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }

    }
}
