using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Reflection.Metadata.Ecma335;
using Tripix.Abstractions;
using Tripix.Abstractions.Consts;
using Tripix.Context;
using Tripix.Contracts.Common;
using Tripix.Contracts.SpareParts;
using Tripix.Entities;
using Tripix.Errors;
using Tripix.Extentions;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Services.Repositories
{
    public class SparePartRepo : ISparePart
    {
        private readonly ApplicationDbcontext context;
        private readonly UserManager<ApplicationUser> userManager;

        public SparePartRepo(ApplicationDbcontext context , UserManager<ApplicationUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }
        public async Task<Result<SparePartResponse>> AddSparePart(AddSparePartDTO model , CancellationToken canToken)
        {
            if(model.Images == null || model.Images.Count == 0)
            {
                return Result.Failure<SparePartResponse>(SparePartError.ImagesNotFound);
            }

            using var Transaction = context.Database.BeginTransaction();

            try
            {
                var newSparePart = model.Adapt<SpareParts>();

                foreach(var image in model.Images)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.SparePartImages}{image.FileName}");

                    using (var stream = new FileStream(path , FileMode.Create))
                    {
                        await image.CopyToAsync(stream , canToken);
                    }

                    newSparePart.Images.Add(new SparePartImage
                    {
                        ImageUrl = $"{Urls.SparePartImages}{image.FileName}"
                    });
                }
                await context.SpareParts.AddAsync(newSparePart, canToken);
                await context.SaveChangesAsync(canToken);
                await Transaction.CommitAsync(canToken);

                var Response = newSparePart.Adapt<SparePartResponse>();

                return Result.Success(Response);
            }
            catch
            {
                await Transaction.RollbackAsync(canToken);
                return Result.Failure<SparePartResponse>(SparePartError.ErrorOnAdd);
            }
        }

        public async Task<Result> CancelSparePartOrder(string UserId, int OrderId , CancellationToken canToken)
        {
            var user = await userManager.Users.Include(x => x.sparePartOrders).FirstOrDefaultAsync(x => x.Id == UserId , canToken);

            var ValidUser = user.ValidUser();

            if(ValidUser.IsFalure) { return ValidUser; }

            var Order = user.sparePartOrders.FirstOrDefault(x => x.Id == OrderId);

            if(Order == null) { return Result.Failure(SparePartError.OrderNotFound); }

            user.sparePartOrders.Remove(Order);
            await context.SaveChangesAsync(canToken);
            return Result.Success();
        } 

        public async Task<Result> DeleteOrder(int OrderId , CancellationToken canToken)
        {
            var order = await context.SparePartOrders.FirstOrDefaultAsync(x => x.Id == OrderId, canToken);

            if(order == null) { return Result.Failure(SparePartError.OrderNotFound); }

            context.SparePartOrders.Remove(order);
            await context.SaveChangesAsync(canToken);
            return Result.Success();
        }

        public async Task<Result> DeleteSparePart(int Id, CancellationToken canToken )
        {
            var sparepart = await context.SpareParts.FirstOrDefaultAsync(x => x.Id == Id , canToken);

            if (sparepart == null) { return Result.Failure(SparePartError.SparePartNotFound); }

            context.SpareParts.Remove(sparepart);
            await context.SaveChangesAsync(canToken);
            return Result.Success();
        }

        public async Task<PaginatedList<SparePartResponse>> GetAll(RequestFilter model , CancellationToken canToken)
        {
            var spareparts = await context.SpareParts
                .AsNoTracking()
                .ApplyFilter<SpareParts>(model.SearchValues)
                .ProjectToType<SparePartResponse>()
                .CreatePaginatedList<SparePartResponse>(model.PageNumber , model.PageSize, canToken);

            return spareparts;
        }

        public async Task<Result<SparePartOrder>> GetOrder(string UserId, int OrderId , CancellationToken canToken)
        {
            var response = new SparePartOrder();
            var user = await userManager.Users.Include(x => x.sparePartOrders).FirstOrDefaultAsync(x => x.Id == UserId , canToken);

            var validuserres = user!.ValidUser(response);

            if (validuserres.IsFalure) { return validuserres!; }

            response = user!.sparePartOrders.FirstOrDefault(x => x.Id == OrderId);

            if(response == null) { return Result.Failure<SparePartOrder>(SparePartError.OrderNotFound); }

            return Result.Success(response);
        }

        public async Task<PaginatedList<SparePartOrder>> GetOrders(RequestFilter model , CancellationToken canToken)
        {
            var Orders = await context.SparePartOrders.
                AsQueryable()
                .CreatePaginatedList<SparePartOrder>(model.PageNumber , model.PageSize , canToken);

            return Orders;
        }

        public async Task<Result<SparePartResponse>> GetSparePart( int Id , CancellationToken canToken)
        {
            var sparepart = await  context.SpareParts.FirstOrDefaultAsync(x => x.Id == Id , canToken);

            if (sparepart == null) { return Result.Failure<SparePartResponse>(SparePartError.SparePartNotFound); }

            var response = sparepart.Adapt<SparePartResponse>();

            return Result.Success(response);
        }

        public async Task<Result<List<SparePartOrder>>> GetUserOrders(string UserId, CancellationToken canToken)
        {
            var response = new List<SparePartOrder>();
            var user = await userManager.Users.Include(x => x.sparePartOrders).FirstOrDefaultAsync(x => x.Id == UserId, canToken);

            var validuser = user!.ValidUser(response);

            if(validuser.IsFalure) { return validuser!; }

           response =  user!.sparePartOrders.ToList();
           return Result.Success(response);
        }

        public async Task<Result<SparePartOrder>> OrderSparePart(string UserId, SparePartOrderDTO model , CancellationToken canToken)
        {
            var response = new SparePartOrder();
            var user = await userManager.Users.Include(x => x.sparePartOrders).FirstOrDefaultAsync(x => x.Id == UserId, canToken);

            var validuser = user!.ValidUser(response);

            if (validuser.IsFalure) { return validuser!; }

            var newsparePart = model.Adapt<SparePartOrder>();
            user!.sparePartOrders.Add(newsparePart);
            await context.SaveChangesAsync();
            return Result.Success(response);
        }

        public async Task<Result<SparePartOrder>> UpdateOrder(string UserId, UpdateSparePartOrder model , CancellationToken canToken)
        {
            var response = new SparePartOrder();
            var user = await userManager.Users.Include(x => x.sparePartOrders).FirstOrDefaultAsync(x => x.Id == UserId, canToken);

            var validuser = user!.ValidUser(response);
            if (validuser.IsFalure) { return validuser!; }

            var Order = user.sparePartOrders.FirstOrDefault(x => x.Id == model.OrderId);

            if(Order == null) { return Result.Failure<SparePartOrder>(SparePartError.OrderNotFound); }

            return Result.Success(response);
        }

        public async Task<Result<SparePartResponse>> UpdateSparePart(UpdateSparePart model , CancellationToken canToken)
        {
            var SparePart = await context.SpareParts.FirstOrDefaultAsync(x => x.Id == model.Id , canToken);

            if (SparePart == null) { return Result.Failure<SparePartResponse>(SparePartError.SparePartNotFound); }

            model.Adapt(SparePart);
            await context.SaveChangesAsync(canToken);

            var response = SparePart.Adapt<SparePartResponse>();
            return Result.Success(response);
        }
    }
}
