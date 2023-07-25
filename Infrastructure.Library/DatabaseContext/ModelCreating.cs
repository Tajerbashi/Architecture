using Infrastructure.Library.EntityConfiguration.SEC;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Library
{
    public static class ModelCreating
    {
        public static void ModelCreate(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
        }
    }
}
