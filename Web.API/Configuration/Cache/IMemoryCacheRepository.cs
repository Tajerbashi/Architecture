using Microsoft.Extensions.Caching.Memory;

namespace Web.API.Configuration.Cache
{
    public interface IMemoryCacheRepository : IMemoryCache
    {
    }
    public class MemoryCacheService : IMemoryCacheRepository
    {
        public ICacheEntry CreateEntry(object key)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Remove(object key)
        {
            throw new NotImplementedException();
        }

        public bool TryGetValue(object key, out object? value)
        {
            throw new NotImplementedException();
        }
    }
}
