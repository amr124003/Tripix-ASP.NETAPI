using Tripix.Abstractions;
using Tripix.Contracts.Car;
using Tripix.Contracts.Common;
using Tripix.Entities;

namespace Tripix.Services.Interfaces
{
    public interface ICarRepo
    {
        public Task<Result<Car>> GetCar ( int id , CancellationToken canToken = default);
        public Task<Result<PaginatedList<CarResponse>>> GetUsedVehicles(string UserId, RequestFilter filters, CancellationToken canToken = default);
        public Task<Result<PaginatedList<CarResponse>>> GetCars (string UserId , RequestFilter filters, CancellationToken CanToken = default );
        public Task<Result<CarResponse>> AddCar ( CarDTO model , CancellationToken canToken = default);
        public Task<Result<CarResponse>> UpdateCar ( UpdateCar model , CancellationToken canToken = default );
        public Task<Result> DeleteCar ( int id  , CancellationToken canToken = default);
        public Task<List<BrandDto>> GetBrands (CancellationToken canToken = default);
        public Task<Result> SellCar( SellCarDto model , CancellationToken canToken = default);
    }
}
