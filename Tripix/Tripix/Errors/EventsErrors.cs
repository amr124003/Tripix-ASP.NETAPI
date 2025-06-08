using Tripix.Abstractions;

namespace Tripix.Errors
{
    public class EventsErrors
    {
        public static readonly Error ImageNotFound = new("Image Not Found", "Can't Add Event Without Image", StatusCodes.Status400BadRequest);

        public static readonly Error EventCannotAdded = new("Event Can't Added", "Error Occured In Add Event", StatusCodes.Status400BadRequest);

        public static readonly Error EventTicketNotFound = new("Event Ticket Not Found", "This Event Ticket Not Found", StatusCodes.Status400BadRequest);

        public static readonly Error EventNotFound = new("Event Not Found", "This Event Not Found", StatusCodes.Status400BadRequest);
    }
}
