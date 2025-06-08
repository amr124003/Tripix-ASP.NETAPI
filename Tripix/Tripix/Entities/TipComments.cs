namespace Tripix.Entities
{
    public class TipComments
    {
        public int Id { get; set; }
        public int TipId { get; set; }
        public Tip Tip { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string Text { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int? ParentCommentId { get; set; }
        public TipComments? ParentComment { get; set; }
        public List<TipComments> Replies { get; set; } = new();
    }
}
