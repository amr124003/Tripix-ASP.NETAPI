using Tripix.Abstractions;
using Tripix.Contracts.Admin;
using Tripix.View_Models;

namespace Tripix.Services.Interfaces
{
    public interface IAdminRepo
    {
        public Task<Result<AssignRoleModel>> AssignRole ( AssignRoleModel model);
        public Task<Result<AddAdminModel>> AddAdmin ( AddAdminModel model );
        public Task<Result<List<GetAdminsResponse>>> GetAdmins ();
    }
}
