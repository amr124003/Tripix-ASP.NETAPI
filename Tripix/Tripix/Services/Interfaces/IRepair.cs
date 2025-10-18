using Tripix.Abstractions;
using Tripix.Contracts.CarRepair;
using Tripix.Contracts.Common;
using Tripix.Entities;

namespace Tripix.Services.Interfaces
{
    public interface IRepair
    {
        public Task<Result<CarRepairResponse>> BookingTurn ( string UserId , BookingTurnDTO model );
        public Task<Result<CarRepairResponse>> UpdateTurn ( UpdateTurnDTO model );
        public Task<Result> DeleteTurn ( int Id );
        public Task<Result<List<RepairBookings>>> GetTurns(string UserId);
        public Task<PaginatedList<RepairBookings>> GetRepairBookings (RequestFilter model , CancellationToken canToken = default);
        public Task<Result> CancelTurn (string UserId , int Id );
    }
}
