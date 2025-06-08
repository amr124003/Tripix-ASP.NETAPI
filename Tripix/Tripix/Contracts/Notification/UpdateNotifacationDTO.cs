namespace Tripix.Contracts.Notification
{
    public class UpdateNotifacationDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IFormFile image { get; set; }
        public string RedirectUrl { get; set; }
    }
}
