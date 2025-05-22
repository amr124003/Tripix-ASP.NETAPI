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
        public Task<Result<CarRepairResponse>> GetTurn ( int Id );
        public Task<List<RepairBookings>> GetRepairBookings ();
    }
}
