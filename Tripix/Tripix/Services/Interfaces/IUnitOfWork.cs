using Tripix.Authentication;

namespace Tripix.Services.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAdminRepo adminService { get; }
        IAuthService authService { get; }
        IBlog BlogService { get; }
        IMotorbike MotorbikeRepo { get; }
        IJwtProvider jwtProvider { get; }
        IDriverRepo driverService { get; }
        IVehicle VehicleRepo { get; }
        IWash WashServiceRepo { get; }
        ITripRepo tripService { get; }
        IUserRepo userService { get; }
        IElectricCar ElectricCarRepo {  get; }
        ICarRepo carRepo { get; }
        IRent RentService { get; }
        IRepair repairService { get; }

        Task<int> SavechangesAsync ();
    }
}
