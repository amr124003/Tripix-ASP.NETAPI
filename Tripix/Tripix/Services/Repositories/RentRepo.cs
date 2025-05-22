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

        public async Task<Result> CancellCarforRent ( int Id )
        {
            var carforrent = await context.CarsForrRents.FirstOrDefaultAsync(x => x.Id == Id);

            if (carforrent == null) { return Result.Failure<CarResponse>(CarRentError.CarforRentNotfound); }

            carforrent.Status = CarForRentStatus.Avilable;

            var carrent = await context.CarRents.FirstOrDefaultAsync(x => x.CarID == Id);

            if (carforrent == null) { return Result.Success(); }

            context.CarRents.Remove(carrent);
            await context.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<Result> DeleteCarForRent ( int Id )
        {
            var carForRent = await context.CarsForrRents.FirstOrDefaultAsync(x => x.Id == Id);

            if (carForRent == null) { return Result.Failure<CarForRentResponse>(CarRentError.CarforRentNotfound); }

            context.CarsForrRents.Remove(carForRent);

            var carrent = context.CarRents.FirstOrDefault(x => x.CarID == Id);

            if (carrent == null) { return Result.Success(); }

            context.CarRents.Remove(carrent);
            await context.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<List<CarsForrRent>> GetAvilableCars ()
        {
            var carForRents = context.CarsForrRents.AsNoTracking().Where(x => x.Status == CarForRentStatus.Avilable).ToList();

            return carForRents;
        }

        public async Task<Result<CarsForrRent>> GetCarForRent ( int Id )
        {
            var carForRent = context.CarsForrRents.FirstOrDefault(x => x.Id == Id);

            if (carForRent == null) { return Result.Failure<CarsForrRent>(CarRentError.CarforRentNotfound); }

            return Result.Success(carForRent);
        }

        public async Task<Result<CarRent>> GetCarRented ( string UserId )
        {
            var user = usermanger.Users.FirstOrDefault(x => x.Id == UserId);
            if (user == null) { return Result.Failure<CarRent>(UserErrors.UserNotFound); }

            var carforRent = await context.CarRents.FirstOrDefaultAsync(x => x.UserId == UserId);

            return Result.Success(carforRent);
        }

        public async Task<Result<CarForRentResponse>> Rentcar ( string UserId, RentCarDTO model )
        {
            var CarForRent = context.CarsForrRents.FirstOrDefault(x => x.Id == model.CarId);

            if (CarForRent == null) { return Result.Failure<CarForRentResponse>(CarRentError.CarforRentNotfound); }

            if (CarForRent.Status != CarForRentStatus.Avilable) { return Result.Failure<CarForRentResponse>(CarRentError.CarIsRented); }

            var user = await usermanger.Users.FirstOrDefaultAsync(x => x.Id == UserId);

            if (user == null) { return Result.Failure<CarForRentResponse>(UserErrors.UserNotFound); }

            if (user.Email != model.Email && user.PhoneNumber != model.Phone)
            { return Result.Failure<CarForRentResponse>(UserErrors.ConfirmDatalikeYourCredentials); }

            var CarRent = model.Adapt<CarRent>();
            CarRent.UserId = UserId;

            CarForRent.Status = CarForRentStatus.Rented;

            await context.SaveChangesAsync();

            var res = CarForRent.Adapt<CarForRentResponse>();

            return Result.Success(res);
        }

        public async Task<Result<CarForRentResponse>> UpdateCarForRent ( UpdateCarForRentDTO model )
        {
            var carforrent = context.CarsForrRents.FirstOrDefaultAsync(x => x.Id == model.Id);
            if (carforrent == null) { return Result.Failure<CarForRentResponse>(CarRentError.CarforRentNotfound); }

            if (model.Image == null || model.Image.Length == 0) { return Result.Failure<CarForRentResponse>(CarRentError.ImageNotFound); }

            var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.CarForRentImageUrl}{model.Image.FileName}");

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await model.Image.CopyToAsync(stream);
            }

            var newCarForRent = model.Adapt<CarsForrRent>();

            newCarForRent.Image = $"{Urls.CarForRentImageUrl}{model.Image.FileName}";

            context.CarsForrRents.Update(newCarForRent);

            await context.SaveChangesAsync();

            var res = newCarForRent.Adapt<CarForRentResponse>();

            return Result.Success(res);


        }


    }
}
