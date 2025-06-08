namespace Tripix.Contracts.Tips
{
    public class UpdateTipDTO
    {
        public int TipId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public IFormFile Image { get; set; }
    }
}
