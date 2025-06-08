using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
        public async Task<Result<CarResponse>> AddCar ( CarDTO model )
        {
            if (model.CarImages is null || model.CarImages.Count == 0)
            {
                return Result.Failure<CarResponse>(VehicleErrors.ImagesNotFound);
            }

            using var Transaction = context.Database.BeginTransaction();

            try
            {

                var Car = model.Adapt<Car>();
                Car.Gearbox_Type = (GearboxTypes)Enum.Parse(typeof(GearboxTypes), model.Gearbox_Type);

                foreach (var image in model.CarImages)
                {
                    var imagepath = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.CarImageUrl}{image.FileName}");

                    using (var steam = new FileStream(imagepath, FileMode.Create))
                    {
                        await image.CopyToAsync(steam);
                    }

                    Car.VehicleImages.Add(new VehicleImage
                    {
                        ImageUrl = $"{Urls.CarImageUrl}{image.FileName}"
                    });

                }

                context.Vehicles.Add(Car);
                context.SaveChanges();
                await Transaction.CommitAsync();

                var Response = Car.Adapt<CarResponse>();

                return Result.Success(Response);
            }
            catch (Exception)
            {
                await Transaction.RollbackAsync();
                return Result.Failure<CarResponse>(VehicleErrors.VehicleCannotAdded);
            }

        }



        public async Task<Result> DeleteCar ( int id )
        {
            var Car = context.Vehicles.OfType<Car>().FirstOrDefault(x => x.Id == id);

            if (Car == null) { return Result.Failure<CarResponse>(VehicleErrors.VehicleNotFound); }

            context.Vehicles.Remove(Car);
            await context.SaveChangesAsync();
            return Result.Success();
        }

        public async Task<Result<PaginatedList<CarResponse>>> GetCars ( RequestFilter filters, CancellationToken CanToken )
        {
            var Cars = await context.Vehicles.OfType<Car>()
                .AsNoTracking()
                .ApplyFilter<Car>(filters.SearchValues)
                .ProjectToType<CarResponse>()
                .CreatePaginatedList<CarResponse>(filters.PageNumber, filters.PageSize, CanToken);

            return Result.Success(Cars);
        }



        public async Task<Result<Car>> GetCar ( int id )
        {
            var Car = context.Vehicles.OfType<Car>().FirstOrDefault(x => x.Id == id);

            if (Car == null) { return Result.Failure<Car>(VehicleErrors.VehicleNotFound); }

            Car.Views++;
            await context.SaveChangesAsync();

            return Result.Success(Car);
        }



        public async Task<Result<CarResponse>> UpdateCar ( int Id, CarDTO model )
        {
            var Car = context.Vehicles.OfType<Car>().FirstOrDefault(x => x.Id == Id);

            if (Car == null) { return Result.Failure<CarResponse>(VehicleErrors.VehicleNotFound); }

            var UpdatedCar = model.Adapt<Car>();
            context.Vehicles.Update(UpdatedCar);
            await context.SaveChangesAsync();

            var Response = Car.Adapt<CarResponse>();

            return Result.Success(Response);
        }

        public async Task<List<BrandDto>> GetBrands ()
        {
            var res = context.Brands.Include(x => x.Models)
                .Where(x => x.VehicleType == vehicletype.Car)
                .Adapt<List<BrandDto>>();

            return res;
        }
    }
}