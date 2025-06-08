using Stripe;
using Tripix.Abstractions;
using Tripix.Contracts;
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
        public Task<Testimonial> GetTestimonial ();
        public Task<List<ProductResponse>> GetProducts();

    }
}
