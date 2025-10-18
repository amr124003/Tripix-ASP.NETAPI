using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Options;
using Tripix.Authentication;
using Tripix.Context;
using Tripix.Contracts.Authentication;
using Tripix.Entities;
using Tripix.Hubs;
using Tripix.Services.Interfaces;

namespace Tripix.Services.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbcontext context;
        private readonly IHttpContextAccessor httpcontext;
        private readonly UserManager<ApplicationUser> usermanger;
        private readonly SignInManager<ApplicationUser> signinmanger;
        private readonly RoleManager<IdentityRole> rolemanger;
        private readonly IOptions<JwtOptions> options;
        private readonly IHubContext<RideHub> ridecontext;
        private readonly IHubContext<UserHub> hubContext;
        private readonly IDistributedCache cache;
        private readonly HttpClient httpClient;

        public IAdminRepo adminService { get; }

        public IJwtProvider jwtProvider { get; }

        public IAuthService authService { get; }

        public IBlog BlogService { get; }

        public IDriverRepo driverService { get; }

        public ITripRepo tripService { get; }

        public IUserRepo userService { get; }

        public ICarRepo carRepo { get; }

        public IRent RentService { get; }

        public IRepair repairService { get; }

        public IMotorbike MotorbikeRepo { get; }

        public IVehicle VehicleRepo { get; }

        public IElectricCar ElectricCarRepo { get; }

        public IWash WashServiceRepo { get; }

        public Ihelpoo HelpooService { get; }

        public IDAService DAService { get; }

        public IEvent EventRepo { get; }

        public IJOP JopRepo { get; }

        public ISparePart SparePartRepo {  get; }

        public ITip TipRepo {  get; }

        public UnitOfWork ( ApplicationDbcontext context, UserManager<ApplicationUser> usermanger, SignInManager<ApplicationUser> signinmanger, RoleManager<IdentityRole> rolemanger, IOptions<JwtOptions> options, IHttpContextAccessor httpcontext, IHubContext<UserHub> hubContext, IHubContext<RideHub> ridecontext, IDistributedCache cache  , HttpClient httpClient)
        {
            adminService = new AdminRepo(context,usermanger, rolemanger);
            jwtProvider = new JwtProvider(options);
            authService = new AuthService(usermanger, signinmanger, context, jwtProvider, httpcontext, cache , httpClient);
            BlogService = new BlogRepo(context);
            driverService = new DriverRepo(context, usermanger, jwtProvider, hubContext, cache , rolemanger);
            tripService = new TripRepo(context, usermanger, jwtProvider, ridecontext);
            userService = new UserRepo(usermanger, context, ridecontext);
            carRepo = new CarRepo(context, usermanger);
            RentService = new RentRepo(context, usermanger);
            repairService = new RepairRepo(context, usermanger);
            MotorbikeRepo = new MotorbikeRepo(context);
            VehicleRepo = new VehicleRepo(context, usermanger);
            ElectricCarRepo = new ElectricCarRepo(context);
            WashServiceRepo = new WashRepo(usermanger, context);
            HelpooService = new HelpooRepo(usermanger, context);
            DAService = new DAServices(context , usermanger);
            EventRepo = new EventRepo(context, usermanger);
            JopRepo = new JopRepo(context , usermanger);
            SparePartRepo = new SparePartRepo(context, usermanger);
            TipRepo = new TipRepo(context , usermanger);


            this.context = context;
            this.usermanger = usermanger;
            this.signinmanger = signinmanger;
            this.rolemanger = rolemanger;
            this.options = options;
            this.httpcontext = httpcontext;
            this.ridecontext = ridecontext;
            this.cache = cache;
            this.httpClient = httpClient;
            this.hubContext = hubContext;
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
