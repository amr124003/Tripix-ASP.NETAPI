using Microsoft.AspNetCore.SignalR;
using Tripix.Authentication;
using Tripix.Services.Interfaces;
using Tripix.Services.Repositories;

namespace Tripix.Hubs
{
    public class UserHub : Hub
    {
        private readonly IJwtProvider jwtprovider;
        private readonly IUnitOfWork unitOfWork;

        public UserHub (IJwtProvider jwtprovider,IUnitOfWork unitOfWork)
        {
            this.jwtprovider = jwtprovider;
            this.unitOfWork = unitOfWork;
        }

        public override async Task OnConnectedAsync ()
        {
            var httpContext = Context.GetHttpContext();
            var token = httpContext.Request.Query["access_token"].FirstOrDefault();
            if (token != null)
            {
                var UserId = jwtprovider.ValidateToken(token);

                var PhoneNumber = await unitOfWork.userService.GetUserPhoneNumber(UserId);

                var Res = await unitOfWork.userService.MakeUserOnline(UserId!,Context.ConnectionId);

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
                    var Res = await unitOfWork.userService.MakeUserOffline(UserId!);

                    if (Res)
                    {
                        var PhoneNumber = await unitOfWork.userService.GetUserPhoneNumber(UserId);
                        if (PhoneNumber != null)
                        {
                            await unitOfWork.userService.RemoveTrip(PhoneNumber);
                            await Groups.RemoveFromGroupAsync(Context.ConnectionId, $"User {PhoneNumber}");
                        }
                    }
                }
            }
            await base.OnDisconnectedAsync(ex);
        }
    }
}
