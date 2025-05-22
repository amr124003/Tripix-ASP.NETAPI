using System.ComponentModel.DataAnnotations;

namespace Tripix.View_Models
{
    public class BlogDTO
    {
        [Required]
        [MinLength(5)]
        [MaxLength(15)]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public IFormFile Image { get; set; }
    }
}
