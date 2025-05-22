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
        public async Task<Result<Blog>> GetBlogAsync ( int id )
        {
            var blog = context.Blogs.FirstOrDefault(b => b.Id == id);

            if (blog == null) { return Result.Failure<Blog>(BlogErrors.BlogNotFound); }

            return Result.Success(blog);
        }

        public async Task<Result<Blog>> AddBlogAsync ( BlogDTO model )
        {
            if (model.Image == null || model.Image.Length == 0)
            {
                return Result.Failure<Blog>(BlogErrors.ImageNotFound);
            }

            var path = Path.Combine(Directory.GetCurrentDirectory(), $"{Urls.BlogImageUrl}{model.Image.FileName}");

            

            using (var stram = new FileStream(path, FileMode.Create))
            {
                await model.Image.CopyToAsync(stram);
            }

            var blog = model.Adapt<Blog>();
            blog.Image = Urls.BlogImageUrl+model.Image.FileName;

            await context.Blogs.AddAsync(blog);
            context.SaveChanges();

            return Result.Success(blog);
        }

        public async Task<List<Blog>> GetBlogListAsync ()
        {
            return context.Blogs.AsNoTracking().ToListAsync().Result;
        }

        public async Task<Result<Blog>> UpdateBlogAsync ( UpdateBlogDto model )
        {
            var blog = context.Blogs.FirstOrDefault(b => b.Id == model.Id);

            if (blog == null) { return Result.Failure<Blog>(BlogErrors.BlogNotFound); }

            blog = model.Adapt<Blog>();

            if (model.NewImage == null || model.NewImage.Length == 0)
            {
                return Result.Failure<Blog>(BlogErrors.ImageNotFound);
            }

            var path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/blogs/{model.NewImage.FileName}");

            if (blog.Image != null)
            {
                var oldPath = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot{blog.Image}");

                if (System.IO.File.Exists(oldPath)) { System.IO.File.Delete(oldPath); }
            }

            using (var Stream = new FileStream(path, FileMode.Create))
            {
                model.NewImage.CopyTo(Stream);
            }

            blog.Image = $"Images/blogs/{model.NewImage.FileName}";

            context.SaveChanges();

            return Result.Success(blog);
        }

        public async Task<Result> DeleteBlog ( int id )
        {
            var blog = context.Blogs.FirstOrDefault(x => x.Id == id);

            if(blog is null) { Result.Failure(BlogErrors.BlogNotFound); }

            context.Blogs.Remove(blog);
            context.SaveChanges();
            return Result.Success();
        }
    }
}
