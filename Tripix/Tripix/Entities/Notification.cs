using StackExchange.Redis;

namespace Tripix.Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string RedirectUrl { get; set; }
        public string UserRole { get; set; }

    }
}
