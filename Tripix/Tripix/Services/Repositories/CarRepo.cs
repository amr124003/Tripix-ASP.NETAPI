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
                return Result.Failure<CarResponse>(CarErrors.ImagesNotFound);
            }

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

            var Response = Car.Adapt<CarResponse>();

            return Result.Success(Response);
        }

        public async Task<Result<CarResponse>> BookingCar ( string UserId, BookCarDto model )
        {
            var Car = context.Vehicles.OfType<Car>().FirstOrDefault(x => x.Id == model.CarId);

            if (Car == null) { return Result.Failure<CarResponse>(CarErrors.CarNotFound); }

            if (Car.Status == VehicleStatus.Booked) { return Result.Failure<CarResponse>(CarErrors.CarIsBooked); }

            var user = await usermanger.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Id == UserId);

            if (user == null) { return Result.Failure<CarResponse>(UserErrors.UserNotFound); }

            if (user.IsDisabled) { return Result.Failure<CarResponse>(UserErrors.DisabledUser); }

            Car!.VehicleBooking = new VehicleBookings()
            {
                UserId = UserId,
                UserName = user.Name,
                UserEmail = user.Email,
                UserPhone = user.PhoneNumber,
                Category = bookingCategory.Car
            };

            var Response = Car.Adapt<CarResponse>();

            await context.SaveChangesAsync();
            return Result.Success(Response);
        }

        public async Task<Result> DeleteCar ( int id )
        {
            var Car = context.Vehicles.OfType<Car>().FirstOrDefault(x => x.Id == id);

            if (Car == null) { return Result.Failure<CarResponse>(CarErrors.CarNotFound); }

            context.Vehicles.Remove(Car);
            await context.SaveChangesAsync();
            return Result.Success();
        }

        public async Task<Result<PaginatedList<CarResponse>>> GetCars ( RequestFilter filters, CancellationToken CanToken )
        {
            var Cars = await context.Vehicles.OfType<Car>()
                .ApplyFilter<Car>(filters.SearchValues)
                .ProjectToType<CarResponse>()
                .CreatePaginatedList<CarResponse>(filters.PageNumber, filters.PageSize, CanToken);

            return Result.Success(Cars);
        }



        public async Task<Result<Car>> GetCar ( int id )
        {
            var Car = context.Vehicles.OfType<Car>().FirstOrDefault(x => x.Id == id);

            if (Car == null) { return Result.Failure<Car>(CarErrors.CarNotFound); }

            return Result.Success(Car);
        }

        public async Task<Result> LikeCar ( string UserId, LikeCarDTO model )
        {
            var Car = context.Vehicles.OfType<Car>().FirstOrDefault(x => x.Id == model.CarId);

            if (Car == null) { return Result.Failure<Car>(CarErrors.CarNotFound); }

            var user = await usermanger.Users.Include(x => x.FavouriteProducts).FirstOrDefaultAsync(x => x.Id == UserId);

            if (user == null) { return Result.Failure(UserErrors.UserNotFound); }

            var favCar = Car.Adapt<FavouriteProduct>();

            Car.LikeCounter++;
            user.FavouriteProducts.Add(favCar);

            await context.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<Result<CarResponse>> UpdateCar ( int Id, CarDTO model )
        {
            var Car = context.Vehicles.OfType<Car>().FirstOrDefault(x => x.Id == Id);

            if (Car == null) { return Result.Failure<CarResponse>(CarErrors.CarNotFound); }

            var UpdatedCar = model.Adapt<Car>();
            await context.SaveChangesAsync();

            var Response = Car.Adapt<CarResponse>();

            return Result.Success(Response);
        }

        public async Task<List<BrandDto>> GetBrands ()
        {
            var res = context.Brands.Include(x => x.Models)
                .Adapt<List<BrandDto>>();

            return res;
        }
    }
}