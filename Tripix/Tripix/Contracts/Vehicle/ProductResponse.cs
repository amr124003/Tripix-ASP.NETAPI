namespace Tripix.Contracts.Vehicle
{
    public class ProductResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Rate { get; set; }
        public List<string> ProductImages { get; set; }
        public decimal Price { get; set; }
    }
}
