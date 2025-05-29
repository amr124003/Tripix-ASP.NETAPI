using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Tripix.Abstractions;
using Tripix.Context;
using Tripix.Contracts.CarRepair;
using Tripix.Entities;
using Tripix.Errors;
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

            var newRepairTurn = model.Adapt<RepairBookings>();

            if (context.RepairBookings.AsNoTracking().Any(x => x.RepairDate == newRepairTurn.RepairDate))
            {
                newRepairTurn.RepairDate = newRepairTurn.RepairDate.AddHours(1);
            }
            context.RepairBookings.Add(newRepairTurn);
            await context.SaveChangesAsync();

            var res = newRepairTurn.Adapt<CarRepairResponse>();

            return Result.Success(res);
        }

        public async Task<Result> DeleteTurn ( int Id )
        {
            var RepairBooking = context.RepairBookings.FirstOrDefault(x => x.Id == Id);

            if (RepairBooking == null) { return Result.Failure(RepairErrors.TurnNotfound); }

            context.RepairBookings.Remove(RepairBooking);
            await context.SaveChangesAsync();

            return Result.Success();
        }

        public async Task<List<RepairBookings>> GetRepairBookings ()
        {
            var res = context.RepairBookings.AsNoTracking().ToList();

            return res;
        }

        public async Task<Result<CarRepairResponse>> GetTurn ( int Id )
        {
            var repairbooking = context.RepairBookings.FirstOrDefault(x => x.Id == Id);
            if (repairbooking == null) { return Result.Failure<CarRepairResponse>(RepairErrors.TurnNotfound); }

            var res = repairbooking.Adapt<CarRepairResponse>();
            return Result.Success(res);
        }

        public async Task<Result<CarRepairResponse>> UpdateTurn ( UpdateTurnDTO model )
        {
            var repairTurn = context.RepairBookings.FirstOrDefault(x => x.Id == model.Id);
            if (repairTurn == null) { return Result.Failure<CarRepairResponse>(RepairErrors.TurnNotfound); }

            var updatedturn = model.Adapt<RepairBookings>();

            context.RepairBookings.Update(updatedturn);
            await context.SaveChangesAsync();

            var res = repairTurn.Adapt<CarRepairResponse>();

            return Result.Success(res);
        }
    }
}
