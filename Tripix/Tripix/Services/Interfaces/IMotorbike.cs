using Tripix.Abstractions;
using Tripix.Contracts.Car;
using Tripix.Contracts.Common;
using Tripix.Contracts.Motorbikes;
using Tripix.Entities;

namespace Tripix.Services.Interfaces
{
    public interface IMotorbike
    {
        public Task<Result<Motorbikes>> GetById ( int Id );
        public Task<PaginatedList<Motorbikeresponse>> GetAll ( RequestFilter filters, CancellationToken cenToken = default );
        public Task<Result<Motorbikeresponse>> AddMotorbike ( AddMotorbikeDTO model );
        public Task<Result<Motorbikeresponse>> UpdateMotorbike ( UpdateMotorbikeDTO model );
        public Task<Result> DeleteMotorbike ( int id );
        public Task<List<BrandDto>> GetBrands ();
    }
}
