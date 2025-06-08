using Tripix.Abstractions;

namespace Tripix.Errors
{
    public class HelpooErrors
    {
        public static readonly Error OrderNotFound = new("Order Not Found", "This Order Not Found", StatusCodes.Status400BadRequest); 
    }
}
