using Application.Library.DatabaseContext;
using Domain.Library.Entities;
using Infrastructure.Library.Pattern;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Library.DatabaseContextDb
{
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        private readonly IFacadPattern _pattern;
        public DatabaseContext(
            DbContextOptions<DatabaseContext> options,
            IFacadPattern pattern
            ) : base(options)
        {
            _pattern = pattern;
        }

        #region SEC
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        #endregion

        #region LOG
        public DbSet<SystemLogger> SystemLoggers { get; set; }
        #endregion


        #region RPT
        public DbSet<GeneralReport> GeneralReports { get; set; }
        #endregion

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
