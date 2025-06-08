using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Tripix.Abstractions;
using Tripix.Context;
using Tripix.Contracts.Helpoo;
using Tripix.Entities;
using Tripix.Errors;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Services.Repositories
{
    public class HelpooRepo : Ihelpoo
    {
        private readonly UserManager<ApplicationUser> usermanger;
        private readonly ApplicationDbcontext context;

        public HelpooRepo (UserManager<ApplicationUser> usermanger , ApplicationDbcontext context)
        {
            this.usermanger = usermanger;
            this.context = context;
        }
        public async Task<Result> CancelOrder ( string UserId, int Id )
        {
            var user = await usermanger.Users.Include(x => x.HelpooOrders).FirstOrDefaultAsync(x => x.Id == UserId);

            if (user == null) { return Result.Failure(UserErrors.UserNotFound); }

            if(!user.EmailConfirmed) { return Result.Failure(UserErrors.UnconfirmedEmail); }

            if(user.IsDisabled) { return Result.Failure(UserErrors.DisabledUser); }

            var Order = user.HelpooOrders.FirstOrDefault(x => x.Id == Id);

            if (Order == null ) { return Result.Failure(HelpooErrors.OrderNotFound); }

            user.HelpooOrders.Remove(Order);
            await context.SaveChangesAsync();
            return Result.Success();
        }

        public async Task<Result> DeleteOrder ( int Id )
        {
            var Order = await context.HelpooOrders.FirstOrDefaultAsync(x => x.Id == Id);

            if(Order == null) { return Result.Failure(HelpooErrors.OrderNotFound); }

            context.HelpooOrders.Remove(Order);
            await context.SaveChangesAsync();
            return Result.Success();
        }

        public async Task<Result<HelpooOrders>> GetOrderDetails ( int Id, string UserId )
        {
            var user = await usermanger.Users.Include(x => x.HelpooOrders).FirstOrDefaultAsync(x => x.Id == UserId);

            if (user == null) { return Result.Failure<HelpooOrders>(UserErrors.UserNotFound); }

            if (!user.EmailConfirmed) { return Result.Failure<HelpooOrders>(UserErrors.UnconfirmedEmail); }

            if (user.IsDisabled) { return Result.Failure<HelpooOrders>(UserErrors.DisabledUser); }

            var Order = user.HelpooOrders.FirstOrDefault(x => x.Id == Id);

            if(Order == null) { return Result.Failure<HelpooOrders>(HelpooErrors.OrderNotFound); }

            return Result.Success(Order);
        }

        public List<HelpooOrders> GetOrders ()
        {
            var Orders = context.HelpooOrders.AsNoTracking().ToList();

            return Orders;
        }

        public async Task<Result<HelpooOrders>> OrderHelpoo (string UserId ,  OrderHelpooDTO model )
        { 
            var user = await usermanger.Users.Include(x => x.HelpooOrders).FirstOrDefaultAsync(x => x.Id == UserId);

            if (user == null) { return Result.Failure<HelpooOrders>(UserErrors.UserNotFound); }

            if (!user.EmailConfirmed) { return Result.Failure<HelpooOrders>(UserErrors.UnconfirmedEmail); }

            if (user.IsDisabled) { return Result.Failure<HelpooOrders>(UserErrors.DisabledUser); }

            var newOrder = model.UserPhone != null ? model.Adapt<HelpooOrders>() : new HelpooOrders()
            {
                UserName = user.Name,
                UserPhone = user.PhoneNumber,
                OrderTime = model.OrderTime,
                UserLatitude = model.UserLatitude,
                UserLongitude = model.UserLongitude,
            };
            newOrder.UserEmail = user.Email!;

            user.HelpooOrders.Add(newOrder);
            await context.SaveChangesAsync();
            return Result.Success(newOrder);
        }

        public async Task<Result<HelpooOrders>> UpdateOrderDetials (string UserId ,  UpdateHelpooDTO order )
        {
            var user = await usermanger.Users.Include(x => x.HelpooOrders).FirstOrDefaultAsync(x => x.Id == UserId);

            if (user == null) { return Result.Failure<HelpooOrders>(UserErrors.UserNotFound); }

            if (!user.EmailConfirmed) { return Result.Failure<HelpooOrders>(UserErrors.UnconfirmedEmail); }

            if (user.IsDisabled) { return Result.Failure<HelpooOrders>(UserErrors.DisabledUser); }

            var Order = user.HelpooOrders.FirstOrDefault(x => x.Id == order.Id);

            if(Order == null) { return Result.Failure<HelpooOrders>(HelpooErrors.OrderNotFound); }

            order.Adapt(Order);
            await context.SaveChangesAsync();
            return Result.Success(Order);
        }
    }
}
