namespace Tripix.Contracts.Jop
{
    public class AddJopDTO
    {
        public string Position { get; set; }
        public string AdvertismentTime { get; set; } = DateTime.Now.ToString();
        public string Description { get; set; }
    }
}
