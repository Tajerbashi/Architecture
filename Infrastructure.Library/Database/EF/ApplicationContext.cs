using Domain.Library.Entities.SEC;
using Infrastructure.Library.Configuration.SeedData;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Library.Database.EF
{
    public class ApplicationContext : IdentityDbContext<User, Role, long, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            DataSeedConfiguration.DataSeeds(modelBuilder);
            #region SEC
            modelBuilder.Entity<User>().ToTable("Users", "SEC").HasQueryFilter(x => !x.IsDeleted && x.IsActive);
            modelBuilder.Entity<Role>().ToTable("Roles", "SEC").HasQueryFilter(x => !x.IsDeleted && x.IsActive);
            modelBuilder.Entity<RoleClaim>().ToTable("RoleClaims", "SEC").HasQueryFilter(x => !x.IsDeleted && x.IsActive);
            modelBuilder.Entity<UserClaim>().ToTable("UserClaims", "SEC").HasQueryFilter(x => !x.IsDeleted && x.IsActive);
            modelBuilder.Entity<UserLogin>().ToTable("UserLogins", "SEC").HasQueryFilter(x => !x.IsDeleted && x.IsActive).HasKey(l => new { l.LoginProvider, l.ProviderKey, l.UserId });
            modelBuilder.Entity<UserRole>().ToTable("UserRoles", "SEC").HasQueryFilter(x => !x.IsDeleted && x.IsActive).HasKey(x => new { x.ID, x.UserId, x.RoleId });
            modelBuilder.Entity<UserToken>().ToTable("UserTokens", "SEC").HasQueryFilter(x => !x.IsDeleted && x.IsActive);
            modelBuilder.Entity<User>().HasIndex(x => x.NationalCode).IsUnique();
            #endregion
        }
    }
}
