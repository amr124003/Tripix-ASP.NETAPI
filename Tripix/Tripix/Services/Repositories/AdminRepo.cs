using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Tripix.Abstractions;
using Tripix.Context;
using Tripix.Contracts.Admin;
using Tripix.Entities;
using Tripix.Errors;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Services.Repositories
{
    public class AdminRepo : IAdminRepo
    {
        private readonly ApplicationDbcontext context;
        private readonly UserManager<ApplicationUser> usermanger;
        private readonly RoleManager<IdentityRole> rolemanger;

        public AdminRepo (ApplicationDbcontext context ,  UserManager<ApplicationUser> usermanger , RoleManager<IdentityRole> rolemanger)
        {
            this.context = context;
            this.usermanger = usermanger;
            this.rolemanger = rolemanger;
        }
        public async Task<Result<AddAdminModel>> AddAdmin ( AddAdminModel model )
        {
            var admin = new ApplicationUser { Email = model.Email, UserName = model.Username };
            var result = await usermanger.CreateAsync(admin, model.Password);

            if (!result.Succeeded)
            {
                return Result.Failure<AddAdminModel>(UserErrors.ErrorInCreate);
            }

            await usermanger.AddToRoleAsync(admin, "Admin");
            return Result.Success(model);
        }

        public async Task<Result<AssignRoleModel>> AssignRole ( AssignRoleModel model )
        {
            var user = await usermanger.FindByEmailAsync(model.Email);

            if (user == null)
            {
                Result.Failure<AddAdminModel>(UserErrors.UserNotFound);
            }

            if (!await rolemanger.RoleExistsAsync(model.Role))
            {
                return Result.Failure<AssignRoleModel>(RolesErrors.RoleNotFound);
            }

            await usermanger.AddToRoleAsync(user, model.Role);
            return Result.Success(model);
        }

        public async Task<Result<List<GetAdminsResponse>>> GetAdmins ()
        {
            var admins = await usermanger.GetUsersInRoleAsync("Admin");

            var result = admins.Adapt<List<GetAdminsResponse>>();

            return Result.Success(result);
        }

        public List<ServiceResponse> GetServiceBookings()
        {
            var Response = new List<ServiceResponse>(); 

            Response.AddRange(context.HelpooOrders.Select(x => new ServiceResponse
            {
                BookId = x.Id,
                Name = x.UserName,
                Phone = x.UserPhone,
                Section = "HelpooOrder"
            }));

            Response.AddRange(context.RepairBookings.Select(x => new ServiceResponse
            {
                BookId = x.Id,
                Name = x.UserName,
                Phone = x.UserPhone,
                Section = "RepairBooking"
            }));

            Response.AddRange(context.WashBookings.Select(x => new ServiceResponse
            {
                BookId = x.Id,
                Name = x.UserName,
                Phone = x.UserPhone,
                Section = "WashBooking"
            }));

            Response.AddRange(context.CarRents.Select(x => new ServiceResponse
            {
                BookId = x.Id,
                Name = x.TenantName,
                Phone = x.TenantPhone,
                Section = "CarRent"
            }));

            return Response;

        }

        public bool DeleteBooking(DeleteServiceDTO model)
        {
            switch (model.Section)
            {
                case "HelpooOrder":
                    var helpOrder = context.HelpooOrders.FirstOrDefault(x => x.Id == model.BookId);
                    if (helpOrder != null)
                    {
                        context.HelpooOrders.Remove(helpOrder);
                        break;
                    }
                    return false;

                case "RepairBooking":
                    var repair = context.RepairBookings.FirstOrDefault(x => x.Id == model.BookId);
                    if (repair != null)
                    {
                        context.RepairBookings.Remove(repair);
                        break;
                    }
                    return false;

                case "WashBooking":
                    var wash = context.WashBookings.FirstOrDefault(x => x.Id == model.BookId);
                    if (wash != null)
                    {
                        context.WashBookings.Remove(wash);
                        break;
                    }
                    return false;

                case "CarRent":
                    var rent = context.CarRents.FirstOrDefault(x => x.Id == model.BookId);
                    if (rent != null)
                    {
                        context.CarRents.Remove(rent);
                        break;
                    }
                    return false;

                default:
                    return false;
            }

            context.SaveChanges();
            return true;
        }

    }
}
