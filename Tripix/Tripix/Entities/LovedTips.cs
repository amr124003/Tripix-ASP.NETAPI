using OpenQA.Selenium.DevTools.V132.DOM;

namespace Tripix.Entities
{
    public class LovedTips
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int TipId { get; set; }
        public Tip Tip { get; set; }
        public DateTime LovedAt { get; set; } = DateTime.UtcNow;
    }
}
