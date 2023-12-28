using HobbyTracker.Entities;

namespace HobbyTracker.Services.Repositories.Json
{
    public class JsonPersister<T> where T : IEntity
    {
        private readonly string _path;

        private bool IsFileAvailable => File.Exists(_path);
        public List<T> Entities { get; set; }

        public JsonPersister(string path)
        {
            _path = path;
            Entities = ReadAsync().Result;
        }

        private async Task<List<T>> ReadAsync()
        {
            if (!IsFileAvailable)
            {
                return new List<T>();
            }

            var json = await File.ReadAllTextAsync(_path);
            var result = Newtonsoft.Json.JsonConvert.DeserializeObject<List<T>>(json);

            return result;
        }

        public async Task<bool> WriteAsync()
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(Entities);

            try
            {
                await File.WriteAllTextAsync(_path, json);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
