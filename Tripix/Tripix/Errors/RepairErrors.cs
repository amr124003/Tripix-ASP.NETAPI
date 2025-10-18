using Tripix.Abstractions;

namespace Tripix.Errors
{
    public static  class RepairErrors
    {
        public static readonly Error TurnNotfound = new("Turn Not Found" , "This Turn Not Found" , StatusCodes.Status400BadRequest);
    }
}
