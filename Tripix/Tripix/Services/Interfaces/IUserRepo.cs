using Tripix.Abstractions;
using Tripix.Contracts.Trip;
using Tripix.Contracts.User;

namespace Tripix.Services.Interfaces
{
    public interface IUserRepo
    {
        public Task<bool> MakeUserOnline ( string UserId, string ConnectionId );
        public Task<bool> MakeUserOffline ( string UserId );
        public Task<string> GetUserPhoneNumber ( string UserId );
        public Task<bool> RemoveTrip ( string UserId );
        public Task<Result> SendMessage ( UserSendMSGDTO model );
        public Task<Result<UserFinalTrip>> GetTripDetails ( GetTripDetails model );
    }
}
