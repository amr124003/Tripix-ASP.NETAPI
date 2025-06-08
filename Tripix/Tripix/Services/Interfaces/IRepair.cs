using Tripix.Abstractions;
using Tripix.Contracts.CarRepair;
using Tripix.Entities;

namespace Tripix.Services.Interfaces
{
    public interface IRepair
    {
        public Task<Result<CarRepairResponse>> BookingTurn ( string UserId , BookingTurnDTO model );
        public Task<Result<CarRepairResponse>> UpdateTurn ( UpdateTurnDTO model );
        public Task<Result> DeleteTurn ( int Id );
        public Task<Result<CarRepairResponse>> GetTurn (string UserId ,  int Id );
        public Task<List<RepairBookings>> GetRepairBookings ();
        public Task<Result> CancelTurn (string UserId , int Id );
    }
}
