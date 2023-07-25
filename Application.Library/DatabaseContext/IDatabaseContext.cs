using Domain.Library.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Library.DatabaseContext
{
    public interface IDatabaseContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Role> Roles { get; set; }
        DbSet<UserRole> UserRoles { get; set; }





        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
        DbSet<TEntity> Set<
            [DynamicallyAccessedMembers
                (
                DynamicallyAccessedMemberTypes.PublicConstructors |
                DynamicallyAccessedMemberTypes.NonPublicConstructors |
                DynamicallyAccessedMemberTypes.PublicFields | 
                DynamicallyAccessedMemberTypes.NonPublicFields | 
                DynamicallyAccessedMemberTypes.PublicProperties | 
                DynamicallyAccessedMemberTypes.NonPublicProperties | 
                DynamicallyAccessedMemberTypes.Interfaces
                )
            ] 
        TEntity>() where TEntity : class;

    }
}
