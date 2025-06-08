using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Tripix.Abstractions;
using Tripix.Contracts.Common;
using Tripix.Contracts.Event;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public EventsController ( IUnitOfWork unitOfWork )
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet("Events")]
        public async Task<IActionResult> GetEvents ()
        {
            var res = await unitOfWork.EventRepo.GetEvents();

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpGet("GetEvent/{Id}")]
        public async Task<IActionResult> GetEvent ( int Id )
        {
            var res = await unitOfWork.EventRepo.GetEvent(Id);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpPost("AddEvent")]
        public async Task<IActionResult> AddEvent ( AddEventDTO model )
        {
            var res = await unitOfWork.EventRepo.AddEvent(model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpDelete("DeleteEvent/{Id}")]
        public async Task<IActionResult> DeleteEvent ( int Id )
        {
            var res = await unitOfWork.EventRepo.DeleteEvemt(Id);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpPut("UpdateEvent")]
        public async Task<IActionResult> UpdateEvent ( UpdateEventDTO model )
        {
            var res = await unitOfWork.EventRepo.UpdateEvent(model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpDelete("CancelTicket/{Id}")]
        public async Task<IActionResult> CancelTicket ( int Id )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitOfWork.EventRepo.CancelTicket(UserId!, Id);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpPut("UpdateTicket")]
        public async Task<IActionResult> UpdateTicket ( UpdateTicketDTO model )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitOfWork.EventRepo.UpdateTicket(UserId!, model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpGet("GetTicket/{Id}")]
        public async Task<IActionResult> GetTicket ( int Id )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitOfWork.EventRepo.GetTicket(UserId!, Id);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpDelete("DeleteTicket/{Id}")]
        public async Task<IActionResult> DeleteTicket ( int Id )
        {
            var res = await unitOfWork.EventRepo.DeleteTicket(Id);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpPost("GetEventTickets")]
        public async Task<IActionResult> GetEventTickets ( RequestFilter filter )
        {
            var res = await unitOfWork.EventRepo.GetEventTicket(filter);

            return Ok(res);
        }
        [HttpPost("BookingTicket")]
        public async Task<IActionResult> BookingEventTicket ( BookingEventDTO model )
        {
            var UserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var res = await unitOfWork.EventRepo.BookingEventTicket(UserId!, model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
    }
}
