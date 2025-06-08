using Tripix.Abstractions;
using Tripix.Contracts.Common;
using Tripix.Contracts.Event;
using Tripix.Entities;
using Tripix.View_Models;

namespace Tripix.Services.Interfaces
{
    public interface IEvent
    {
        public Task<Result<Event>> GetEvent ( int Id );
        public Task<Result<List<Event>>> GetEvents ();
        public Task<Result<Event>> AddEvent ( AddEventDTO model );
        public Task<Result> DeleteEvemt ( int Id );
        public Task<Result<Event>> UpdateEvent ( UpdateEventDTO model );
        public Task<Result> CancelTicket ( string UserId, int EventTicketId );
        public Task<Result<EventTickets>> UpdateTicket ( string UserId, UpdateTicketDTO model );
        public Task<Result<EventTickets>> BookingEventTicket ( string UserId, BookingEventDTO model );
        public Task<Result<EventTickets>> GetTicket ( string UserId, int TicketId );
        public Task<Result> DeleteTicket ( int TicketId );
        public Task<PaginatedList<EventTickets>> GetEventTicket ( RequestFilter filters, CancellationToken CanToken = default );
    }
}
