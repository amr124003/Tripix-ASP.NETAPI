using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using Tripix.Abstractions;
using Tripix.Abstractions.Consts;
using Tripix.Authentication;
using Tripix.Context;
using Tripix.Contracts.Trip;
using Tripix.Entities;
using Tripix.Errors;
using Tripix.Hubs;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Services.Repositories
{
    public class TripRepo : ITripRepo
    {
        private readonly ApplicationDbcontext context;
        private readonly UserManager<ApplicationUser> usermanger;
        private readonly IJwtProvider jwtProvider;
        private readonly IHubContext<RideHub> hubcontext;

        public TripRepo ( ApplicationDbcontext context, UserManager<ApplicationUser> usermanger, IJwtProvider jwtProvider, IHubContext<RideHub> hubcontext )
        {
            this.context = context;
            this.usermanger = usermanger;
            this.jwtProvider = jwtProvider;
            this.hubcontext = hubcontext;
        }

        public async Task<Result> CancelTrip ( string UserId , int TripId)
        {
            var User = await usermanger.Users.FirstOrDefaultAsync(x => x.Id == UserId);

            if(User == null) { return Result.Failure(UserErrors.UserNotFound); }

            if(User.IsDisabled) { return Result.Failure(UserErrors.DisabledUser); }

            if(!User.EmailConfirmed) { return Result.Failure(UserErrors.UnconfirmedEmail); }

            var trip = User.Trips.FirstOrDefault(x => x.Id == TripId);

            if(trip == null) { return Result.Failure(TripErrors.TripNotFound); }

            trip.Status = TripStatus.Cancelled;
            await context.SaveChangesAsync();
            return Result.Success();
        }

        public async Task<Result<confirmDriverDTO>> ConfirmDriver ( confirmDriverDTO model )
        {
            var trips = context.Trips
                .Where(x => x.Phonenumber == model.PhoneNumber)
                .ToList();


            if (trips == null || !trips.Any())
                return Result.Failure<confirmDriverDTO>(TripErrors.TripNotFound);


            if (trips.Any(x => x.Status == TripStatus.InProgress))
                return Result.Failure<confirmDriverDTO>(TripErrors.TripAlreadyinProgress);


            if (trips.Any(x => x.Status == TripStatus.Cancelled))
                return Result.Failure<confirmDriverDTO>(TripErrors.TripCancelled);


            var firstTrip = trips.First();

            model.DestinationLatitude = firstTrip.DestinationLocation?.Latitude ?? 0;
            model.DestinationLongitude = firstTrip.DestinationLocation?.Longitude ?? 0;
            model.FirstName = firstTrip.FirstName;
            model.TripId = firstTrip.Id;

            // Notify driver
            await hubcontext.Clients.Group($"Driver {model.DriverId}")
                .SendAsync("DriverConfirmed", model);

            // Update all trips in memory
            foreach (var trip in trips)
            {
                trip.Status = TripStatus.InProgress;
                trip.Price = model.Price;
                await context.SaveChangesAsync();
            }
            return Result.Success(model);
        }

        public async Task<Result<TripResponse>> GetTripDetails ( GetTripDetails model )
        {
            var tripRes = new TripResponse();
            var Trip = context.Trips.FirstOrDefault(t => t.Id == model.TripId);

            if (Trip == null) { return Result.Failure<TripResponse>(TripErrors.TripNotFound); }

            if (Trip.Status == TripStatus.Cancelled) { return Result.Failure<TripResponse>(TripErrors.TripCancelled); }

            tripRes = Trip.Adapt<TripResponse>();
            tripRes.DriverId = model.DriverId;

            return Result.Success(tripRes);
        }

        public async Task<Result<TripResponse>> OrderTripAsync ( string Token, OrderTripDTO orderTripDTO )
        {
            var tripResponse = new TripResponse();

            var userID = jwtProvider.ValidateToken(Token);

            var user = await usermanger.FindByIdAsync(userID);

            if (user == null)
            {
                return Result.Failure<TripResponse>(UserErrors.UserNotFound);
            }

            var Trip = orderTripDTO.Adapt<Trip>();
            Trip.UserId = userID;
            Trip.FirstName = user.Name;
            Trip.Phonenumber = user.PhoneNumber;



            user.Trips.Add(Trip);
            await usermanger.UpdateAsync(user);

            tripResponse.UserName = user.Name!;
            tripResponse.UserId = user.Id;
            tripResponse.PhoneNumber = user.PhoneNumber!;
            tripResponse.Status = Trip.Status.ToString();
            tripResponse.TripId = Trip.Id;
            tripResponse.PickupLatitude = orderTripDTO.PickupLatitude;
            tripResponse.PickupLongitude = orderTripDTO.PickupLongitude;
            tripResponse.DestinationLatitude = orderTripDTO.DestinationLatitude;
            tripResponse.DestinationLongitude = orderTripDTO.DestinationLongitude;
            tripResponse.TripDate = orderTripDTO.TripDate;

            return Result.Success<TripResponse>(tripResponse);
        }
    }
}
