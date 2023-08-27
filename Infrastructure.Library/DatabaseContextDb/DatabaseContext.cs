using Application.Library.DatabaseContext;
using Domain.Library.Entities.SEC;
using Infrastructure.Library.Pattern;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Library.DatabaseContextDb
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        private readonly IFacadPattern _pattern;
        public DatabaseContext(
            DbContextOptions options,
            IFacadPattern pattern
            ) : base(options)
        {
            _pattern = pattern;
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            _pattern._configuration.SEC_Configuration(modelBuilder);



            _pattern._seedData.RoleSeeds(modelBuilder);
            _pattern._seedData.UserRoleSeed(modelBuilder);
            _pattern._seedData.AdminSeed(modelBuilder);
        }

    }
}
