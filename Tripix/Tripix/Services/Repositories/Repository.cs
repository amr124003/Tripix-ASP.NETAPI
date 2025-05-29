using Microsoft.EntityFrameworkCore;
using Tripix.Abstractions;
using Tripix.Context;
using Tripix.Services.Interfaces;

namespace Tripix.Services.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbcontext context;
        public DbSet<T> Entity;


        public Repository ( ApplicationDbcontext context )
        {
            this.context = context;
            Entity = context.Set<T>();
        }
        public async Task<T> CreateAsync ( T entity )
        {
            await Entity.AddAsync(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync ( T entity )
        {
            Entity.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync ()
        {
            return Entity.ToListAsync().Result ?? new List<T>();
        }

        public async Task<T> GetbyId ( int id )
        {
            return Entity.FindAsync(id).Result;
        }

        public async Task<T> UpdateAsync ( T entity )
        {
            Entity.Update(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        Task<PaginatedList<T>> IRepository<T>.GetAllAsync ()
        {
            throw new NotImplementedException();
        }
    }
}
