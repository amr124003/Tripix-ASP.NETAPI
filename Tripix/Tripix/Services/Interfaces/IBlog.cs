using Tripix.Abstractions;

using Tripix.Entities;
using Tripix.View_Models;

namespace Tripix.Services.Interfaces
{
    public interface IBlog
    {
        public Task<List<Blog>> GetBlogListAsync();
        public Task<Result<Blog>> GetBlogAsync(int id);
        public Task<Result<Blog>> AddBlogAsync(BlogDTO model);
        public Task<Result<Blog>> UpdateBlogAsync (UpdateBlogDto model);
        public Task<Result> DeleteBlog(int id);
    }
}
