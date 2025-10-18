using Mapster;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Tripix.Abstractions;
using Tripix.Abstractions.Consts;
using Tripix.Context;
using Tripix.Contracts.Common;
using Tripix.Contracts.Event;
using Tripix.Entities;
using Tripix.Errors;
using Tripix.Extentions;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Services.Repositories
{
    public class EventRepo : IEvent
    {
        private readonly ApplicationDbcontext context;
        private readonly UserManager<ApplicationUser> usermanger;

        public EventRepo(ApplicationDbcontext context, UserManager<ApplicationUser> usermanger)
        {
            this.context = context;
            this.usermanger = usermanger;
        }
        public async Task<Result<Event>> AddEvent(AddEventDTO model)
        {
            if (model.Image == null || model.Image.Length == 0)
            {
                return Result.Failure<Event>(EventsErrors.ImageNotFound);
            }

            using var Transaction = context.Database.BeginTransaction();

            try
            {
                Event newEvent = model.Adapt<Event>();

                var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.EventImages}{model.Image.FileName}");

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await model.Image.CopyToAsync(stream);
                }

                newEvent.Image = $"{Urls.SaveEventImages}{model.Image.FileName}";

                var Hotels = await context.Hotels.Where(x => x.GovernateName == model.Governate).ToListAsync();

                newEvent.Hotels.AddRange(Hotels);

                await context.Events.AddAsync(newEvent);
                await context.SaveChangesAsync();
                await Transaction.CommitAsync();
                return Result.Success(newEvent);
            }
            catch
            {
                await Transaction.RollbackAsync();
                return Result.Failure<Event>(EventsErrors.EventCannotAdded);
            }
        }

        public async Task<Result<EventTickets>> BookingEventTicket(string UserId, BookingEventDTO model)
        {
            var user = await usermanger.Users.FirstOrDefaultAsync(user => user.Id == UserId);

            if (user == null) { Result.Failure<EventTickets>(UserErrors.UserNotFound); }

            if (user!.IsDisabled) { Result.Failure<EventTickets>(UserErrors.DisabledUser); }

            if (!user.EmailConfirmed) { Result.Failure<EventTickets>(UserErrors.UnconfirmedEmail); }

            var Event = await context.Events.FirstOrDefaultAsync(x => x.Id == model.EventId && x.Date >= DateTime.UtcNow);

            var newEventTicket = model.UserPhone != null ? model.Adapt<EventTickets>() : new EventTickets()
            {
                EventId = Event!.Id,
                UserName = user.Name,
                UserEmail = user.Email!,
                UserPhone = user.PhoneNumber,
            };

            newEventTicket.EventDate = Event!.Date;
            newEventTicket.EventAddress = Event.Location;

            user.EventTickets.Add(newEventTicket);
            await context.SaveChangesAsync();
            return Result.Success(newEventTicket);
        }

        public async Task<Result> CancelTicket(string UserId, int EventTicketId)
        {
            var user = await usermanger.Users.FirstOrDefaultAsync(user => user.Id == UserId);

            if (user == null) { Result.Failure<EventTickets>(UserErrors.UserNotFound); }

            if (user!.IsDisabled) { Result.Failure<EventTickets>(UserErrors.DisabledUser); }

            if (!user.EmailConfirmed) { Result.Failure<EventTickets>(UserErrors.UnconfirmedEmail); }

            var EventTicket = user.EventTickets.FirstOrDefault(x => x.Id == EventTicketId);

            if (EventTicket == null) { return Result.Failure<EventTickets>(EventsErrors.EventTicketNotFound); }

            user.EventTickets.Remove(EventTicket);
            await context.SaveChangesAsync();
            return Result.Success();
        }

        public async Task<Result> DeleteEvemt(int Id)
        {
            var Event = await context.Events.FirstOrDefaultAsync(x => x.Id == Id);

            if (Event == null) { return Result.Failure<Event>(EventsErrors.EventNotFound); }

            context.Events.Remove(Event);
            await context.SaveChangesAsync();
            return Result.Success();
        }

        public async Task<Result<Event>> GetEvent(int Id)
        {
            var Event = await context.Events
                .Include(x => x.Hotels)
                .FirstOrDefaultAsync(x => x.Id == Id && x.Date >= DateTime.UtcNow);

            if (Event == null) { return Result.Failure<Event>(EventsErrors.EventNotFound); }

            return Result.Success(Event);
        }

        public async Task<Result<List<Event>>> GetEvents()
        {
            var Events = await context.Events
                .Where(x => x.Date >= DateTime.UtcNow)
                .ToListAsync();

            return Result.Success(Events);
        }

        public async Task<Result<EventTickets>> GetTicket(string UserId, int TicketId)
        {
            var user = await usermanger.Users.Include(x => x.EventTickets).FirstOrDefaultAsync(user => user.Id == UserId);

            if (user == null) { Result.Failure<EventTickets>(UserErrors.UserNotFound); }

            if (user!.IsDisabled) { Result.Failure<EventTickets>(UserErrors.DisabledUser); }

            if (!user.EmailConfirmed) { Result.Failure<EventTickets>(UserErrors.UnconfirmedEmail); }

            var EventTicket = user.EventTickets.FirstOrDefault(x => x.Id == TicketId);

            if (EventTicket == null) { Result.Failure<EventTickets>(EventsErrors.EventTicketNotFound); }

            return Result.Success(EventTicket!);
        }

        public async Task<Result<Event>> UpdateEvent(UpdateEventDTO model)
        {
            var Event = await context.Events.Include(x => x.Hotels).FirstOrDefaultAsync(x => x.Id == model.Id);

            if (Event == null) { return Result.Failure<Event>(EventsErrors.EventNotFound); }

            using var Transaction = context.Database.BeginTransaction();

            try
            {
                model.Adapt(Event);
                if (Event.Image != null)
                {
                    var oldPath = Path.Combine(Directory.GetCurrentDirectory(), Event.Image);

                    if (File.Exists(oldPath))
                    {
                        File.Delete(oldPath);
                    }

                    if (Event.Hotels != null) { Event.Hotels.Clear(); await context.SaveChangesAsync(); }
                }
                if (model.Image != null && model.Image.Length > 0)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.EventImages}{model.Image.FileName}");
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await model.Image.CopyToAsync(stream);
                    }
                    Event.Image = $"{Urls.EventImages}{model.Image.FileName}";
                }

                var Hotels = await context.Hotels.Where(x => x.GovernateName == model.Governate).ToListAsync();

                Event.Hotels!.AddRange(Hotels);

                await context.SaveChangesAsync();
                await Transaction.CommitAsync();
                return Result.Success(Event);
            }
            catch
            {
                await Transaction.RollbackAsync();
                return Result.Failure<Event>(EventsErrors.EventCannotAdded);
            }

        }

        public async Task<Result<EventTickets>> UpdateTicket(string UserId, UpdateTicketDTO model)
        {
            var user = await usermanger.Users.Include(x => x.EventTickets).FirstOrDefaultAsync(user => user.Id == UserId);

            if (user == null) { Result.Failure<EventTickets>(UserErrors.UserNotFound); }

            if (user!.IsDisabled) { Result.Failure<EventTickets>(UserErrors.DisabledUser); }

            if (!user.EmailConfirmed) { Result.Failure<EventTickets>(UserErrors.UnconfirmedEmail); }

            var Ticket = user.EventTickets.FirstOrDefault(x => x.Id == model.Id);

            if (Ticket == null) { return Result.Failure<EventTickets>(EventsErrors.EventTicketNotFound); }

            model.Adapt(Ticket);
            await context.SaveChangesAsync();
            return Result.Success(Ticket);
        }

        public async Task<Result> DeleteTicket(int TicketId)
        {
            var Ticket = await context.EventTickets.FirstOrDefaultAsync(x => x.Id == TicketId);

            if (Ticket == null) { return Result.Failure(EventsErrors.EventTicketNotFound); }

            context.EventTickets.Remove(Ticket);
            await context.SaveChangesAsync();
            return Result.Success();
        }

        public async Task<PaginatedList<EventTickets>> GetEventTicket(RequestFilter filters, CancellationToken CanToken)
        {
            var Tickets = await context.EventTickets.CreatePaginatedList<EventTickets>(filters.PageNumber, filters.PageSize, CanToken);

            return Tickets;
        }
    }
}
