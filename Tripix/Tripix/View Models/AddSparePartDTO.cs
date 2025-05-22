using Tripix.Entities;

namespace Tripix.View_Models
{
    public class AddSparePartDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<IFormFile> Image { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
    }
}
