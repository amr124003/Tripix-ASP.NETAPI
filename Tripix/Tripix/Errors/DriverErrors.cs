using Tripix.Abstractions;

namespace Tripix.Errors
{
    public static class DriverErrors
    {
        public static readonly Error DriverNotFound = new("User Not Found", "This Credentials Not Found", StatusCodes.Status400BadRequest);

        public static readonly Error UnconfirmedEmail = new("Unconfirmed Email", "You Need To Confirm Your Email", StatusCodes.Status400BadRequest);

        public static readonly Error PanneddDriver = new("Panned User", "This Credentials Are Panned", StatusCodes.Status400BadRequest);

        public static readonly Error FaceIdNotFound = new("FaceId Not Found", "Driver Can't Be Added Without FaceId", StatusCodes.Status400BadRequest);

        public static readonly Error DriverLicenseNotFound = new("Driver License Not Found", "Driver Can't Add Without Driver License", StatusCodes.Status400BadRequest);

        public static readonly Error CarLicenseNotFound = new("Car License Not Found", "Driver Can't Add Without Car License", StatusCodes.Status400BadRequest);

        public static readonly Error CarLicenseImageMaybeNotFound = new("Front Or Back License Not Found", "Front And Back Needed With Driver", StatusCodes.Status400BadRequest);

        public static readonly Error CreminalRecordNotFound = new("Creminal Record Not Found", "Driver Can't Add Without Creminal Record", StatusCodes.Status400BadRequest);

        public static readonly Error DriverAddedError = new("Driver Can't Added", "Error Occuerd During Add Driver", StatusCodes.Status400BadRequest);

        public static readonly Error CarImagesNotFound = new("Car Images Not Found", "Driver Can't Added Without Car Images", StatusCodes.Status400BadRequest);

        public static readonly Error DriverImageNotFound = new("Driver Image Not Found" , "Driver Can't Added Without Image" , StatusCodes.Status400BadRequest);

        public static readonly Error AlreadyConfirmedDriver = new("AlreadyConfirmedDriver", "This Driver Already Confirmed", StatusCodes.Status409Conflict);

        public static readonly Error RejectedDriver = new("RejectedDriver", "This Driver Rejected", StatusCodes.Status409Conflict);
    }
}
