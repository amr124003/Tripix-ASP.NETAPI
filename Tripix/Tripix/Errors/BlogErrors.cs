using Tripix.Abstractions;

namespace Tripix.Errors
{
    public static class BlogErrors
    {
        public static readonly Error BlogNotFound = new("Blog Not found", "This Blog Not Exists", StatusCodes.Status404NotFound);

        public static readonly Error ImageNotFound = new("Image Not found" , "Blog Can't Be Created Without Image" , StatusCodes.Status400BadRequest);

        public static readonly Error ErrorOnUpdate = new("Error On Update", "Error Occured during Update Blog", StatusCodes.Status400BadRequest);
    }
}
