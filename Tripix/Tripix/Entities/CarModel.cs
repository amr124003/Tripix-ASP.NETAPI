namespace Tripix.Entities
{
    public class CarModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameAR { get; set; }
        public int BrandId { get; set; }
        public CarBrand Brand { get; set; }
    }
}
