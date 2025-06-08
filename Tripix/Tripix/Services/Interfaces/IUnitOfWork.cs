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
        Ihelpoo HelpooService { get; }
        IWash WashServiceRepo { get; }
        ITripRepo tripService { get; }
        IUserRepo userService { get; }
        IElectricCar ElectricCarRepo { get; }
        ICarRepo carRepo { get; }
        IDAService DAService { get; }
        IRent RentService { get; }
        IRepair repairService { get; }
        IEvent EventRepo { get; }
        IJOP JopRepo { get; }
        ISparePart SparePartRepo { get; }

        Task<int> SavechangesAsync ();
    }
}
