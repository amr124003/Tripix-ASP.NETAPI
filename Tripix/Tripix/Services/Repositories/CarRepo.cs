using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using RTools_NTS.Util;
using Tripix.Abstractions;
using Tripix.Abstractions.Consts;
using Tripix.Context;
using Tripix.Contracts.Car;
using Tripix.Contracts.Common;
using Tripix.Entities;
using Tripix.Errors;
using Tripix.Extentions;
using Tripix.Services.Interfaces;

namespace Tripix.Services.Repositories
{
    public class CarRepo : ICarRepo
    {
        private readonly ApplicationDbcontext context;

        private readonly UserManager<ApplicationUser> usermanger;

        public CarRepo ( ApplicationDbcontext context, UserManager<ApplicationUser> usermanger )
        {
            this.context = context;
            this.usermanger = usermanger;
        }
        public async Task<Result<CarResponse>> AddCar ( CarDTO model , CancellationToken canToken)
        {

            if (model.CarImages is null || model.CarImages.Count == 0)
            {
                return Result.Failure<CarResponse>(VehicleErrors.ImagesNotFound);
            }

            using var Transaction = context.Database.BeginTransaction();

            try
            {
                var Car = model.Adapt<Car>();
                
                foreach (var image in model.CarImages)
                {
                    var imagepath = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.CarImageUrl}{image.FileName}");

                    using (var steam = new FileStream(imagepath, FileMode.Create))
                    {
                        await image.CopyToAsync(steam , canToken);
                    }

                    Car.VehicleImages.Add(new VehicleImage
                    {
                        ImageUrl = $"{Urls.SaveCarImageUrl}{image.FileName}"
                    });

                }

                await context.Vehicles.AddAsync(Car);
                await context.SaveChangesAsync(canToken);
                await Transaction.CommitAsync(canToken);

                var Response = Car.Adapt<CarResponse>();

                return Result.Success(Response);
            }
            catch (Exception)
            {
                await Transaction.RollbackAsync(canToken);
                return Result.Failure<CarResponse>(VehicleErrors.VehicleCannotAdded);
            }

        }



        public async Task<Result> DeleteCar ( int id , CancellationToken canToken)
        {
            var Car = await context.Vehicles.OfType<Car>().FirstOrDefaultAsync(x => x.Id == id, canToken);

            if (Car == null) { return Result.Failure<CarResponse>(VehicleErrors.VehicleNotFound); }

            using var Transaction = context.Database.BeginTransaction();

            try
            {
                if(Car.VehicleImages.Count == 0 || Car.VehicleImages != null)
                {
                    foreach(var image in Car.VehicleImages.Select(x => x.ImageUrl))
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot{image}");

                        if(File.Exists(path))
                        {
                            File.Delete(path);
                        }
                    }
                }

                context.Vehicles.Remove(Car);
                await context.SaveChangesAsync(canToken);
                await Transaction.CommitAsync(canToken);
                return Result.Success();
            }
            catch
            {
                await Transaction.RollbackAsync(canToken);
                return Result.Failure(VehicleErrors.VehicleNotFound);
            }
        }

        public async Task<Result<PaginatedList<CarResponse>>> GetCars ( string UserId , RequestFilter filters, CancellationToken CanToken )
        {
            var likedvehciles = await context.FavouriteProducts
                .Where(f => f.UserId == UserId)
                .Select(f => f.VehicleId)
                .ToListAsync(CanToken);

            var Cars = await context.Vehicles.OfType<Car>()
                .AsNoTracking()
                .ApplyFilter<Car>(filters.SearchValues)
                .ProjectToType<CarResponse>()
                .CreatePaginatedList<CarResponse>(filters.PageNumber, filters.PageSize, CanToken);

            var likedIdsSet = likedvehciles.ToHashSet(); // ÃÓÑÚ contains

            foreach (var item in Cars.Items)
            {
                item.IsLiked = likedIdsSet.Contains(item.Id);
            }

            return Result.Success(Cars);
        }



        public async Task<Result<Car>> GetCar ( int id , CancellationToken canToken)
        {
            var Car = await context.Vehicles.OfType<Car>().Include(x => x.VehicleImages).FirstOrDefaultAsync(x => x.Id == id);

            if (Car == null) { return Result.Failure<Car>(VehicleErrors.VehicleNotFound); }

            Car.Views++;
            await context.SaveChangesAsync(canToken);

            return Result.Success(Car);
        }



        public async Task<Result<CarResponse>> UpdateCar ( UpdateCar model , CancellationToken canToken)
        {
            var Car = await context.Vehicles.OfType<Car>().FirstOrDefaultAsync(x => x.Id == model.Id,canToken);

            if (Car == null) { return Result.Failure<CarResponse>(VehicleErrors.VehicleNotFound); }

            model.Adapt(Car);
            await context.SaveChangesAsync(canToken);

            var Response = Car.Adapt<CarResponse>();

            return Result.Success(Response);
        }

        public async Task<List<BrandDto>> GetBrands (CancellationToken canToken)
        {
            var res = await context.Brands.Include(x => x.Models)
                .Where(x => x.VehicleType == vehicletype.Car)
                .ProjectToType<BrandDto>()
                .ToListAsync(canToken);

            return res;
        }

        public async Task<Result> SellCar( SellCarDto model , CancellationToken canToken)
        {
            if (model.CarImages is null || model.CarImages.Count == 0)
            {
                return Result.Failure<CarResponse>(VehicleErrors.ImagesNotFound);
            }

            using var Transaction = context.Database.BeginTransaction();

            try
            {
                var Car = model.Adapt<UsedVehicle>();

                foreach (var image in model.CarImages)
                {
                    var uniqueFileName = $"{Guid.NewGuid()}_{image.FileName}";
                    var imagepath = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.CarImageUrl}{uniqueFileName}");

                    if (File.Exists(imagepath))
                    {
                        File.Delete(imagepath);
                    }

               

                    using (var stream = new FileStream(imagepath, FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        await image.CopyToAsync(stream, canToken);
                    }

                    Car.VehicleImages.Add(new VehicleImage
                    {
                        ImageUrl = $"{Urls.SaveCarImageUrl}{uniqueFileName}"
                    });
                }


                await context.Vehicles.AddAsync(Car);
                await context.SaveChangesAsync(canToken);
                await Transaction.CommitAsync(canToken);

                var Response = Car.Adapt<CarResponse>();

                return Result.Success(Response);
            }
            catch (Exception)
            {
                await Transaction.RollbackAsync(canToken);
                return Result.Failure<CarResponse>(VehicleErrors.VehicleCannotAdded);
            }
        }

        public async Task<Result<PaginatedList<CarResponse>>> GetUsedVehicles(string UserId, RequestFilter filters, CancellationToken canToken = default)
        {
            var likedvehciles = await context.FavouriteProducts
               .Where(f => f.UserId == UserId)
               .Select(f => f.VehicleId)
               .ToListAsync(canToken);

            var Cars = await context.Vehicles.OfType<UsedVehicle>()
                .AsNoTracking()
                .ApplyFilter<UsedVehicle>(filters.SearchValues)
                .ProjectToType<CarResponse>()
                .CreatePaginatedList<CarResponse>(filters.PageNumber, filters.PageSize, canToken);

            var likedIdsSet = likedvehciles.ToHashSet(); 

            foreach (var item in Cars.Items)
            {
                item.IsLiked = likedIdsSet.Contains(item.Id);
            }

            return Result.Success(Cars);
        }
    }
}