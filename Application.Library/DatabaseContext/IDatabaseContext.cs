using Domain.Library.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Library.DatabaseContext
{
    public interface IDatabaseContext
    {
        //  For Save Data in Database by this interface use these methods
        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());



        #region SEC
        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<UserRole> UserRoles { get; set; }
        #endregion

        #region LOG
        DbSet<SystemLogger> SystemLoggers { get; set; }
        #endregion


        #region RPT
        DbSet<GeneralReport> GeneralReports { get; set; }
        #endregion
    }
}
