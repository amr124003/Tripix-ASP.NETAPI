using Tripix.Abstractions;
using Tripix.Contracts.Common;
using Tripix.Contracts.SpareParts;
using Tripix.Entities;
using Tripix.View_Models;

namespace Tripix.Services.Interfaces
{
    public interface ISparePart
    {
        public Task<PaginatedList<SparePartResponse>> GetAll (RequestFilter model , CancellationToken canToken = default);
        public Task<Result<SparePartResponse>> GetSparePart (int Id  , CancellationToken canToken = default);
        public Task<Result<SparePartResponse>> AddSparePart ( AddSparePartDTO model , CancellationToken canToken = default);
        public Task<Result<SparePartResponse>> UpdateSparePart ( UpdateSparePart model , CancellationToken canToken = default);
        public Task<Result> DeleteSparePart ( int Id  , CancellationToken canToken = default);
        public Task<Result<SparePartOrder>> OrderSparePart ( string UserId, SparePartOrderDTO model , CancellationToken canToken = default);
        public Task<PaginatedList<SparePartOrder>> GetOrders (RequestFilter model , CancellationToken canToken =default);
        public Task<Result<List<SparePartOrder>>> GetUserOrders ( string UserId , CancellationToken canToken = default);
        public Task<Result<SparePartOrder>> UpdateOrder(string UserId, UpdateSparePartOrder model , CancellationToken canToken = default);
        public Task<Result<SparePartOrder>> GetOrder ( string UserId, int OrderId, CancellationToken canToken = default);
        public Task<Result> CancelSparePartOrder ( string UserId, int OrderId , CancellationToken canToken = default);
        public Task<Result> DeleteOrder ( int OrderId  , CancellationToken canToken = default);


    }
}

