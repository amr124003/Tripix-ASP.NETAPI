namespace Tripix.Entities
{
    public class Complains
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public string ComplainContent { get; set; }
    }
}
