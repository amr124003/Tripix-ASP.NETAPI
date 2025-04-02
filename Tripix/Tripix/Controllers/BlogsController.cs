using Microsoft.AspNetCore.Mvc;

namespace Tripix.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        public IActionResult GetBlogs ()
        {
            return Ok("Blogs");
        }
        public IActionResult GetBlog ()
        {
            return Ok("Blog");
        }
        public IActionResult AddBlog ()
        {
            return Ok("Blog added");
        }
        public IActionResult UpdateBlog ()
        {
            return Ok("Blog updated");
        }
        public IActionResult DeleteBlog ()
        {
            return Ok("Blog deleted");
        }
        public IActionResult LikeBlog ()
        {
            return Ok("Blog liked");
        }
    }
}
