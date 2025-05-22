using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Tripix.Abstractions;
using Tripix.Abstractions.Consts;
using Tripix.Context;
using Tripix.Contracts.Trip;
using Tripix.Contracts.User;
using Tripix.Entities;
using Tripix.Errors;
using Tripix.Hubs;
using Tripix.Services.Interfaces;

namespace Tripix.Services.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly UserManager<ApplicationUser> usermanger;
        private readonly ApplicationDbcontext context;
        private readonly IHubContext<RideHub> hubcontext;

        public UserRepo ( UserManager<ApplicationUser> usermanger, ApplicationDbcontext context, IHubContext<RideHub> hubcontext )
        {
            this.usermanger = usermanger;
            this.context = context;
            this.hubcontext = hubcontext;
        }

        public async Task<Result<UserFinalTrip>> GetTripDetails ( GetTripDetails model )
        {
            var userfinalTripResponse = new UserFinalTrip();

            var Trip = context.Trips.FirstOrDefault(x => x.Id == model.TripId);

            var Driver = context.Drivers.FirstOrDefault(x => x.Id == model.DriverId);

            if (Trip == null) { return Result.Failure<UserFinalTrip>(TripErrors.TripNotFound); }

            if (Driver == null) { return Result.Failure<UserFinalTrip>(DriverErrors.DriverNotFound); }

            if (Driver.Status == DriverStatus.Panned) { return Result.Failure<UserFinalTrip>(DriverErrors.PanneddDriver); }

            userfinalTripResponse.DistinationLatitude = Trip.DestinationLocation.Latitude;
            userfinalTripResponse.DistinationLongitude = Trip.DestinationLocation.Longitude;
            userfinalTripResponse.PickupLatitude = Trip.PickupLocation.Latitude;
            userfinalTripResponse.PickupLongitude = Trip.PickupLocation.Longitude;
            userfinalTripResponse.DriverLatitude = Driver.Location.Latitude;
            userfinalTripResponse.DriverId = Driver.Id;
            userfinalTripResponse.DriverLongitude = Driver.Location.Longitude;
            userfinalTripResponse.DriverPhoneNumber = Driver.PhoneNumber;
            userfinalTripResponse.DriverName = Driver.UserName;
            userfinalTripResponse.Price = Trip.Price;

            return Result.Success(userfinalTripResponse);
        }

        public async Task<string> GetUserPhoneNumber ( string UserId )
        {
            var user = await usermanger.FindByIdAsync(UserId);

            if (user == null) { return null; }

            if (user.UserStatus == UserStatus.Panned) { return null; }

            return user.PhoneNumber;
        }

        public async Task<bool> MakeUserOffline ( string UserId )
        {
            var user = await usermanger.FindByIdAsync(UserId);

            if (user == null) { return false; }

            if (user.UserStatus == UserStatus.Panned) { return false; }

            user.UserStatus = UserStatus.Offline;
            await usermanger.UpdateAsync(user);

            return true;
        }

        public async Task<bool> MakeUserOnline ( string UserId, string ConnectionId )
        {
            var user = await usermanger.FindByIdAsync(UserId);

            if (user == null) { return false; }

            if (user.UserStatus == UserStatus.Panned) { return false; }

            user.UserStatus = UserStatus.Online;
            user.ConnectionId = ConnectionId;
            await usermanger.UpdateAsync(user);

            return true;
        }

        public async Task<bool> RemoveTrip ( string PhoneNumber )
        {
            var Trip = context.Trips.FirstOrDefault(x => x.Phonenumber == PhoneNumber);

            if (Trip == null) { return false; }

            context.Trips.Remove(Trip);
            context.SaveChanges();
            return true;
        }

        public async Task<Result> SendMessage ( UserSendMSGDTO model )
        {
            var driver = await usermanger.FindByIdAsync(model.DriverId);

            if (driver == null) { return Result.Failure(UserErrors.UserNotFound); }

            var driverinfo = context.Drivers.FirstOrDefault(x => x.Id == model.DriverId);

            if(driverinfo.Status == DriverStatus.Panned) { return Result.Failure(DriverErrors.PanneddDriver); }

            await hubcontext.Clients.Group($"Driver {model.DriverId}")
                .SendAsync("UserMSG", new { model.Message });
            return Result.Success();
        }
    }
}
