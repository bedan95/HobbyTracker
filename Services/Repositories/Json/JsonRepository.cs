using HobbyTracker.Entities;

namespace HobbyTracker.Services.Repositories.Json
{
    public class JsonRepository<T> : IRepository<T> where T : IEntity
    {
        readonly JsonPersister<T> _persister;

        public JsonRepository(JsonPersister<T> persister)
        {
            _persister = persister;
        }

        public async Task CreateAsync(T entity)
        {
            _persister.Entities.Add(entity);
            await _persister.WriteAsync();
        }

        public async Task<IReadOnlyCollection<T>> GetAllAsync()
        {
            return _persister.Entities;
        }

        public async Task<IReadOnlyCollection<T>> GetAllAsync(Func<T, bool> filter)
        {
            return _persister.Entities.Where(filter).ToList();
        }

        public async Task<T> GetAsync(Guid id)
        {
            return _persister.Entities.FirstOrDefault(x => x.Id == id);
        }

        public async Task<T> GetAsync(Func<T, bool> filter)
        {
            return _persister.Entities.Where(filter).FirstOrDefault();
        }

        public async Task Remove(Guid id)
        {
            _persister.Entities.Remove(_persister.Entities.FirstOrDefault(x
                => x.Id == id));
            await _persister.WriteAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            var toUpdate = _persister.Entities.First(x => x.Id == entity.Id);
            toUpdate = entity;
            await _persister.WriteAsync();
        }
    }
}
