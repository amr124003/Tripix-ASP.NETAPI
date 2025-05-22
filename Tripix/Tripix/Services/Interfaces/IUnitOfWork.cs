namespace Tripix.Services.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IAdminRepo adminService { get; }
        IAuthService authService { get; }
        IBlog BlogService { get; }
        IDriverRepo driverService { get; }
        ITripRepo tripService { get; }
        IUserRepo userService { get; }
        ICarRepo carRepo { get; }
        IRent RentService { get; }
        IRepair RepairService { get; }

        Task<int> SavechangesAsync ();
    }
}
