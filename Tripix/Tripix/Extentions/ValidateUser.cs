using Tripix.Abstractions;
using Tripix.Abstractions.Consts;
using Tripix.Entities;
using Tripix.Errors;

namespace Tripix.Extentions
{
    public static class ValidateUser
    {
        public static Result<T?> ValidUser<T>(this ApplicationUser user , T? Returnedvalue = default)
        {
            if (user == null) return Result.Failure<T?>(UserErrors.UserNotFound);

            if(user.UserStatus == UserStatus.Panned) { return Result.Failure<T?>(UserErrors.PannedUser); }

            if(!user.EmailConfirmed) { return Result.Failure<T?>(UserErrors.UnconfirmedEmail); }

            if (user.IsDisabled) { return Result.Failure<T?>(UserErrors.DisabledUser); }

            return Result.Success(Returnedvalue);
        }

        public static Result ValidUser(this ApplicationUser user)
        {
            if (user == null) return Result.Failure(UserErrors.UserNotFound);

            if (user.UserStatus == UserStatus.Panned) { return Result.Failure(UserErrors.PannedUser); }

            if (!user.EmailConfirmed) { return Result.Failure(UserErrors.UnconfirmedEmail); }

            if (user.IsDisabled) { return Result.Failure(UserErrors.DisabledUser); }

            return Result.Success();
        }
    }
}
