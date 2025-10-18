using Tripix.Abstractions;
using Tripix.Contracts.Driver;
using Tripix.Contracts.Trip;
using Tripix.Entities;
using Tripix.View_Models;

namespace Tripix.Services.Interfaces
{
    public interface IDriverRepo
    {
        public Task<bool> UpdateDriverLocationAsync ( string Token, DriverLocation model );
        public Task<List<Driver>> GetNearsetDriversAsync ( LocationDTO model, CancellationToken cancelToken = default );
        public Task<bool> MakeMeOnlineAsync ( string DriverId, string connectionId );
        public Task<bool> MakeMeOfflineAsync ( string DriverId );
        public Task<ConfirmTripResponse?> ConfirmTrip ( confirmTripDto model, string DriverId );
        public Task<bool> SetTripAsAvailable ( Trip newtrip, Driver driver );
        public Task<List<OrderTripDTO>> AvilableTrips ( string UserId );
        public Task<Result> SendMessage ( DriverSendMSGDTO model );
        public Task<Result> DriverRegister (string? DriverId , DriverRegisterDTO model );
        public Task<Result> UpdateDriverData (string DriverId ,  UpdateDriverData model );
        public Task<Result<DriverResponse>> GetDriverData(string DriverId );
        public Task<Result> RejectTrip(string DriverId , int TripIId);
        public Task<List<DriverResponse>> GetDrivers();
        public Task<Result> AcceptDriver ( string DriverId );
        public Task<Result> RejectDriver ( string DriverId );
        public Task<List<DriverResponse>> GetDriverApplication(CancellationToken canToken = default);
    }
}
