using Microsoft.AspNetCore.SignalR;
using Tripix.Authentication;
using Tripix.Entities;
using Tripix.Services;

namespace Tripix.Hubs
{
    public class RideHub : Hub
    {
        private readonly IDriverRepo driverRepo;
        private readonly IJwtProvider jwtprovider;

        public RideHub ( IDriverRepo DriverRepo, IJwtProvider jwtprovider )
        {
            driverRepo = DriverRepo;
            this.jwtprovider = jwtprovider;
        }
        public override async Task OnConnectedAsync ()
        {
            var httpContext = Context.GetHttpContext();
            var token = httpContext.Request.Query["access_token"].FirstOrDefault();
            if (token != null)
            {
                var driverID = jwtprovider.ValidateToken(token);

                await driverRepo.MakeMeOnlineAsync(driverID, Context.ConnectionId);

                await Groups.AddToGroupAsync(Context.ConnectionId, $"Driver {driverID}");
            }

            await base.OnConnectedAsync();
        }

        public async Task UpdateLocation ( DriverLocation locationDto )
        {
            var httpContext = Context.GetHttpContext();
            var token = httpContext.Request.Query["access_token"].FirstOrDefault();

            if (token != null)
            {
                var driverID = jwtprovider.ValidateToken(token);

                await driverRepo.UpdateDriverLocationAsync(driverID, locationDto);
            }
        }


        public override async Task OnDisconnectedAsync ( Exception ex )
        {
            var httpContext = Context.GetHttpContext();
            var token = httpContext.Request.Query["access_token"].FirstOrDefault();

            if (token != null)
            {
                var driverId = jwtprovider.ValidateToken(token);

                if (driverId != null)
                {
                    var Res = await driverRepo.MakeMeOfflineAsync(driverId);

                    if (Res)
                    {
                        await Groups.RemoveFromGroupAsync(Context.ConnectionId, $"Driver {driverId}");
                    }
                }
            }
            await base.OnDisconnectedAsync(ex);
        }
    }
}
