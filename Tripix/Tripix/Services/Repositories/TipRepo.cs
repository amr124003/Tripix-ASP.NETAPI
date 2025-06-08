using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OpenQA.Selenium.DevTools.V132.Storage;
using RTools_NTS.Util;
using System.Runtime.CompilerServices;
using System.Transactions;
using Tripix.Abstractions;
using Tripix.Abstractions.Consts;
using Tripix.Context;
using Tripix.Contracts.Common;
using Tripix.Contracts.Tips;
using Tripix.Entities;
using Tripix.Errors;
using Tripix.Extentions;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Services.Repositories
{
    public class TipRepo : ITip
    {
        private readonly ApplicationDbcontext context;
        private readonly UserManager<ApplicationUser> userManger;

        public TipRepo(ApplicationDbcontext context , UserManager<ApplicationUser> userManger)
        {
            this.context = context;
            this.userManger = userManger;
        }
        public async Task<Result<Tip>> AddTip(AddTipDTO model, CancellationToken canToken = default)
        {
            if (model.Image == null || model.Image.Length == 0) { return Result.Failure<Tip>(TipError.ImageNotFound); }

             using var Transaction = context.Database.BeginTransaction();

            try
            {
                var newTip = model.Adapt<Tip>();

                var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.TipImages}{model.Image.FileName}");

                using (var Stream = new FileStream(path , FileMode.Create))
                {
                    await model.Image.CopyToAsync(Stream , canToken);
                }

                newTip.Image = $"{Urls.TipImages}{model.Image.FileName}";

                await context.Tips.AddAsync(newTip , canToken);
                await context.SaveChangesAsync(canToken);
                await Transaction.CommitAsync(canToken);
                return Result.Success(newTip);
            }
            catch
            {
                await Transaction.RollbackAsync(canToken);
                return Result.Failure<Tip>(TipError.ErrorOnAdd);
            }
        }

        public async Task<Result> CommentToTip(string UserId , CommentDto model, CancellationToken canToken = default)
        {
            var user = await userManger.Users.FirstOrDefaultAsync(x => x.Id == UserId , canToken);

            var validuser = user!.ValidUser();
            if (validuser.IsFalure) { return validuser; }

            var Tip = await  context.Tips.FirstOrDefaultAsync(x => x.Id == model.TipId , canToken);

            if (Tip == null) { return Result.Failure(TipError.TipNotFound); }

            var newComment = new TipComments()
            {
                Text = model.Text,
                TipId = model.TipId
            };

            user!.TipComments.Add(newComment);
            await context.SaveChangesAsync(canToken);
            return Result.Success();
        }

        public async Task<Result> DeleteComment(int Id, CancellationToken canToken = default)
        {
            var comment = await context.TipComments.FirstOrDefaultAsync(x => x.Id == Id, canToken);

            if(comment == null) { return Result.Failure(TipError.CommentNotFound); }

            context.TipComments.Remove(comment);
            await context.SaveChangesAsync(canToken);
            return Result.Success();
        }

        public async Task<Result> DeleteComment(string UserId, int Id, CancellationToken canToken = default)
        {
            var user = await userManger.Users.Include(x => x.TipComments).FirstOrDefaultAsync(x => x.Id == UserId, canToken);

            var validuser = user.ValidUser();
            if(validuser.IsFalure) { return validuser; }

            var comment = user.TipComments.FirstOrDefault(x => x.Id == Id);

            if(comment == null) { return Result.Failure(TipError.CommentNotFound); }
            context.TipComments.Remove(comment);
            await context.SaveChangesAsync(canToken);
            return Result.Success();
        }

        public async Task<Result> DeleteTip(int Id, CancellationToken canToken = default)
        {
            var tip = await context.Tips.FirstOrDefaultAsync(x => x.Id == Id, canToken);

            if (tip == null) { return Result.Failure(TipError.TipNotFound);}
            context.Tips.Remove(tip);
            await context.SaveChangesAsync(canToken);
            return Result.Success();
        }

        public async Task<Result> DislikeTip(string UserId , int Id, CancellationToken canToken = default)
        {
            var user = await userManger.Users.Include(x => x.TipComments).FirstOrDefaultAsync(x => x.Id == UserId, canToken);

            var validuser = user.ValidUser();
            if (validuser.IsFalure) { return validuser; }

            var Tip = await context.Tips.FirstOrDefaultAsync(x => x.Id == Id, canToken);

            if (Tip == null) { return Result.Failure(TipError.TipNotFound); }

            var lovedtip = new LovedTips()
            {
                TipId = Tip.Id
            };

            user.LovedTips.Add(lovedtip);
            Tip.DisLikes++;
            await context.SaveChangesAsync(canToken);
            return Result.Success();
        }

        public async Task<Result<Tip>> GetTip(int id, CancellationToken canToken = default)
        {
            var tip = await context.Tips.FirstOrDefaultAsync(x => x.Id ==  id, canToken);

            if(tip == null) { return Result.Failure<Tip>(TipError.TipNotFound); }

            return Result.Success(tip);
        }

        public async Task<PaginatedList<Tip>> GetTips(RequestFilter model, CancellationToken canToken = default)
        {
            var tips = await context.Tips
                .CreatePaginatedList<Tip>(model.PageNumber, model.PageSize, canToken);

            return tips;
        }

        public async Task<Result> LikeTip(string UserId , int Id, CancellationToken canToken = default)
        {
            var user = await  userManger.Users.FirstOrDefaultAsync(x => x.Id == UserId, canToken);

            var validuser = user!.ValidUser();
            if (validuser.IsFalure) { return validuser; }

            var tip = await context.Tips.FirstOrDefaultAsync(x => x.Id == Id, canToken);
            if(tip == null) {  return Result.Failure(TipError.TipNotFound); }

            tip.DisLikes++;
            await context.SaveChangesAsync(canToken);
            return Result.Success();
        }

        public async Task<Result> UpdateComment(string UserId , UpdateCommentDTO model, CancellationToken canToken = default)
        {
            var user = await userManger.Users.Include(x => x.TipComments).FirstOrDefaultAsync(x => x.Id == UserId, canToken);

            var validuser = user!.ValidUser();
            if (validuser.IsFalure) { return validuser; }

            var comment = user.TipComments.FirstOrDefault(x => x.Id == model.CommentId);

            if(comment == null ) { return Result.Failure(TipError.CommentNotFound); }

            model.Adapt(comment);
            await context.SaveChangesAsync(canToken);
            return Result.Success();

        }

        public async Task<Result<Tip>> UpdateTip(UpdateTipDTO model, CancellationToken canToken = default)
        {
            var tip = await  context.Tips.FirstOrDefaultAsync(x => x.Id == model.TipId , canToken);

            if(tip == null) { return Result.Failure<Tip>(TipError.TipNotFound); }

            model.Adapt(tip);
            await context.SaveChangesAsync(canToken);
            return Result.Success(tip);
        }
    }
}
