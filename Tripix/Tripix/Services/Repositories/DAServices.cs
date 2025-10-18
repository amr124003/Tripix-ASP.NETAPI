using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OpenQA.Selenium;
using RTools_NTS.Util;
using Stripe.Tax;
using System.Text.RegularExpressions;
using Tripix.Abstractions;
using Tripix.Context;
using Tripix.Contracts.Car;
using Tripix.Contracts.Common;
using Tripix.Contracts.DA;
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

        public DAServices(ApplicationDbcontext context, UserManager<ApplicationUser> usermager)
        {
            this.context = context;
            this.usermager = usermager;
        }

        public List<ProductSearchResponse> GetAllProductsName()
        {
            var res = context.Vehicles.ProjectToType<ProductSearchResponse>().ToList();

            return res;
        }

        public async Task<List<DAResponse>> GetBestSellerFromProducts(string ProductName)
        {
            

            var res = await context.Vehicles
                .FromSqlInterpolated($@"
                              SELECT TOP 10 V.*
                              FROM Vehicles V
                              INNER JOIN(
                                  SELECT VehicleId, COUNT(*) AS BookingsCount
                                  FROM VehicleBookings
                                  GROUP BY VehicleId
                              ) VB ON V.Id = VB.VehicleId
                              WHERE V.VehicleType = '{ProductName}'
                              ORDER BY VB.BookingsCount DESC")
                .AsNoTracking()
                .ProjectToType<DAResponse>()
                .ToListAsync();

            return res;
        }

        public async Task<List<DAResponse>> GetBestSellerProducts()
        {
            var sql = @"
                              SELECT TOP 10 V.*
                              FROM Vehicles V
                              INNER JOIN (
                                  SELECT VehicleId, COUNT(*) AS BookingsCount
                                  FROM VehicleBookings
                                  GROUP BY VehicleId
                              ) VB ON V.Id = VB.VehicleId
                              ORDER BY VB.BookingsCount DESC";

            var res = await context.Vehicles
                .FromSqlRaw(sql)
                .AsNoTracking()
                .ProjectToType<DAResponse>()
                .ToListAsync();

            return res;

        }

        public async Task<List<DAResponse>> GetNewArrivalFromProduct(string ProductName)
        {
            var res = await context.Vehicles
                                  .FromSqlInterpolated($@"
                                      SELECT TOP 5 * FROM Vehicles 
                                      WHERE VehicleType = {ProductName} 
                                      ORDER BY CreatedAt DESC")
                                  .AsNoTracking()
                                  .ProjectToType<DAResponse>()
                                  .ToListAsync();

            return res;

        }

        public async Task<List<DAResponse>> GetNewArrivalsProduct()
        {
            var sql = @"
                             SELECT TOP 3 * 
                             FROM Vehicles 
                             WHERE VehicleType = 'Car'
                             ORDER BY CreatedAt DESC
                             
                             UNION ALL
                             
                             SELECT TOP 3 * 
                             FROM Vehicles 
                             WHERE VehicleType = 'Motorbike'
                             ORDER BY CreatedAt DESC
                             
                             UNION ALL
                             
                             SELECT TOP 3 * 
                             FROM Vehicles 
                             WHERE VehicleType = 'ElectricCar'
                             ORDER BY CreatedAt DESC
                             
                             UNION ALL
                             
                             SELECT TOP 3 * 
                             FROM Vehicles 
                             WHERE VehicleType = 'UsedCar'
                             ORDER BY CreatedAt DESC";

            var res = await context.Vehicles
                .FromSqlRaw(sql)
                .AsNoTracking()
                .ProjectToType<DAResponse>()
                .ToListAsync();

            return res;
        }



        public async Task<List<int>> GetProductcounts()
        {
            var sql = @"
                          SELECT COUNT(*) FROM Vehicles WHERE VehicleType = 'Car'
                          UNION ALL
                          SELECT COUNT(*) FROM Vehicles WHERE VehicleType = 'Motorbike'
                          UNION ALL
                          SELECT COUNT(*) FROM Vehicles WHERE VehicleType = 'ElectricCar'
                          UNION ALL
                          SELECT COUNT(*) FROM Vehicles WHERE VehicleType = 'UsedCar';";

            var result = await context.Database
                .SqlQueryRaw<int>(sql)
                .ToListAsync();

            return result;

        }

        public async Task<PaginatedList<ProductResponse>> GetProducts(RequestFilter model, CancellationToken canToken)
        {
            var sql = @"
                             SELECT * FROM 
                             Vehicles WHERE VehicleType = 'Car'      
                             UNION ALL
                             SELECT * FROM 
                             Vehicles WHERE VehicleType = 'Motorbike' 
                             UNION ALL
                             SELECT * FROM 
                             Vehicles WHERE VehicleType = 'ElectricCar' 
                             UNION ALL
                             SELECT * FROM 
                             Vehicles WHERE VehicleType = 'UsedCar'";

            var res = await context.Vehicles
                .FromSqlRaw(sql)
                .ProjectToType<ProductResponse>()
                .CreatePaginatedList<ProductResponse>(model.PageNumber, model.PageSize, canToken);

            return res;
        }

        public async Task<List<ProductSearchResponse>> GetProductsName (string Product)
        {
            var res = await context.Vehicles
                                  .FromSqlInterpolated($@"
                                      SELECT * FROM Vehicles 
                                      WHERE VehicleType = {Product}")
                                  .AsNoTracking()
                                  .ProjectToType<ProductSearchResponse>()
                                  .ToListAsync();

            return res;
        }

       

        public async Task<List<DAResponse>> GetTopRatedFromProduct(string ProductName)
        {
            var res = await context.Vehicles
                .FromSqlInterpolated($@"
                             SELECT TOP 10 *
                             FROM Vehicles
                             WHERE VehicleType = {ProductName}
                             ORDER BY Views DESC")
                .AsNoTracking()
                .ProjectToType<DAResponse>()
                .ToListAsync();

            return res;

        }

        public async Task<List<DAResponse>> GetTopRatedProduct()
        {
            var sql = @"SELECT TOP 10 * 
                             FROM Vehicles 
                             ORDER BY Rate DESC";

            var res = await context.Vehicles
                .FromSqlRaw(sql)
                .AsNoTracking()
                .ProjectToType<DAResponse>()
                .ToListAsync();

            return res;

        }

        public async Task<List<DAResponse>> GetTrendingFromProduct(string ProductName)
        {

            var res = await context.Vehicles
                .FromSqlInterpolated($@"
                             SELECT TOP 5 *
                             FROM Vehicles
                             WHERE VehicleType = {ProductName}
                             ORDER BY Views DESC")
                .AsNoTracking()
                .ProjectToType<DAResponse>()
                .ToListAsync();

            return res;

        }

        public async Task<List<DAResponse>> GetTrendingProducts()
        {
            var sql = @"
                             SELECT TOP 10 *
                             FROM Vehicles
                             ORDER BY Views DESC";

            var res = await context.Vehicles
                .FromSqlRaw(sql)
                .AsNoTracking()
                .ProjectToType<DAResponse>()
                .ToListAsync();

            return res;

        }

        

        public async Task<Result<List<FavouriteProduct>>> GetWashlet(string UserId, CancellationToken canToken = default)
        {
            var res = new List<FavouriteProduct>();

            var user = await usermager.Users.Include(x => x.FavouriteProducts).FirstOrDefaultAsync(x => x.Id == UserId, canToken);

            var validuser = user!.ValidUser(res);
            if (validuser.IsFalure) { return validuser!; }

            res = user!.FavouriteProducts.ToList();
            return Result.Success(res);
        }

        

        public async Task<Result<int>> GetWashletcount(string UserId, CancellationToken canToken)
        {

            var user = await usermager.Users.FirstOrDefaultAsync(x => x.Id == UserId, canToken);
            int res = 0;

            var validuser = user!.ValidUser(res);
            if (validuser.IsFalure) return validuser;

            res = await context.FavouriteProducts
                .Where(x => x.UserId == UserId)
                .CountAsync(canToken);

            return Result.Success(res);
        }
    }
}
