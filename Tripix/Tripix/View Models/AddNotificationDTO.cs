namespace Tripix.View_Models
{
    public class AddNotificationDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile image { get; set; }
    }
}
