using Microsoft.AspNetCore.SignalR;
using Tripix.Authentication;
using Tripix.Services.Interfaces;
using Tripix.Services.Repositories;

namespace Tripix.Hubs
{
    public class UserHub : Hub
    {
        private readonly IJwtProvider jwtprovider;
        private readonly IUserRepo userRepo;

        public UserHub (IJwtProvider jwtprovider,IUserRepo userRepo)
        {
            this.jwtprovider = jwtprovider;
            this.userRepo = userRepo;
        }

        public override async Task OnConnectedAsync ()
        {
            var httpContext = Context.GetHttpContext();
            var token = httpContext.Request.Query["access_token"].FirstOrDefault();
            if (token != null)
            {
                var UserId = jwtprovider.ValidateToken(token);

                var PhoneNumber = await userRepo.GetUserPhoneNumber(UserId);

                var Res = await userRepo.MakeUserOnline(UserId!,Context.ConnectionId);

                if(Res)
                {
                    await Groups.AddToGroupAsync(Context.ConnectionId, $"User {PhoneNumber}");
                }
            }

            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync ( Exception ex )
        {
            var httpContext = Context.GetHttpContext();
            var token = httpContext.Request.Query["access_token"].FirstOrDefault();

            if (token != null)
            {
                var UserId = jwtprovider.ValidateToken(token);

                if (UserId != null)
                {
                    var Res = await userRepo.MakeUserOffline(UserId!);

                    if (Res)
                    {
                        var PhoneNumber = await userRepo.GetUserPhoneNumber(UserId);
                        if (PhoneNumber != null)
                        {
                            await userRepo.RemoveTrip(PhoneNumber);
                            await Groups.RemoveFromGroupAsync(Context.ConnectionId, $"User {PhoneNumber}");
                        }
                    }
                }
            }
            await base.OnDisconnectedAsync(ex);
        }
    }
}
