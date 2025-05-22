namespace Tripix.Entities
{
    public class Comments
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string Comment { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
    }
}
