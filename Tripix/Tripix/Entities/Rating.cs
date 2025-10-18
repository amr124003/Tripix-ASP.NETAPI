using Org.BouncyCastle.Bcpg;

namespace Tripix.Entities
{
    public class Rating
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int RateValue { get; set; }
    }
}
