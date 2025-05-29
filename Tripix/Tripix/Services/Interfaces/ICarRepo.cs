using Tripix.Abstractions;
using Tripix.Contracts.Car;
using Tripix.Contracts.Common;
using Tripix.Entities;

namespace Tripix.Services.Interfaces
{
    public interface ICarRepo
    {
        public Task<Result<Car>> GetCar ( int id );
        public Task<Result<PaginatedList<CarResponse>>> GetCars ( RequestFilter filters, CancellationToken CanToken = default );
        public Task<Result<CarResponse>> AddCar ( CarDTO model );
        public Task<Result<CarResponse>> UpdateCar ( int Id, CarDTO model );
        public Task<Result> DeleteCar ( int id );
        public Task<List<BrandDto>> GetBrands ();
    }
}
