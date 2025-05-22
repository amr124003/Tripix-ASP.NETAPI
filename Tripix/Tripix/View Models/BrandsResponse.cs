namespace Tripix.View_Models
{
    public class BrandsResponse
    {
        public string BrandName { get; set; }
        public List<string> Models { get; set; }
        public bool Expand { get; set; } = false;
    }
}
