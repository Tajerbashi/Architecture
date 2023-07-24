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
    public class GroupUserRoleConfiguration : IEntityTypeConfiguration<GroupUserRole>
    {
        public void Configure(EntityTypeBuilder<GroupUserRole> builder)
        {
            builder.HasQueryFilter(c => !c.IsDeleted);
            builder.HasIndex(c => c.ID);

            //builder.HasKey(c => new { c.UserRoleID, c.GroupID });


            builder.HasOne(c => c.UserRole)
                .WithMany(c => c.GroupUserRoles)
                .HasForeignKey(c => c.UserRoleID);

            builder.HasOne(c => c.Group)
                .WithMany(c => c.GroupUserRoles)
                .HasForeignKey(c => c.GroupID);
        }
    }
}
