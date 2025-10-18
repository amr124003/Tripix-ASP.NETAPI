using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Tripix.Abstractions;
using Tripix.Abstractions.Consts;
using Tripix.Context;
using Tripix.Contracts.Car;
using Tripix.Contracts.Vehicle;
using Tripix.Entities;
using Tripix.Errors;
using Tripix.Extentions;
using Tripix.Services.Interfaces;

namespace Tripix.Services.Repositories
{
    public class VehicleRepo : IVehicle
    {
        private readonly ApplicationDbcontext context;
        private readonly UserManager<ApplicationUser> usermanager;

        public VehicleRepo (ApplicationDbcontext context , UserManager<ApplicationUser> usermanager)
        {
            this.context = context;
            this.usermanager = usermanager;
        }
        public async Task<Result<VehicleResponse>> BookVehicle ( string UserId, int CarId )
        {
            var vehicle = context.Vehicles.FirstOrDefault(x => x.Id == CarId);

            if (vehicle == null) { return Result.Failure<VehicleResponse>(VehicleErrors.VehicleNotFound); }

            if (vehicle.Status == VehicleStatus.Booked) { return Result.Failure<VehicleResponse>(VehicleErrors.VehicleIsBooked); }

            var user = await usermanager.Users.AsNoTracking().FirstOrDefaultAsync(x => x.Id == UserId);

            if (user == null) { return Result.Failure<VehicleResponse>(UserErrors.UserNotFound); }

            if (user.IsDisabled) { return Result.Failure<VehicleResponse>(UserErrors.DisabledUser); }

            vehicle!.VehicleBooking.Add (new VehicleBookings()
            {
                UserId = UserId,
                UserName = user.Name,
                UserEmail = user.Email,
                UserPhone = user.PhoneNumber,
                Category = bookingCategory.Car
            });

            var Response = vehicle.Adapt<VehicleResponse>();

            await context.SaveChangesAsync();
            return Result.Success(Response);
        }

        

        public async Task<Result> DeleteBooking(int BookingId)
        {
            var Booking =await context.VehicleBookings.FirstOrDefaultAsync(x => x.Id ==  BookingId);

            if (Booking == null) { return Result.Failure(VehicleErrors.BookingNotFound); }

            context.VehicleBookings.Remove(Booking);
            await context.SaveChangesAsync();
            return Result.Success();
        }

        public async Task<Result> DisLikeVehicle(string UserId, int CarId)
        {
            var Car = context.Vehicles.FirstOrDefault(x => x.Id == CarId);

            if (Car == null) { return Result.Failure<Car>(VehicleErrors.VehicleNotFound); }

            var user = await usermanager.Users.Include(x => x.FavouriteProducts).FirstOrDefaultAsync(x => x.Id == UserId);

            var validuser = user!.ValidUser();
            if (validuser.IsFalure)
            {
                return validuser;
            }

            var favCar = Car.Adapt<FavouriteProduct>();

            Car.LikeCounter--;
            user!.FavouriteProducts.Remove(favCar);

            await context.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<List<VehicleBookings>> GetVehcileBookings(string Category)
        {
            var res = await context.VehicleBookings.Where(x => x.Category.ToString() == Category).ToListAsync();

            return res;
        }

        public async Task<Result> LikeVehicle (string UserId ,  int CarId )
        {
            var Car = context.Vehicles.Include(x => x.VehicleImages).FirstOrDefault(x => x.Id == CarId);

            if (Car == null) { return Result.Failure<Car>(VehicleErrors.VehicleNotFound); }

            var user = await usermanager.Users.Include(x => x.FavouriteProducts).FirstOrDefaultAsync(x => x.Id == UserId);

            var validuser = user!.ValidUser();
            if (validuser.IsFalure) 
            {
                return validuser;
            }

            var favCar = Car.Adapt<FavouriteProduct>();
            favCar.VehicleId = Car.Id;

            Car.LikeCounter++;
            user!.FavouriteProducts.Add(favCar);

            await context.SaveChangesAsync();

            return Result.Success();
        }

       
    }
}
