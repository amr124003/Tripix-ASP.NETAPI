using StackExchange.Redis;

namespace Tripix.Entities
{
    public class PassengerOpinion
    {
        public int Id { get; set; }
        public string Opinion { get; set; }
        public string UserId {  get; set; }
        public ApplicationUser User { get; set; }
        
    }
}
