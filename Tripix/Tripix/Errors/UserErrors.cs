using Tripix.Abstractions;

namespace Tripix.Errors
{
    public static class UserErrors
    {
        public static readonly Error InvalidCredentials = new("user invalid credential", "Invalid Email Or Password", StatusCodes.Status401Unauthorized);

        public static readonly Error DuplicatedEmail = new("Duplicated Email", "This Email Is Already Used", StatusCodes.Status409Conflict);

        public static readonly Error UserNotFound = new("User Not Found", "This Credentials Not Found", StatusCodes.Status400BadRequest);

        public static readonly Error UnconfirmedEmail = new("Unconfirmed Email", "You Need To Confirm Your Email", StatusCodes.Status400BadRequest);

        public static readonly Error DisabledUser = new("Disabled User", "This Credentials Are Disabled", StatusCodes.Status400BadRequest);

        public static readonly Error InvalidOTP = new("Invalid OTP", "Invalid OTP", StatusCodes.Status400BadRequest);

        public static readonly Error InvalidRoles = new("Invalid Roles", "This Role Isn't Exists", StatusCodes.Status400BadRequest);

        public static readonly Error PannedUser = new("User Panned" , "This User Has Been Panned" , StatusCodes.Status400BadRequest);

        public static readonly Error InActiveRefreshToken = new("InActive Refresh Token", "You Need To Login Now", StatusCodes.Status401Unauthorized);

        public static readonly Error Alreadyconfirmed = new("Already confirmed", "Email Is Already Confirmed", StatusCodes.Status400BadRequest);

        public static readonly Error DuplicatedPhone = new("Duplicated Phone", "This Phone Number Is Already Used", StatusCodes.Status409Conflict);

        public static readonly Error InvalidGoogleToken = new("Invalid Google Token", "This Token Not Valid You Can Try Another Account", StatusCodes.Status400BadRequest);

        public static readonly Error FailedToCreateUser = new("Failed To Create New User", "Can't Create New User", StatusCodes.Status400BadRequest);

        public static readonly Error InvalidEmail = new("Invalid Email", "This Email Isn't Valid", StatusCodes.Status400BadRequest);

        public static readonly Error ErrorInCreate = new Error("Create Error" , "Error In Create New Admin" , StatusCodes.Status400BadRequest);

        public static readonly Error ConfirmDatalikeYourCredentials = new("ConfirmDatalikeYourCredentials", "Confirm Data Must Be Like Your Credentials", StatusCodes.Status400BadRequest);

        public static readonly Error EmptyEmail = new("Empty Email", "You Can't Login Without Email", StatusCodes.Status400BadRequest);

        public static readonly Error InvalidFacebookToken = new("Invalid Facebook Token", "This Facebook Token Is Invalid", StatusCodes.Status400BadRequest);
    }
}
