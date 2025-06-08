using Tripix.Abstractions;

namespace Tripix.Errors
{
    public static class CarRentError
    {
        public static readonly Error ImageNotFound = new("Image Not Found", "Can't Add Car For Rent Without Image", StatusCodes.Status400BadRequest);

        public static readonly Error CarforRentNotfound = new("Car Not Found", "This Car Not Found", StatusCodes.Status400BadRequest);

        public static readonly Error CarIsRented = new("Car Is Rented", "This Car Is Already Rented", StatusCodes.Status400BadRequest);

        public static readonly Error RentNotFound = new("Turn Not Found", "This Turn Not Found", StatusCodes.Status400BadRequest);

    }
}
