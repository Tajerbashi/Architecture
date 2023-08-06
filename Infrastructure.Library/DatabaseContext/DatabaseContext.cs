using Application.Library.DatabaseContext;
using Domain.Library.Entities;
using Domain.Library.Entities.CNT;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Library.Database
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<MenuLink> MenuLinks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //  IEntityTypeConfiguration
            ModelCreating.ModelCreate(modelBuilder);

            //  Seed Data
            SeedData.Roles(modelBuilder);


        }
    }
}
