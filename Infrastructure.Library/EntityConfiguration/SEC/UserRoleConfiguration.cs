using Domain.Library.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Library.EntityConfiguration.SEC
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasQueryFilter(c => !c.IsDeleted);
            builder.HasIndex(c => c.ID);

            builder.HasKey(sc => new { sc.ID, sc.UserID, sc.RoleID });

            builder.HasOne(c => c.User)
                .WithMany(c => c.UserRole)
                .HasForeignKey(c => c.UserID);

            builder.HasOne(c => c.Role)
                .WithMany(c => c.UserRole)
                .HasForeignKey(c => c.RoleID);

            builder.HasMany(c => c.GroupUserRoles)
                .WithOne(c => c.UserRole)
                .HasForeignKey(c => c.UserRoleID);
        }
    }
}
