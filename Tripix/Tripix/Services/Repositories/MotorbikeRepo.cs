using Mapster;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Bcpg;
using RTools_NTS.Util;
using Tripix.Abstractions;
using Tripix.Abstractions.Consts;
using Tripix.Context;
using Tripix.Contracts.Car;
using Tripix.Contracts.Common;
using Tripix.Contracts.Motorbikes;
using Tripix.Entities;
using Tripix.Errors;
using Tripix.Extentions;
using Tripix.Services.Interfaces;

namespace Tripix.Services.Repositories
{
    public class MotorbikeRepo : IMotorbike
    {
        private readonly ApplicationDbcontext context;

        public MotorbikeRepo ( ApplicationDbcontext context )
        {
            this.context = context;
        }
        public async Task<Result<Motorbikeresponse>> AddMotorbike ( AddMotorbikeDTO model )
        {
            if (model.Images == null || model.Images.Count == 0)
            {
                return Result.Failure<Motorbikeresponse>(VehicleErrors.ImagesNotFound);
            }

            using var Transaction = await context.Database.BeginTransactionAsync();

            try
            {

                var newmotorbike = model.Adapt<Motorbikes>();
                

                foreach (var image in model.Images)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.MotorbikeImageURL}{image.FileName}");

                    using (FileStream Stream = new(path, FileMode.Create))
                    {
                        await image.CopyToAsync(Stream);
                    }

                    var imurl = $"{Urls.SaveMotorbikeImageUrl}{image.FileName}";

                    newmotorbike.VehicleImages.Add(new VehicleImage
                    {
                        ImageUrl = imurl ,
                    });
                }

                context.Vehicles.Add(newmotorbike);
                await context.SaveChangesAsync();
                await Transaction.CommitAsync();
                var response = newmotorbike.Adapt<Motorbikeresponse>();
                return Result.Success(response);
            }
            catch (Exception)
            {
                await Transaction.RollbackAsync();
                return Result.Failure<Motorbikeresponse>(VehicleErrors.VehicleCannotAdded);
            }
        }

        public async Task<Result> DeleteMotorbike ( int Id  , CancellationToken canToken)
        {
            var motorbikes = await context.Vehicles.OfType<Motorbikes>().FirstOrDefaultAsync(x => x.Id == Id);

            if (motorbikes is null) { return Result.Failure(VehicleErrors.VehicleNotFound); }

            using var Transaction = context.Database.BeginTransaction();

            try
            {
                if (motorbikes.VehicleImages.Count == 0 || motorbikes.VehicleImages != null)
                {
                    foreach (var image in motorbikes.VehicleImages.Select(x => x.ImageUrl))
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot{image}");

                        if (File.Exists(path))
                        {
                            File.Delete(path);
                        }
                    }
                }

                context.Vehicles.Remove(motorbikes);
                await context.SaveChangesAsync(canToken);
                await Transaction.CommitAsync(canToken);
                return Result.Success();
            }
            catch
            {
                await Transaction.RollbackAsync(canToken);
                return Result.Failure(VehicleErrors.VehicleNotFound);
            }
        }

        public async Task<PaginatedList<Motorbikeresponse>> GetAll (string UserId ,  RequestFilter filters, CancellationToken cenToken )
        {
            var likedvehciles = await context.FavouriteProducts
               .Where(f => f.UserId == UserId)
               .Select(f => f.VehicleId)
               .ToListAsync(cenToken);

            var response = await context.Vehicles.OfType<Motorbikes>()
                .AsNoTracking()
                .ApplyFilter<Motorbikes>(filters.SearchValues)
                .ProjectToType<Motorbikeresponse>()
                .CreatePaginatedList<Motorbikeresponse>(filters.PageNumber, filters.PageSize, cenToken);

            var likedIdsSet = likedvehciles.ToHashSet(); 

            foreach (var item in response.Items)
            {
                item.IsLiked = likedIdsSet.Contains(item.Id);
            }

            return response;
        }

        public async Task<List<BrandDto>> GetBrands ()
        {
            var res = context.Brands.Include(x => x.Models)
                .Where(x => x.VehicleType == vehicletype.Motorbike)
                .Adapt<List<BrandDto>>();

            return res;
        }

        public async Task<Result<Motorbikes>> GetById ( int Id )
        {
            var Motorbike = await context.Vehicles.OfType<Motorbikes>()
                .FirstOrDefaultAsync(x => x.Id == Id);

            if (Motorbike is null)
            {
                return Result.Failure<Motorbikes>(VehicleErrors.VehicleNotFound);
            }

            return Result.Success(Motorbike);
        }

        public async Task<Result<Motorbikeresponse>> UpdateMotorbike ( UpdateMotorbikeDTO model )
        {
            var Motorbike = await context.Vehicles.OfType<Motorbikes>()
                .Include(x => x.VehicleImages)
                .FirstOrDefaultAsync(x => x.Id == model.Id);

            if (Motorbike is null) { return Result.Failure<Motorbikeresponse>(VehicleErrors.VehicleNotFound); }

            if (model.Images == null || model.Images.Count == 0)
            {
                return Result.Failure<Motorbikeresponse>(VehicleErrors.ImagesNotFound);
            }

            using var Transaction = await context.Database.BeginTransactionAsync();

            try
            {
                if(Motorbike.VehicleImages.Count != 0 || Motorbike.VehicleImages == null)
                {
                    foreach(var image in Motorbike.VehicleImages!.Select(x => x.ImageUrl))
                    {
                        var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.BaseUrl}{image}");

                        if(File.Exists(path))
                        {
                            File.Delete(path);
                        }
                    }
                }

                var newmotorbike = model.Adapt<Motorbikes>();

                foreach (var image in model.Images)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.MotorbikeImageURL}{image.FileName}");

                    using (FileStream Stream = new(path, FileMode.Create))
                    {
                        await image.CopyToAsync(Stream);
                    }

                    newmotorbike.VehicleImages.Add(new VehicleImage()
                    {
                        ImageUrl = $"{Urls.SaveMotorbikeImageUrl}/{image.FileName}",
                    });
                }

                model.Adapt(Motorbike);
                await context.SaveChangesAsync();
                await Transaction.CommitAsync();
                var response = newmotorbike.Adapt<Motorbikeresponse>();
                return Result.Success(response);
            }
            catch (Exception)
            {
                await Transaction.RollbackAsync();
                return Result.Failure<Motorbikeresponse>(VehicleErrors.VehicleCannotUpdate);
            }
        }
    }
}
