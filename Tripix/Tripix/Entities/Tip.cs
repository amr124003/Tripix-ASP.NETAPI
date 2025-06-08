namespace Tripix.Entities
{
    public class Tip
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public List<LovedTips> LovedTips { get; set; } = new();
        public List<TipComments> TipComments { get; set; } = new();
        public int Likes { get; set; }
        public int DisLikes { get; set; }
    }
}
