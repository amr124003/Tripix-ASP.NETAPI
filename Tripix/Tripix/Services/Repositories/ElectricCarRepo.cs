using Mapster;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Bcpg;
using RTools_NTS.Util;
using Tripix.Abstractions;
using Tripix.Abstractions.Consts;
using Tripix.Context;
using Tripix.Contracts.Car;
using Tripix.Contracts.Common;
using Tripix.Contracts.ElectricCar;
using Tripix.Entities;
using Tripix.Errors;
using Tripix.Extentions;
using Tripix.Services.Interfaces;

namespace Tripix.Services.Repositories
{
    public class ElectricCarRepo : IElectricCar
    {
        private readonly ApplicationDbcontext context;

        public ElectricCarRepo ( ApplicationDbcontext context )
        {
            this.context = context;
        }
        public async Task<Result<ElectricCarsResponse>> AddCar ( AddElectricCatDTO model )
        {
            if (model.CarImages == null || model.CarImages.Count == 0)
            {
                return Result.Failure<ElectricCarsResponse>(VehicleErrors.ImagesNotFound);
            }

            using var Transaction = context.Database.BeginTransaction();

            try
            {
                var newCar = model.Adapt<ElectricCars>();
                

                foreach (var Image in model.CarImages)
                {
                    ; var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.CarImageUrl}{Image.FileName}");

                    using (var Stream = new FileStream(path, FileMode.Create))
                    {
                        await Image.CopyToAsync(Stream);
                    }
                    newCar.VehicleImages.Add(new VehicleImage()
                    {
                        ImageUrl = $"{Urls.SaveCarImageUrl}{Image.FileName}"
                    });
                }
                await context.Vehicles.AddAsync(newCar);
                await context.SaveChangesAsync();
                await Transaction.CommitAsync();
                var response = newCar.Adapt<ElectricCarsResponse>();
                return Result.Success(response);
            }
            catch (Exception)
            {
                await Transaction.RollbackAsync();
                return Result.Failure<ElectricCarsResponse>(VehicleErrors.VehicleCannotAdded);

            }
        }

        public async Task<Result> DeleteCar ( int Id , CancellationToken canToken)
        {
            var Car = await context.Vehicles.OfType<ElectricCars>()
                .Include(x => x.VehicleImages)
                .FirstOrDefaultAsync(x => x.Id == Id);

            if (Car == null) { return Result.Failure(VehicleErrors.VehicleNotFound); }

            using var Transaction = context.Database.BeginTransaction();

            try
            {
                if (Car.VehicleImages.Count == 0 || Car.VehicleImages != null)
                {
                    foreach (var image in Car.VehicleImages.Select(x => x.ImageUrl))
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot{image}");

                        if (File.Exists(path))
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

        public async Task<PaginatedList<ElectricCarsResponse>> GetAll (string UserId ,  RequestFilter model, CancellationToken canToken )
        {
            var likedvehciles = await context.FavouriteProducts
               .Where(f => f.UserId == UserId)
               .Select(f => f.VehicleId)
               .ToListAsync(canToken); 

            var Cars = await context.Vehicles.OfType<ElectricCars>()
                .AsNoTracking()
                .ApplyFilter<ElectricCars>(model.SearchValues)
                .ProjectToType<ElectricCarsResponse>()
                .CreatePaginatedList<ElectricCarsResponse>(model.PageNumber, model.PageSize, canToken);

            var likedIdsSet = likedvehciles.ToHashSet(); 

            foreach (var item in Cars.Items)
            {
                item.IsLiked = likedIdsSet.Contains(item.Id);
            }


            return Cars;
        }

        public async Task<List<BrandDto>> GetBrands ()
        {
            var res = context.Brands.Include(x => x.Models)
               .Where(x => x.VehicleType != vehicletype.Motorbike)
               .Adapt<List<BrandDto>>();

            return res;
        }

        public async Task<Result<ElectricCarsResponse>> GetById ( int Id )
        {
            var Car = await context.Vehicles.OfType<ElectricCars>()
                .FirstOrDefaultAsync(x => x.Id == Id);

            if (Car == null) { return Result.Failure<ElectricCarsResponse>(VehicleErrors.VehicleNotFound); }

            var Response = Car.Adapt<ElectricCarsResponse>();
            return Result.Success(Response);
        }

        public async Task<Result<ElectricCarsResponse>> UpdateCar ( UpdateElectricCarDto model )
        {
            var Car = await context.Vehicles.OfType<ElectricCars>().Include(x => x.VehicleImages)
                .FirstOrDefaultAsync(x => x.Id == model.Id);

            if (Car == null) { return Result.Failure<ElectricCarsResponse>(VehicleErrors.VehicleNotFound); }

            using var Transaction = context.Database.BeginTransaction();

            try
            {
                model.Adapt(Car);
                
                foreach(var Image in Car.VehicleImages.Select(x => x.ImageUrl))
                {
                    var oldpath = Path.Combine(Directory.GetCurrentDirectory(), Image);

                    if(File.Exists(oldpath))
                    {
                        File.Delete(oldpath);
                    }
                }

                foreach (var Image in model.CarImages)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.SaveCarImageUrl}{Image.FileName}");

                    using (var Stream = new FileStream(path, FileMode.Create))
                    {
                        await Image.CopyToAsync(Stream);
                    }
                    Car.VehicleImages.Add(new VehicleImage()
                    {
                        ImageUrl = $"{Urls.SaveCarImageUrl}{Image.FileName}"
                    });
                }
                model.Adapt(Car);
                await context.SaveChangesAsync();
                await Transaction.CommitAsync();
                var response = Car.Adapt<ElectricCarsResponse>();
                return Result.Success(response);
            }
            catch (Exception)
            {
                await Transaction.RollbackAsync();
                return Result.Failure<ElectricCarsResponse>(VehicleErrors.VehicleCannotUpdate);

            }
        }
    }
}
