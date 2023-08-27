using Application.Library.DatabaseContext;
using Infrastructure.Library.DatabaseConfiguration;
using Infrastructure.Library.DatabaseContextDb;
using Infrastructure.Library.MappingProfile;
using Infrastructure.Library.SeedDatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Library.Pattern
{
    public interface IFacadPattern
    {
        DbContextConfiguration _configuration { get; }
        DbContextMappingProfile _mapping { get; }
        SeedData _seedData { get; }
    }
    public class FacadPattern : IFacadPattern
    {
        private readonly DbContextOptions _options;
        public FacadPattern(
            DbContextOptions options
            )
        {
            _options = options;
        }

        private DbContextConfiguration configuration;
        public DbContextConfiguration _configuration
        {
            get
            {
                return configuration = configuration ?? new DbContextConfiguration();
            }
        }
        private DbContextMappingProfile mapping;
        public DbContextMappingProfile _mapping
        {
            get
            {
                return mapping = mapping ?? new DbContextMappingProfile();
            }
        }
        private SeedData seedData;
        public SeedData _seedData
        {
            get
            {
                return seedData = seedData ?? new SeedData();
            }
        }
    }
}
