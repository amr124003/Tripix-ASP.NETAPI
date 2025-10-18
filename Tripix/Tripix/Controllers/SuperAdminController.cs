using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Tripix.Abstractions;
using Tripix.Contracts.Admin;
using Tripix.Services.Interfaces;
using Tripix.Services.Repositories;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class SuperAdminController : ControllerBase
    {
        private readonly IUnitOfWork unitofwork;

        public SuperAdminController (IUnitOfWork unitofwork)
        {
            this.unitofwork = unitofwork;
        }
        [HttpPost("AssignRole")]
        public async Task<IActionResult> AsignRole ( [FromBody] AssignRoleModel model )
        {
            var res = await unitofwork.adminService.AssignRole (model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpPost("AddAdmin")]
        public async Task<IActionResult> AddAdmin ( [FromBody] AddAdminModel model )
        {
            var res = await unitofwork.adminService.AddAdmin (model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem ();
        }

        [HttpGet("GetAdmins")]
        public async Task<IActionResult> GetAdmins ()
        {
            var res = await unitofwork.adminService.GetAdmins ();

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpGet("GetServiceBookings")]
        public IActionResult GetServiceBookings()
        {
            var res = unitofwork.adminService.GetServiceBookings ();

            return Ok(res);
        }
        [HttpPost("DeleteService")]
        public IActionResult DeleteService(DeleteServiceDTO model)
        {
            var res = unitofwork.adminService.DeleteBooking (model);

            return Ok(res);
        }
    }
}
