using Tripix.Abstractions;
using Tripix.Contracts.Car;
using Tripix.Contracts.Common;
using Tripix.Contracts.ElectricCar;
using Tripix.View_Models;

namespace Tripix.Services.Interfaces
{
    public interface IElectricCar
    {
        public Task<PaginatedList<ElectricCarsResponse>> GetAll ( RequestFilter model, CancellationToken canToken = default );
        public Task<Result<ElectricCarsResponse>> GetById ( int Id );
        public Task<Result<ElectricCarsResponse>> AddCar ( AddElectricCatDTO model );
        public Task<Result<ElectricCarsResponse>> UpdateCar ( UpdateElectricCarDto model );
        public Task<Result> DeleteCar ( int Id );
        public Task<List<BrandDto>> GetBrands (); 
    }
}
