using Tripix.Abstractions.Consts;

namespace Tripix.Contracts.Admin
{
    public class GetAdminsResponse
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public UserStatus Status { get; set; }
    }
}
