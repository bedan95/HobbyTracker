using HobbyTracker.Entities;

namespace HobbyTracker.Services.Repositories
{
    public interface IRepository<T> where T : IEntity
    {
        Task CreateAsync(T entity);
        Task<IReadOnlyCollection<T>> GetAllAsync();
        Task<IReadOnlyCollection<T>> GetAllAsync(Func<T, bool> filter);
        Task<T> GetAsync(Guid id);
        Task<T> GetAsync(Func<T, bool> filter);
        Task Remove(Guid id);
        Task UpdateAsync(T entity);
    }
}
