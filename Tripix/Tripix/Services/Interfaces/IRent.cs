using Tripix.Abstractions;
using Tripix.Contracts.CarRental;
using Tripix.Entities;
using Tripix.View_Models;

namespace Tripix.Services.Interfaces
{
    public interface IRent
    {
        public Task<List<CarsForrRent>> GetAvilableCars ();
        public  Task<Result<List<CarRent>>> GetCarsRented(string UserId);
        public Task<Result<CarForRentResponse>> Rentcar ( string UserId, RentCarDTO model );
        public Task<Result> CancellCarforRent ( string UserId, CancellCarForRent model );
        public Task<Result<CarForRentResponse>> AddCar ( AddCarForRent model );
        public Task<Result<CarForRentResponse>> UpdateCarForRent ( UpdateCarForRentDTO model );
        public Task<Result> DeleteCarForRent ( int Id );
        public Task<Result> DelelteRent(int Id);
        public Task<Result<CarsForrRent>> GetCarForRent ( int Id );

    }
}
