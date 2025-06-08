using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Tripix.Abstractions;
using Tripix.Context;
using Tripix.Contracts;
using Tripix.Contracts.Vehicle;
using Tripix.Entities;
using Tripix.Extentions;
using Tripix.Services.Interfaces;

namespace Tripix.Services.Repositories
{
    public class DAServices : IDAService
    {
        private readonly ApplicationDbcontext context;
        private readonly UserManager<ApplicationUser> usermager;

        public DAServices ( ApplicationDbcontext context , UserManager<ApplicationUser> usermager)
        {
            this.context = context;
            this.usermager = usermager;
        }
        public async Task<List<DAResponse>> GetBestSellerProducts ()
        {
            var Res = await context.VehicleBookings
                .GroupBy(x => x.VehicleId)
                .OrderByDescending(g => g.Count())
                .Select(x => new { CarId = x.Key })
                .Take(10)
                .Join(context.Vehicles,
                x => x.CarId, v => v.Id, ( x, v ) => v)
                .ProjectToType<DAResponse>()
                .ToListAsync();

            return Res;
        }

        public async Task<List<DAResponse>> GetNewArrivalsProduct ()
        {
            var Res = await context.Vehicles.
                Where(x => (DateTime.UtcNow - x.CreatedAt) < TimeSpan.FromDays(2))
                .Take(10)
                .ProjectToType<DAResponse>()
                .ToListAsync();

            return Res;
        }

        public Task<List<ProductResponse>> GetProducts()
        {
            throw new NotImplementedException();
        }

        public async Task<Result<Testimonial>> GetTestimonial ()
        {
            var MaxId = await context.testimonials.MaxAsync(x => x.Id);

            var random = new Random();
            int Id = random.Next(1, MaxId + 1);

            var res = await context.testimonials.FirstOrDefaultAsync(x => x.Id == Id);

            if (res == null) { return Result.Failure<Testimonial>(new Error("Testimonial Not Found", "This Testimonial Not Found", StatusCodes.Status400BadRequest ) ); }

            return Result.Success(res);
        }

        public async Task<List<DAResponse>> GetTopRatedProduct ()
        {
            var res =
                await context.Vehicles.OrderByDescending(x => x.Rate)
                .Take(10)
                .ProjectToType<DAResponse>()
                .ToListAsync();

            return res;
        }

        public async Task<List<DAResponse>> GetTrendingProducts ()
        {
            var res = await
                context.Vehicles.OrderByDescending(x => x.Views)
                .Take (10)
                .ProjectToType<DAResponse>()
                .ToListAsync();

            return res;
        }

        public async Task<Result<int>> GetWashlet(string UserId, CancellationToken canToken = default)
        {
            int res = 0;

            var user = await usermager.Users.Include(x => x.FavouriteProducts).FirstOrDefaultAsync(x => x.Id == UserId, canToken);

            var validuser = user!.ValidUser(res); 
            if(validuser.IsFalure) { return validuser; }

            res = user!.FavouriteProducts.Count();
            return Result.Success(res);
        }

        public async Task<Result<int>> GetWashletcount(string UserId , CancellationToken canToken)
        {
            int res = 0;

            var user = await usermager.Users.FirstOrDefaultAsync(x =>x.Id == UserId , canToken);

            var validuser = user!.ValidUser(res);
            if (validuser.IsFalure) { return validuser; }

            res = user!.FavouriteProducts.Count();

            return Result.Success(res);
        }
    }
}
