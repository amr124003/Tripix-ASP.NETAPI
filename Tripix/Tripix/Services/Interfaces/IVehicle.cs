using Tripix.Abstractions;
using Tripix.Contracts.Vehicle;
using Tripix.Entities;

namespace Tripix.Services.Interfaces
{
    public interface IVehicle
    {
        public Task<Result<VehicleResponse>> BookVehicle (string UserId , int CarId);
        public Task<Result> LikeVehicle ( string UserId, int CarId);
        public Task<Result> CancelBooking (string UserId, int BookingId);
        public Task<Result> DeleteBooking (int BookingId);
        

    }
}
