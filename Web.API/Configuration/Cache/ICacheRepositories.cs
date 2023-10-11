using Microsoft.Extensions.Caching.Distributed;

namespace Web.API.Configuration.Cache
{
    public interface ICacheRepositories
    {
        IDistributedCacheRepositories distributedCacheRepositories { get; }
        IMemoryCacheRepository memoryCacheRepositories { get; }
    }

    public class CacheServices : ICacheRepositories
    {
        private DistributedCacheService _distributedCacheRepositories;
        public IDistributedCacheRepositories distributedCacheRepositories
        {
            get
            {
                return _distributedCacheRepositories = _distributedCacheRepositories ?? new DistributedCacheService();
            }
        }
        private MemoryCacheService _memoryCacheService;
        public IMemoryCacheRepository memoryCacheRepositories
        {
            get
            {
                return _memoryCacheService = _memoryCacheService ?? new MemoryCacheService();
            }
        }
    }

}
