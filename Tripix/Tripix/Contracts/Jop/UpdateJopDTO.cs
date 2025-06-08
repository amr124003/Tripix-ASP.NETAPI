namespace Tripix.Contracts.Jop
{
    public class UpdateJopDTO
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string AdvertismentTime { get; set; } = DateTime.Now.ToString();
        public string Description { get; set; }
    }
}
