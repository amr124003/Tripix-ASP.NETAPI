namespace Tripix.Entities
{
    public class Jop
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string AdvertismentTime { get; set; } = DateTime.UtcNow.ToString();
        public string Description { get; set; }
        public List<JopApplications> JopApplications { get; set; } = new();

    }
}
