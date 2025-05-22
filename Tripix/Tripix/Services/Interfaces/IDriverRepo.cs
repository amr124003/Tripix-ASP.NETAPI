using Tripix.Abstractions;
using Tripix.Contracts.Driver;
using Tripix.Contracts.Trip;
using Tripix.Entities;
using Tripix.View_Models;

namespace Tripix.Services
{
    public interface IDriverRepo
    {
        public Task<bool> UpdateDriverLocationAsync ( string Token, DriverLocation model );
        public Task<List<Driver>> GetNearsetDriversAsync ( LocationDTO model, CancellationToken cancelToken = default );
        public Task<bool> MakeMeOnlineAsync ( string DriverId, string connectionId );
        public Task<bool> MakeMeOfflineAsync ( string DriverId );
        public Task<ConfirmTripResponse?> ConfirmTrip ( confirmTripDto model, string DriverId );
        public Task<bool> SetTripAsAvailable ( Trip newtrip, Driver driver );
        public Task<List<OrderTripDTO>> AvilableTrips ( string token );
        public  Task<Result> SendMessage ( DriverSendMSGDTO model );
        public Task<Result> DriverRegister ( DriverRegisterDTO model );
    }
}
