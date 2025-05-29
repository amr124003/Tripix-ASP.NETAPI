using Tripix.Abstractions;

namespace Tripix.Services.Interfaces
{
    public interface IRepository<T> where T : class
    {
        public Task<T> CreateAsync(T entity);
        public Task<T> UpdateAsync(T entity);
        public Task DeleteAsync(T entity);
        public Task<T> GetbyId(int id);
        public Task<PaginatedList<T>> GetAllAsync();
    }
}
