using Mapster;
using Microsoft.EntityFrameworkCore;
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
            if (model.Images == null || model.Images.Count == 0)
            {
                return Result.Failure<ElectricCarsResponse>(VehicleErrors.ImagesNotFound);
            }

            using var Transaction = context.Database.BeginTransaction();

            try
            {
                var newCar = model.Adapt<ElectricCars>();
                await context.Vehicles.AddAsync(newCar);
                await context.SaveChangesAsync();

                foreach (var Image in model.Images)
                {
                    ; var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.ElectricCarImageUrl}{Image.FileName}");

                    using (var Stream = new FileStream(path, FileMode.Create))
                    {
                        await Image.CopyToAsync(Stream);
                    }
                    newCar.VehicleImages.Add(new VehicleImage()
                    {
                        ImageUrl = $"{Urls.ElectricCarImageUrl}{Image.FileName}"
                    });
                }
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

        public async Task<Result> DeleteCar ( int Id )
        {
            var Car = await context.Vehicles.OfType<ElectricCars>()
                .FirstOrDefaultAsync(x => x.Id == Id);

            if (Car == null) { return Result.Failure(VehicleErrors.VehicleNotFound); }

            context.Vehicles.Remove(Car);
            await context.SaveChangesAsync();
            return Result.Success();
        }

        public async Task<PaginatedList<ElectricCarsResponse>> GetAll ( RequestFilter model, CancellationToken canToken )
        {
            var Cars = await context.Vehicles.OfType<ElectricCars>()
                .AsNoTracking()
                .ApplyFilter<ElectricCars>(model.SearchValues)
                .ProjectToType<ElectricCarsResponse>()
                .CreatePaginatedList<ElectricCarsResponse>(model.PageNumber, model.PageSize, canToken);

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
            var Car = await context.Vehicles.OfType<ElectricCars>()
                .FirstOrDefaultAsync(x => x.Id == model.Id);

            if (Car == null) { return Result.Failure<ElectricCarsResponse>(VehicleErrors.VehicleNotFound); }

            model.Adapt(Car);
            await context.SaveChangesAsync();

            var response = Car.Adapt<ElectricCarsResponse>();
            return Result.Success(response);
        }
    }
}
