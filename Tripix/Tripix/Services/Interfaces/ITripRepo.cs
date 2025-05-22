using Tripix.Abstractions;
using Tripix.Contracts.Trip;
using Tripix.View_Models;

namespace Tripix.Services.Interfaces
{
    public interface ITripRepo
    {
        public Task<Result<TripResponse>> OrderTripAsync ( string Token, OrderTripDTO orderTripDTO );
        public Task<Result<confirmDriverDTO>> ConfirmDriver ( confirmDriverDTO model );
        public Task<Result<TripResponse>> GetTripDetails ( GetTripDetails model );
    }
}
