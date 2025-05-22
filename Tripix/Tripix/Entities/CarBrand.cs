
namespace Tripix.Entities
{
    public class CarBrand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NameAR { get; set; }
        public List<CarModel> Models { get; set; }
        public bool Expand { get; set; } = false;
    }
}
