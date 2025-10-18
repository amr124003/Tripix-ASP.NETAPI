using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Tripix.Abstractions;
using Tripix.Context;
using Tripix.Contracts.Common;
using Tripix.Contracts.Wash;
using Tripix.Entities;
using Tripix.Errors;
using Tripix.Extentions;
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
        public async Task<Result> BookingTurn ( string UserId, AddWashDTO model, CancellationToken canToken )
        {
            var user = await usermanger.Users.FirstOrDefaultAsync(x => x.Id == UserId , canToken);

            var validuser = user!.ValidUser();
            if(validuser.IsFalure) { return validuser; }

            WashBooking newTurn = model.UserPhone != null ? model.Adapt<WashBooking>()
                 : new()
                 {
                     UserName = user!.Name,
                     UserPhone = user.PhoneNumber,
                     TurnDate = model.TurnDate,
                     CarType = model.CarType,
                     PricingPlan = model.PricingPlan
                 };

            newTurn.UserEmail = user!.Email!;

            user.WashBookings.Add(newTurn);
            await context.SaveChangesAsync(canToken);
            return Result.Success();
        }

        public async Task<Result> CancelTurn ( string UserId, int TurnId, CancellationToken canToken)
        {
            var user = await usermanger.Users.Include(x => x.WashBookings).FirstOrDefaultAsync(x => x.Id == UserId , canToken);

            var validuser = user!.ValidUser();
            if(validuser.IsFalure) { return validuser; }

            var Turn = user!.WashBookings.FirstOrDefault(x => x.Id == TurnId);

            if (Turn == null) { return Result.Failure(WashErrors.TurnNotfound); }

            user.WashBookings.Remove(Turn);
            await context.SaveChangesAsync(canToken);
            return Result.Success();
        }

        public async Task<Result> DeleteTurn ( int TurnId, CancellationToken canToken)
        {
            var Turn = await context.WashBookings.FirstOrDefaultAsync(x => x.Id == TurnId , canToken);

            if(Turn == null) {return Result.Failure(WashErrors.TurnNotfound); }

            context.WashBookings.Remove(Turn);
            await context.SaveChangesAsync(canToken);
            return Result.Success();
        }

        public async Task<Result<WashBooking>> GetTurnDetails ( int TurnId, string UserId , CancellationToken canToken)
        {
            var res = new  WashBooking();
            var user = await usermanger.Users.Include(x => x.WashBookings).FirstOrDefaultAsync(x => x.Id == UserId, canToken);

            var validuser = user!.ValidUser(res);
            if (validuser.IsFalure) { return validuser!; }

            res = user!.WashBookings.FirstOrDefault(x => x.Id == TurnId);

            if (res == null) { return Result.Failure<WashBooking>(WashErrors.TurnNotfound); }

            return Result.Success(res);
        }


        public async Task<PaginatedList<WashBooking>> GetTurns (RequestFilter model , CancellationToken canToken)
        {
            var Turns = await context.WashBookings
                .CreatePaginatedList<WashBooking>(model.PageNumber , model.PageSize , canToken);

            return Turns;
        }

        public async Task<Result<List<WashBooking>>> GetUserTurn(string UserId , CancellationToken canToken )
        {
            var res = new List<WashBooking>();
            var user = await usermanger.Users.Include(x => x.WashBookings).FirstOrDefaultAsync(x => x.Id == UserId , canToken);

            var validuser = user!.ValidUser(res);
            if (validuser.IsFalure) { return validuser!; }

            res =  user!.WashBookings.ToList();
            return Result.Success(res);
        }

        public async Task<Result<WashBooking>> UpdateTurn ( string UserId, UpdateWashTurnDTO model , CancellationToken canToken)
        {
            var res = new WashBooking();
            var user = await usermanger.Users.Include(x => x.WashBookings).FirstOrDefaultAsync( x => x.Id == UserId, canToken);

            var validuser = user!.ValidUser(res);
            if (validuser.IsFalure) { return validuser!; }

            res = user!.WashBookings.FirstOrDefault(x => x.Id == model.Id);

            if (res == null) { return Result.Failure<WashBooking>(WashErrors.TurnNotfound); }

            model.Adapt(res);
            await context.SaveChangesAsync(canToken);
            return Result.Success(res);
        }


    }
}
