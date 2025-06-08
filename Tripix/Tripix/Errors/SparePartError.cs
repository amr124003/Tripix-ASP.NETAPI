using Tripix.Abstractions;

namespace Tripix.Errors
{
    public static class SparePartError
    {
        public static readonly Error ImagesNotFound = new("Images Not Found", "You Can't Add Spare Part Without Images", StatusCodes.Status400BadRequest);

        public static readonly Error ErrorOnAdd = new("Error On Add" , "Error Occured On Adding SparePart" , StatusCodes.Status400BadRequest);

        public static readonly Error OrderNotFound = new("Order Not Found", "This Order Not Found", StatusCodes.Status404NotFound);

        public static readonly Error SparePartNotFound = new("SparePart Not Found", "This SparePart Not Found", StatusCodes.Status404NotFound);
    }
}
