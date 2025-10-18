using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MimeKit.Cryptography;
using Tripix.Abstractions;
using Tripix.Abstractions.Consts;
using Tripix.Context;
using Tripix.Contracts.Car;
using Tripix.Contracts.CarRepair;
using Tripix.Contracts.Common;
using Tripix.Entities;
using Tripix.Errors;
using Tripix.Extentions;
using Tripix.Services.Interfaces;

namespace Tripix.Services.Repositories
{
    public class RepairRepo : IRepair
    {
        private readonly ApplicationDbcontext context;
        private readonly UserManager<ApplicationUser> usermanger;

        public RepairRepo ( ApplicationDbcontext context, UserManager<ApplicationUser> usermanger )
        {
            this.context = context;
            this.usermanger = usermanger;
        }
        public async Task<Result<CarRepairResponse>> BookingTurn ( string UserId, BookingTurnDTO model )
        {
            var user = usermanger.Users.FirstOrDefault(x => x.Id == UserId);

            if (user == null) { return Result.Failure<CarRepairResponse>(UserErrors.UserNotFound); }

            if(!user.EmailConfirmed) { return Result.Failure<CarRepairResponse>(UserErrors.UnconfirmedEmail); }

            if(user.IsDisabled) { return Result.Failure<CarRepairResponse>(UserErrors.DisabledUser); }

            var newRepairTurn = model.UserPhone != null ? model.Adapt<RepairBookings>() 
                :new RepairBookings() 
                {
                    UserName = user.Name,
                    UserPhone = user.PhoneNumber,
                    RepairDate = model.RepairTime,
                    CarType = (CarFuelTypes)Enum.Parse(typeof(CarFuelTypes) , model.CarType),
                    PricingPlan = (PricingPlan)Enum.Parse(typeof (PricingPlan), model.PricingPlan),
                };
            newRepairTurn.UserEmail = user.Email;

            user.RepairBookings.Add(newRepairTurn);
            await context.SaveChangesAsync();

            var res = newRepairTurn.Adapt<CarRepairResponse>();

            return Result.Success(res);
        }

        public async Task<Result> CancelTurn ( string UserId, int Id )
        {
            var user = await usermanger.Users.Include(x => x.RepairBookings).FirstOrDefaultAsync(x => x.Id == UserId);

            if (user == null) { return Result.Failure(UserErrors.UserNotFound); }

            if (!user.EmailConfirmed) { return Result.Failure(UserErrors.UnconfirmedEmail); }

            if (user.IsDisabled) { return Result.Failure(UserErrors.DisabledUser); }

            var Turn = user.RepairBookings.FirstOrDefault(x => x.Id == Id);

            if (Turn == null) { return Result.Failure(RepairErrors.TurnNotfound); }

            user.RepairBookings.Remove(Turn);
            await context.SaveChangesAsync();
            return Result.Success();
        }

        public async Task<Result> DeleteTurn ( int Id )
        {
            var RepairBooking = context.RepairBookings.FirstOrDefault(x => x.Id == Id);

            if (RepairBooking == null) { return Result.Failure(RepairErrors.TurnNotfound); }

            context.RepairBookings.Remove(RepairBooking);
            await context.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<PaginatedList<RepairBookings>> GetRepairBookings (RequestFilter model , CancellationToken canToken)
        {
            var res = await context.RepairBookings.AsNoTracking()
                .CreatePaginatedList<RepairBookings>(model.PageNumber, model.PageSize, canToken);

            return res;
        }

        public async Task<Result<List<RepairBookings>>> GetTurns ( string UserId )
        {
            var res = new List<RepairBookings>();
            var user = await usermanger.Users.Include(x => x.RepairBookings).FirstOrDefaultAsync(x => x.Id == UserId);

            var validuser = user!.ValidUser(res);
            if(validuser.IsFalure) { return validuser!; }

            res =  user!.RepairBookings
                .ToList();

            return Result.Success(res);
        }

        public async Task<Result<CarRepairResponse>> UpdateTurn ( UpdateTurnDTO model )
        {
            var repairTurn = context.RepairBookings.FirstOrDefault(x => x.Id == model.Id);
            if (repairTurn == null) { return Result.Failure<CarRepairResponse>(RepairErrors.TurnNotfound); }

            model.Adapt(repairTurn);
            await context.SaveChangesAsync();

            var res = repairTurn.Adapt<CarRepairResponse>();
            return Result.Success(res);
        }
    }
}
