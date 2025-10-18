using Mapster;
using Microsoft.EntityFrameworkCore;
using Tripix.Abstractions;
using Tripix.Abstractions.Consts;
using Tripix.Context;
using Tripix.Entities;
using Tripix.Errors;
using Tripix.Services.Interfaces;
using Tripix.View_Models;

namespace Tripix.Services.Repositories
{
    public class BlogRepo : IBlog
    {
        private readonly ApplicationDbcontext context;

        public BlogRepo ( ApplicationDbcontext context )
        {
            this.context = context;
        }
        public async Task<Result<Blog>> GetBlogAsync ( int id , CancellationToken canToken)
        {
            var blog = await context.Blogs.FirstOrDefaultAsync(b => b.Id == id , canToken);

            if (blog == null) { return Result.Failure<Blog>(BlogErrors.BlogNotFound); }

            return Result.Success(blog);
        }

        public async Task<Result<Blog>> AddBlogAsync ( BlogDTO model  , CancellationToken canToken)
        {
            if (model.Image == null || model.Image.Length == 0)
            {
                return Result.Failure<Blog>(BlogErrors.ImageNotFound);
            }

            var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.BlogImageUrl}{model.Image.FileName}");

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await model.Image.CopyToAsync(stream);
            }

            var blog = model.Adapt<Blog>();
            blog.Image = Urls.BlogImageUrl + model.Image.FileName;

            await context.Blogs.AddAsync(blog);
            await context.SaveChangesAsync();

            return Result.Success(blog);
        }
        public async Task<List<Blog>> GetBlogListAsync(CancellationToken cantoken )
        {
            var res = await context.Blogs.AsNoTracking().ToListAsync();

            return res;
        }
        public async Task<Result<Blog>> UpdateBlogAsync ( UpdateBlogDto model  , CancellationToken canToken)
        {
            var blog = await context.Blogs.FirstOrDefaultAsync(b => b.Id == model.Id , canToken);

            if (blog == null) { return Result.Failure<Blog>(BlogErrors.BlogNotFound); }

            using var Transaction = context.Database.BeginTransaction(); 

            try
            {
                model.Adapt(blog);

                if (model.NewImage == null || model.NewImage.Length == 0)
                {
                    return Result.Failure<Blog>(BlogErrors.ImageNotFound);
                }

                var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.BlogImageUrl}{model.NewImage.FileName}");

                if (blog.Image != null)
                {
                    var oldPath = Path.Combine(Directory.GetCurrentDirectory(), blog.Image);

                    if (File.Exists(oldPath)) { File.Delete(oldPath); }
                }

                using (var Stream = new FileStream(path, FileMode.Create))
                {
                   await  model.NewImage.CopyToAsync(Stream , canToken);
                }

                blog.Image = $"Images/blogs/{model.NewImage.FileName}";
                await context.SaveChangesAsync(canToken);
                await Transaction.CommitAsync(canToken);
                return Result.Success(blog);
            }
            catch
            {
                await Transaction.RollbackAsync(canToken);
                return Result.Failure<Blog>(BlogErrors.ErrorOnUpdate);
            }

            
        }

        public async Task<Result> DeleteBlog ( int id )
        {
            var blog = context.Blogs.FirstOrDefault(x => x.Id == id);

            if (blog == null) { Result.Failure(BlogErrors.BlogNotFound); }

            if(blog.Image != null )
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), blog.Image);

                if(File.Exists(path)) { File.Delete(path); }
            }

            context.Blogs.Remove(blog!);
            await context.SaveChangesAsync();

            return Result.Success();
        }
    }
}
