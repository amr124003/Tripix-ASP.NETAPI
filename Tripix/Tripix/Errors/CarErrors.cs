using Tripix.Abstractions;

namespace Tripix.Errors
{
    public static class CarErrors
    {
        public static readonly Error CarNotFound = new("Product Not Found", "This Product Not Found", StatusCodes.Status404NotFound);
        public static readonly Error ImagesNotFound = new("Images Not Found", "Car Can't Be Created Without Images", StatusCodes.Status400BadRequest);
        public static readonly Error CarIsBooked = new("Car Booked", "The car have been Booked", StatusCodes.Status400BadRequest);
    }
}
