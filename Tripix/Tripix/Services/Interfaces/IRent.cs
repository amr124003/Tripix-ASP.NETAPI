using Tripix.Abstractions;
using Tripix.Contracts.CarRental;
using Tripix.Entities;

namespace Tripix.Services.Interfaces
{
    public interface IRent
    {
        public List<CarsForrRent> GetAvilableCars ();
        public  Task<Result<CarRent>> GetCarRented ( string UserId, int CarId );
        public Task<Result<CarForRentResponse>> Rentcar ( string UserId, RentCarDTO model );
        public Task<Result> CancellCarforRent ( string UserId, int Id );
        public Task<Result<CarForRentResponse>> AddCar ( AddCarforRent model );
        public Task<Result<CarForRentResponse>> UpdateCarForRent ( UpdateCarForRentDTO model );
        public Task<Result> DeleteCarForRent ( int Id );
        public Task<Result<CarsForrRent>> GetCarForRent ( int Id );

    }
}
