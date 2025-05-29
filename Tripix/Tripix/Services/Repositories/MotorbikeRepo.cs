using Mapster;
using Microsoft.EntityFrameworkCore;
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
            if (model.VehicleImages == null || model.VehicleImages.Count == 0)
            {
                return Result.Failure<Motorbikeresponse>(VehicleErrors.ImagesNotFound);
            }

            using var Transaction = await context.Database.BeginTransactionAsync();

            try
            {

                var newmotorbike = model.Adapt<Motorbikes>();
                context.Vehicles.Add(newmotorbike);
                await context.SaveChangesAsync();

                foreach (var image in model.VehicleImages)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.MotorbikeImageURL}/{image.FileName}");

                    using (FileStream Stream = new(path, FileMode.Create))
                    {
                        await image.CopyToAsync(Stream);
                    }

                    newmotorbike.VehicleImages.Add(new VehicleImage()
                    {
                        ImageUrl = $"{Urls.MotorbikeImageURL}/{image.FileName}",
                    });
                }
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

        public async Task<Result> DeleteMotorbike ( int Id )
        {
            var motorbikes = await context.Vehicles.OfType<Motorbikes>().FirstOrDefaultAsync(x => x.Id == Id);

            if (motorbikes is null) { return Result.Failure(VehicleErrors.VehicleNotFound); }

            context.Vehicles.Remove(motorbikes);
            await context.SaveChangesAsync();
            return Result.Success();
        }

        public async Task<PaginatedList<Motorbikeresponse>> GetAll ( RequestFilter filters, CancellationToken cenToken )
        {
            var response = await context.Vehicles.OfType<Motorbikes>()
                .AsNoTracking()
                .ApplyFilter<Motorbikes>(filters.SearchValues)
                .ProjectToType<Motorbikeresponse>()
                .CreatePaginatedList<Motorbikeresponse>(filters.PageNumber, filters.PageSize, cenToken);

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
                .FirstOrDefaultAsync(x => x.Id == model.Id);

            if (Motorbike is null) { return Result.Failure<Motorbikeresponse>(VehicleErrors.VehicleNotFound); }

            model.Adapt(Motorbike);
            await context.SaveChangesAsync();

            var response = Motorbike.Adapt<Motorbikeresponse>();
            return Result.Success(response);
        }
    }
}
