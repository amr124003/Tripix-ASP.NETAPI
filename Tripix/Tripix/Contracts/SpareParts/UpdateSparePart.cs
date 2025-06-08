namespace Tripix.Contracts.SpareParts
{
    public class UpdateSparePart
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<IFormFile> Images { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
    }
}
