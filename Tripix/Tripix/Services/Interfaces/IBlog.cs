using Tripix.Abstractions;

using Tripix.Entities;
using Tripix.View_Models;

namespace Tripix.Services.Interfaces
{
    public interface IBlog
    {
        public Task<List<Blog>> GetBlogListAsync(CancellationToken canToken = default);
        public Task<Result<Blog>> GetBlogAsync(int id , CancellationToken canToken = default);
        public Task<Result<Blog>> AddBlogAsync(BlogDTO model , CancellationToken canToken = default);
        public Task<Result<Blog>> UpdateBlogAsync (UpdateBlogDto model , CancellationToken canToken = default);
        public Task<Result> DeleteBlog(int id);
    }
}
