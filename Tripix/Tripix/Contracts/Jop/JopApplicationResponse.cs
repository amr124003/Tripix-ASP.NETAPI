using Tripix.Abstractions.Consts;

namespace Tripix.Contracts.Jop
{
    public class JopApplicationResponse
    {
        public int Id { get; set; }
        public string Position { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public JopApplicationStatus Status { get; set; }
        public string CV { get; set; }
    }
}
