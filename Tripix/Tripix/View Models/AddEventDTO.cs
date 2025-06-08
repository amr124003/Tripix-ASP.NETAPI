namespace Tripix.View_Models
{
    public class AddEventDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public IFormFile Image { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
    }
}
