using Tripix.Abstractions;
using Tripix.Contracts.Common;
using Tripix.Contracts.Wash;
using Tripix.Entities;
using Tripix.View_Models;

namespace Tripix.Services.Interfaces
{
    public interface IWash
    {
        public Task<Result> BookingTurn ( string UserId, AddWashDTO model  ,CancellationToken canToken = default);
        public Task<Result<WashBooking>> GetTurnDetails ( int TurnId, string UserId, CancellationToken canToken = default);
        public Task<Result<WashBooking>> UpdateTurn ( string UserId, UpdateWashTurnDTO model, CancellationToken canToken = default);
        public Task<Result> CancelTurn ( string UserId, int TurnId, CancellationToken canToken = default);
        public Task<PaginatedList<WashBooking>> GetTurns (RequestFilter model , CancellationToken canToken = default);
        public Task<Result> DeleteTurn ( int TurnId, CancellationToken canToken = default);
        public Task<Result<List<WashBooking>>> GetUserTurn(string UserId, CancellationToken canToken);

    }
}
