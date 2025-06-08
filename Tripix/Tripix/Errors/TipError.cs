using Tripix.Abstractions;

namespace Tripix.Errors
{
    public static class TipError
    {
        public static Error ImageNotFound = new("Image Not Found", "You Can't Add Tip Without Image", StatusCodes.Status400BadRequest);

        public static Error TipNotFound = new("Tip Not Found", "This Tip Not Found", StatusCodes.Status404NotFound);

        public static Error ErrorOnAdd = new("Error On Add", "Error Occured On Add This Tip", StatusCodes.Status400BadRequest);

        public static Error CommentNotFound = new("Comment Not Found", "This Comment Not Found", StatusCodes.Status404NotFound);
    }
}
