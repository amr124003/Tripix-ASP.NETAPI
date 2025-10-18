using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Tripix.Entities
{
    public class TipComments
    {
        public int Id { get; set; }
        public int TipId { get; set; }
        [JsonIgnore]
        public Tip Tip { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public string UserName { get; set; }
        [JsonIgnore]
        public ApplicationUser User { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public List<Replies> Replies { get; set; } = new();
    }
}
