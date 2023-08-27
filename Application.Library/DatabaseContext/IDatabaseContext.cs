using Domain.Library.Entities.SEC;
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
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        #endregion
    }
}
