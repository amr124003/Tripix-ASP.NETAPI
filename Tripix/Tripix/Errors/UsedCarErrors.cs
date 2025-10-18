using Tripix.Abstractions;

namespace Tripix.Errors
{
    public static class UsedCarErrors
    {
        public static readonly Error ImagesNotFound = new("Images Not Found" , "You Can't Sell Car Without Images" , StatusCodes.Status400BadRequest);

        public static readonly Error ErrorOnSell = new("Error On Sell", "Error Occured On Sell Car", StatusCodes.Status400BadRequest);
    }
}
