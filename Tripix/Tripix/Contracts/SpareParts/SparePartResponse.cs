namespace Tripix.Contracts.SpareParts
{
    public class SparePartResponse
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<string> Images { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
    }
}
