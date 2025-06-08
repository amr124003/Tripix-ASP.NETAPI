using Tripix.Abstractions;

namespace Tripix.Errors
{
    public static class JopErrors
    {
        public static readonly Error JopApplicationNotFound = new("Jop Applicaiton Not Found", "This Jop Application Not Found", StatusCodes.Status400BadRequest);

        public static readonly Error JopAlreadyAccpted = new("Jop Application Accepted", "This Jop Is Already Accepted", StatusCodes.Status409Conflict);

        public static readonly Error JopApplicationRejected = new("Jop Application Rejected" , "This Jop Application Is Already Rejected",StatusCodes.Status409Conflict);

        public static readonly Error JopNotFound = new("Jop Not Found" , "This Jop Not Found" , StatusCodes.Status400BadRequest);

        public static readonly Error CvNotFound = new("Cv Not Found" , "You Can't Apply Without Upload Cv" , StatusCodes.Status400BadRequest);

        public static readonly Error ErrorOnApply = new("Error On Apply Proccess", "Error Occured During Apply Proccess", StatusCodes.Status400BadRequest);
    }
}
