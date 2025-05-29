using Tripix.Abstractions;
using Tripix.Contracts.Wash;
using Tripix.Entities;
using Tripix.View_Models;

namespace Tripix.Services.Interfaces
{
    public interface IWash
    {
        public Task<Result> BookingTurn ( string UserId, AddWashDTO model );
        public Task<Result<WashBooking>> GetTurnDetails ( int TurnId, string UserId );
        public Task<Result<WashBooking>> UpdateTurn ( string UserId, UpdateWashTurnDTO model );
        public Task<Result> CancelTurn ( string UserId, int TurnId );
        public Task<List<WashBooking>> GetTurns ();
        public Task<Result> DeleteTurn ( int TurnId );

    }
}
