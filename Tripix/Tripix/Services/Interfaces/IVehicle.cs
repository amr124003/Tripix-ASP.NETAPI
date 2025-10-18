using Tripix.Abstractions;
using Tripix.Contracts.Vehicle;
using Tripix.Entities;

namespace Tripix.Services.Interfaces
{
    public interface IVehicle
    {
        public Task<Result<VehicleResponse>> BookVehicle (string UserId , int CarId);
        public Task<Result> LikeVehicle ( string UserId, int CarId);
        public Task<List<VehicleBookings>> GetVehcileBookings (string Category);
        public Task<Result> DisLikeVehicle ( string UserId, int CarId);
        public Task<Result> DeleteBooking (int BookingId);
        

    }
}
