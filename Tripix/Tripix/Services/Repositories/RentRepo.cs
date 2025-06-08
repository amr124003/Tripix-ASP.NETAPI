using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Tripix.Abstractions;
using Tripix.Abstractions.Consts;
using Tripix.Context;
using Tripix.Contracts.Car;
using Tripix.Contracts.CarRental;
using Tripix.Entities;
using Tripix.Errors;
using Tripix.Services.Interfaces;

namespace Tripix.Services.Repositories
{
    public class RentRepo : IRent
    {
        private readonly ApplicationDbcontext context;
        private readonly UserManager<ApplicationUser> usermanger;

        public RentRepo ( ApplicationDbcontext context, UserManager<ApplicationUser> usermanger )
        {
            this.context = context;
            this.usermanger = usermanger;
        }
        public async Task<Result<CarForRentResponse>> AddCar ( AddCarforRent model )
        {
            if (model.Image == null || model.Image.Length == 0) { return Result.Failure<CarForRentResponse>(CarRentError.ImageNotFound); }

            var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.CarForRentImageUrl}{model.Image.FileName}");

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await model.Image.CopyToAsync(stream);
            }

            var newCarForRent = model.Adapt<CarsForrRent>();

            newCarForRent.Image = $"{Urls.CarForRentImageUrl}{model.Image.FileName}";

            context.CarsForrRents.Add(newCarForRent);

            await context.SaveChangesAsync();

            var res = newCarForRent.Adapt<CarForRentResponse>();

            return Result.Success(res);
        }

        public async Task<Result> CancellCarforRent (string UserId ,  int Id )
        {
            var user = await usermanger.Users.FirstOrDefaultAsync(x => x.Id == UserId);

            if (user == null) { return Result.Failure(UserErrors.UserNotFound); }

            if (!user.EmailConfirmed) { return Result.Failure(UserErrors.UnconfirmedEmail); }

            if (user.IsDisabled) { return Result.Failure(UserErrors.DisabledUser); }

            var carrent = user.carRents.FirstOrDefault(x => x.Id == Id);

            if (carrent == null) { return Result.Failure(CarRentError.RentNotFound); }

            var carforrent = await context.CarsForrRents.FirstOrDefaultAsync(x => x.Id == carrent.CarID);

            if (carforrent == null) { return Result.Failure(CarRentError.CarforRentNotfound); }

            carforrent.Status = CarForRentStatus.Avilable;

            
            context.CarRents.Remove(carrent);
            await context.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<Result> DeleteCarForRent ( int Id )
        {
            var carRent = await context.CarRents.FirstOrDefaultAsync(x => x.Id == Id);

            if (carRent == null) { return Result.Failure<CarForRentResponse>(CarRentError.RentNotFound); }

            var carforrent = await context.CarsForrRents.FirstOrDefaultAsync(x => x.Id == carRent.CarID);

            if (carforrent == null) { return Result.Failure(CarRentError.CarforRentNotfound); }

            carforrent.Status = CarForRentStatus.Avilable;

            context.CarRents.Remove(carRent);

            await context.SaveChangesAsync();

            return Result.Success();
        }

        public List<CarsForrRent> GetAvilableCars ()
        {
            var carForRents = context.CarsForrRents.AsNoTracking().Where(x => x.Status == CarForRentStatus.Avilable).ToList();

            return carForRents;
        }

        public async Task<Result<CarsForrRent>> GetCarForRent ( int Id )
        {
            var carForRent = await context.CarsForrRents.FirstOrDefaultAsync(x => x.Id == Id);

            if (carForRent == null) { return Result.Failure<CarsForrRent>(CarRentError.CarforRentNotfound); }

            return Result.Success(carForRent);
        }

        public async Task<Result<CarRent>> GetCarRented ( string UserId, int CarId )
        {
            var user = await usermanger.Users.FirstOrDefaultAsync(x => x.Id == UserId);

            if (user == null) { return Result.Failure<CarRent>(UserErrors.UserNotFound); }

            if (!user.EmailConfirmed) { return Result.Failure<CarRent>(UserErrors.UnconfirmedEmail); }

            if (user.IsDisabled) { return Result.Failure<CarRent>(UserErrors.DisabledUser); }

            var carforRent = user.carRents.FirstOrDefault(x => x.Id == CarId);

            if(carforRent == null) { return Result.Failure<CarRent>(CarRentError.RentNotFound); }

            return Result.Success(carforRent);
        }

        public async Task<Result<CarForRentResponse>> Rentcar ( string UserId, RentCarDTO model )
        {
            var CarForRent = context.CarsForrRents.FirstOrDefault(x => x.Id == model.CarId);

            if (CarForRent == null) { return Result.Failure<CarForRentResponse>(CarRentError.CarforRentNotfound); }

            if (CarForRent.Status != CarForRentStatus.Avilable) { return Result.Failure<CarForRentResponse>(CarRentError.CarIsRented); }

            var user = await usermanger.Users.FirstOrDefaultAsync(x => x.Id == UserId);

            if (user == null) { return Result.Failure<CarForRentResponse>(UserErrors.UserNotFound); }



            var CarRent = model.Phone != null ? model.Adapt<CarRent>() : new CarRent()
            {
                TenantName = user.Name,
                TenantPhone = user.PhoneNumber,
                CarID = model.CarId,
                CarName = CarForRent.Name,
                StartDate = model.StartDate,
                EndDate = model.EndDate,
                RentPrice = (decimal)((model.StartDate - model.EndDate).TotalHours) * CarForRent.HourlyPrice,
            };
            CarRent.TenantEmail = user.Email!;

            CarForRent.Status = CarForRentStatus.Rented;

            user.carRents.Add(CarRent);

            await context.SaveChangesAsync();

            var res = CarForRent.Adapt<CarForRentResponse>();

            return Result.Success(res);
        }

        public async Task<Result<CarForRentResponse>> UpdateCarForRent ( UpdateCarForRentDTO model )
        {
            var carforrent = await context.CarsForrRents.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (carforrent == null) { return Result.Failure<CarForRentResponse>(CarRentError.CarforRentNotfound); }

            if (model.Image == null || model.Image.Length == 0) { return Result.Failure<CarForRentResponse>(CarRentError.ImageNotFound); }

            var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.CarForRentImageUrl}{model.Image.FileName}");

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await model.Image.CopyToAsync(stream);
            }

            model.Adapt(carforrent);
            carforrent.Image = $"{Urls.CarForRentImageUrl}{model.Image.FileName}";
            await context.SaveChangesAsync();

            var res = carforrent.Adapt<CarForRentResponse>();

            return Result.Success(res);
        }


    }
}
