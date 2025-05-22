using Microsoft.AspNetCore.Mvc;
using Tripix.Abstractions;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private readonly IUnitOfWork unitofwork;

        public BlogsController ( IUnitOfWork unitofwork )
        {
            this.unitofwork = unitofwork;
        }
        [HttpGet("Blogs")]
        public async Task<IActionResult> GetBlogs ()
        {
            var res = await unitofwork.BlogService.GetBlogListAsync();

            return Ok(res);
        }
        [HttpGet("Blog")]
        public async Task<IActionResult> GetBlog ( int Id )
        {
            var res = await unitofwork.BlogService.GetBlogAsync(Id);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpPost("AddBlog")]
        public async Task<IActionResult> AddBlog ( BlogDTO model )
        {
            var res = await unitofwork.BlogService.AddBlogAsync(model);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
        [HttpPut("UpdateBlog")]
        public async Task<IActionResult> UpdateBlog ( int Id, UpdateBlogDto model )
        {
            var res = await unitofwork.BlogService.UpdateBlogAsync(model);

            return res.IsSuccess ? Ok(res.Value) : res.ToProblem();
        }
        [HttpDelete("DeleteBlog")]
        public async Task<IActionResult> DeleteBlog ( int Id )
        {
            var res = await unitofwork.BlogService.DeleteBlog(Id);

            return res.IsSuccess ? Ok(res) : res.ToProblem();
        }
    }
}
