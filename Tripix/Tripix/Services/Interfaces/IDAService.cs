using Stripe;
using Tripix.Abstractions;
using Tripix.Contracts.Car;
using Tripix.Contracts.Common;
using Tripix.Contracts.DA;
using Tripix.Contracts.Vehicle;
using Tripix.Entities;

namespace Tripix.Services.Interfaces
{
    public interface IDAService
    {
        public Task<List<DAResponse>> GetTrendingProducts ();
        public Task<List<DAResponse>> GetTopRatedProduct ();
        public Task<List<DAResponse>> GetBestSellerProducts ();
        public Task<List<DAResponse>> GetNewArrivalsProduct ();
        public Task<List<DAResponse>> GetNewArrivalFromProduct(string ProductName);
        public Task<List<DAResponse>> GetTrendingFromProduct(string ProductName);
        public Task<List<DAResponse>> GetTopRatedFromProduct(string ProductName);
        public Task<List<DAResponse>> GetBestSellerFromProducts(string ProductName);
       
        public Task<PaginatedList<ProductResponse>> GetProducts(RequestFilter model , CancellationToken canToken = default);
        public Task<Result<List<FavouriteProduct>>> GetWashlet(string UserId , CancellationToken canToken = default);
        public  Task<Result<int>> GetWashletcount(string UserId, CancellationToken canToken);
        public Task<List<int>> GetProductcounts();
        public Task<List<ProductSearchResponse>> GetProductsName(string Product);
        public List<ProductSearchResponse> GetAllProductsName();

    }
}
