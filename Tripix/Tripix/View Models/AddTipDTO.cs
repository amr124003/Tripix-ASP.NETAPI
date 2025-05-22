namespace Tripix.View_Models
{
    public class AddTipDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public IFormFile Image { get; set; }
    }
}
