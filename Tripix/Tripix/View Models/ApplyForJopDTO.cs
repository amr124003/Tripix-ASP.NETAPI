namespace Tripix.View_Models
{
    public class ApplyForJopDTO
    {
        public int JopId { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public IFormFile CV { get; set; }
    }
}
