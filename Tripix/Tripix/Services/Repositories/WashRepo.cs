using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Tripix.Abstractions;
using Tripix.Context;
using Tripix.Contracts.Wash;
using Tripix.Entities;
using Tripix.Errors;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Services.Repositories
{
    public class WashRepo : IWash
    {
        private readonly UserManager<ApplicationUser> usermanger;
        private readonly ApplicationDbcontext context;

        public WashRepo ( UserManager<ApplicationUser> usermanger, ApplicationDbcontext context )
        {
            this.usermanger = usermanger;
            this.context = context;
        }
        public async Task<Result> BookingTurn ( string UserId, AddWashDTO model )
        {
            var user = await usermanger.FindByIdAsync(UserId);

            if (user is null) return Result.Failure(UserErrors.UserNotFound);

            if (!user.EmailConfirmed) { return Result.Failure(UserErrors.UnconfirmedEmail); }

            if (user.IsDisabled) { return Result.Failure(UserErrors.DisabledUser); }

            WashBooking newTurn = model.UserPhone != null ? model.Adapt<WashBooking>()
                 : new()
                 {
                     UserName = user.Name,
                     UserPhone = user.PhoneNumber,
                     TurnDate = model.TurnDate,
                     CarType = model.CarType,
                     PricingPlan = model.PricingPlan
                 };

            user.WashBookings.Add(newTurn);
            await context.SaveChangesAsync();
            return Result.Success();
        }

        public async Task<Result> CancelTurn ( string UserId, int TurnId )
        {
            var user = await usermanger.FindByIdAsync(UserId);

            if (user is null) return Result.Failure(UserErrors.UserNotFound);

            if (!user.EmailConfirmed) { return Result.Failure(UserErrors.UnconfirmedEmail); }

            if (user.IsDisabled) { return Result.Failure(UserErrors.DisabledUser); }

            var Turn = user.WashBookings.FirstOrDefault(x => x.Id == TurnId);

            if (Turn == null) { return Result.Failure(WashErrors.TurnNotfound); }

            user.WashBookings.Remove(Turn);
            await context.SaveChangesAsync();
            return Result.Success();
        }

        public async Task<Result> DeleteTurn ( int TurnId )
        {
            var Turn = await context.WashBookings.FirstOrDefaultAsync(x => x.Id == TurnId);

            if(Turn == null) {return Result.Failure(WashErrors.TurnNotfound); }

            context.WashBookings.Remove(Turn);
            await context.SaveChangesAsync();
            return Result.Success();
        }

        public async Task<Result<WashBooking>> GetTurnDetails ( int TurnId, string UserId )
        {
            var user = await usermanger.FindByIdAsync(UserId);

            if (user is null) return Result.Failure<WashBooking>(UserErrors.UserNotFound);

            if (!user.EmailConfirmed) { return Result.Failure<WashBooking>(UserErrors.UnconfirmedEmail); }

            if (user.IsDisabled) { return Result.Failure<WashBooking>(UserErrors.DisabledUser); }

            var Turn = user.WashBookings.FirstOrDefault(x => x.Id == TurnId);

            if (Turn == null) { return Result.Failure<WashBooking>(WashErrors.TurnNotfound); }

            return Result.Success(Turn);
        }



        public async Task<List<WashBooking>> GetTurns ()
        {
            var Turns = await context.WashBookings.ToListAsync();

            return Turns;
        }

        public async Task<Result<WashBooking>> UpdateTurn ( string UserId, UpdateWashTurnDTO model )
        {
            var user = await usermanger.FindByIdAsync(UserId);

            if (user is null) return Result.Failure<WashBooking>(UserErrors.UserNotFound);

            if (!user.EmailConfirmed) { return Result.Failure<WashBooking>(UserErrors.UnconfirmedEmail); }

            if (user.IsDisabled) { return Result.Failure<WashBooking>(UserErrors.DisabledUser); }

            var Turn = user.WashBookings.FirstOrDefault(x => x.Id == model.Id);

            if (Turn == null) { return Result.Failure<WashBooking>(WashErrors.TurnNotfound); }

            model.Adapt(Turn);
            await context.SaveChangesAsync();
            return Result.Success(Turn);
        }


    }
}
