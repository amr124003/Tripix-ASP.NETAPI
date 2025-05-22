using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Caching.Distributed;
using Tripix.Authentication;
using Tripix.Context;
using Tripix.Entities;
using Tripix.Hubs;
using Tripix.Services.Interfaces;

namespace Tripix.Services.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbcontext context;
        private readonly IJwtProvider jwtprovider;
        private readonly IHttpContextAccessor httpcontext;
        private readonly IDistributedCache cache;
        private readonly IHubContext<UserHub> hubContext;
        private readonly IHubContext<RideHub> ridecontext;
        private readonly UserManager<ApplicationUser> usermanger;
        private readonly SignInManager<ApplicationUser> signinmanger;
        private readonly RoleManager<IdentityRole> rolemanger;

        public IAdminRepo adminService { get; }

        public IAuthService authService { get; }

        public IBlog BlogService { get; }

        public IDriverRepo driverService { get; }

        public ITripRepo tripService { get; }

        public IUserRepo userService { get; }

        public ICarRepo carRepo { get; }

        public IRent RentService { get; }

        public IRepair RepairService { get; }

        public UnitOfWork ( IAdminRepo adminService, IAuthService authService, IBlog blogService, IDriverRepo driverService, ITripRepo tripService, IUserRepo userService, ICarRepo carRepo, IRent rentService, IRepair repairService )
        {
            this.adminService = adminService;
            this.authService = authService;
            BlogService = blogService;
            this.driverService = driverService;
            this.tripService = tripService;
            this.userService = userService;
            this.carRepo = carRepo;
            RentService = rentService;
            RepairService = repairService;
        }

        public void Dispose ()
        {
            context.Dispose();
        }

        public Task<int> SavechangesAsync ()
        {
            return context.SaveChangesAsync();
        }
    }
}
