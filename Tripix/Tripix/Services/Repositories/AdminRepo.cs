using Mapster;
using Microsoft.AspNetCore.Identity;
using Tripix.Abstractions;
using Tripix.Contracts.Admin;
using Tripix.Entities;
using Tripix.Errors;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Services.Repositories
{
    public class AdminRepo : IAdminRepo
    {
        private readonly UserManager<ApplicationUser> usermanger;
        private readonly RoleManager<IdentityRole> rolemanger;

        public AdminRepo (UserManager<ApplicationUser> usermanger , RoleManager<IdentityRole> rolemanger)
        {
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
    }
}
