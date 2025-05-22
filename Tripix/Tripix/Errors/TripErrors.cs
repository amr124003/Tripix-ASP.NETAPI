using Tripix.Abstractions;

namespace Tripix.Errors
{
    public static class TripErrors
    {
        public static readonly Error TripNotFound = new Error( "Trip not found" , "This Trip Not Found" , StatusCodes.Status404NotFound );
        public static readonly Error TripAlreadyExists = new Error ( "Trip exists" , "This Trip Is Already Exist" , StatusCodes.Status400BadRequest );
        public static readonly Error TripOrderFailed =  new Error ("Trip  failed" , "Order Trip Failed" , StatusCodes .Status400BadRequest );
        public static readonly Error TripCancelled = new Error("Trip Cancelled", "This Is Cancelled", StatusCodes.Status404NotFound);
        public static readonly Error TripAlreadyinProgress = new Error("Trip InProgress", "This Trip Is Already In Progress", StatusCodes.Status208AlreadyReported);
    }
}
