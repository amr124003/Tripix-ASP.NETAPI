namespace Tripix.Entities
{
    public class SparePartImage
    {
        public int Id { get; set; }
        public int SparePartId { get; set; }
        public SpareParts SpareParts { get; set; }
        public string ImageUrl { get; set; }
    }
}
