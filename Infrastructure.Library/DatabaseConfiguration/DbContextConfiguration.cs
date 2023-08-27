using Infrastructure.Library.DatabaseConfiguration.SEC;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Library.DatabaseConfiguration
{
    public class DbContextConfiguration
    {
        public DbContextConfiguration() { }
        public void SEC_Configuration(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserRoleConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new RoleConfiguration());
        }
    }
}
