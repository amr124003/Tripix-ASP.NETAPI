namespace Tripix.Contracts.Car
{
    public class BrandDto
    {
        public string BrandName { get; set; }
        
        public List<string> Models { get; set; }

        public bool Expanded { get; set; }
        
    }
}
