using Tripix.Abstractions;

namespace Tripix.Errors
{
    public static class VehicleErrors
    {
        public static readonly Error VehicleNotFound = new("Product Not Found", "This Product Not Found", StatusCodes.Status404NotFound);

        public static readonly Error ImagesNotFound = new("Images Not Found", "Car Can't Be Created Without Images", StatusCodes.Status400BadRequest);

        public static readonly Error VehicleIsBooked = new("Vehicle Booked", "The Vehicle have been Booked", StatusCodes.Status400BadRequest);

        public static readonly Error VehicleCannotAdded = new("Vehcile Can't Added" , "Error Occured During Add This Vehicle" , StatusCodes.Status400BadRequest);
    }
}
