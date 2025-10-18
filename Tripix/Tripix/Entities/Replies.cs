using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Tripix.Entities
{
    public class Replies
    {
        public int Id { get; set; }
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }
        public string UserName { get; set; }
        [JsonIgnore]
        public ApplicationUser User { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int? ParentCommentId { get; set; }
        [JsonIgnore]
        public TipComments? ParentComment { get; set; }
    }
}
