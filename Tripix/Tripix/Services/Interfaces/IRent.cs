using Tripix.Abstractions;
using Tripix.Contracts.CarRental;
using Tripix.Entities;

namespace Tripix.Services.Interfaces
{
    public interface IRent
    {
        public Task<List<CarsForrRent>> GetAvilableCars ();
        public Task<Result<CarRent>> GetCarRented ( string UserId );
        public Task<Result<CarForRentResponse>> Rentcar ( string UserId, RentCarDTO model );
        public Task<Result> CancellCarforRent ( int Id );
        public Task<Result<CarForRentResponse>> AddCar ( AddCarforRent model );
        public Task<Result<CarForRentResponse>> UpdateCarForRent ( UpdateCarForRentDTO model );
        public Task<Result> DeleteCarForRent ( int Id );
        public Task<Result<CarsForrRent>> GetCarForRent ( int Id );

    }
}
