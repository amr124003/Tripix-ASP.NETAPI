using Tripix.Abstractions.Consts;

namespace Tripix.Entities
{
    public class JopApplications
    {
        public int Id { get; set; }
        public ApplicationUser User { get; set; }
        public int UserId { get; set; }
        public Jop Jop { get; set; }
        public int JopId { get; set; }
        public string Position { get; set; }    
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public JopApplicationStatus Status { get; set; } = JopApplicationStatus.Pending;
        public string CV { get; set; }
    }
}
