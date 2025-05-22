namespace Tripix.Entities
{
    public class SpareParts
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public List<VehicleImage> Image { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
    }
}
