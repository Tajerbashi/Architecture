using Domain.Library.Entities.CNT.Menu.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Library.DatabaseConfiguration.CNT
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.HasMany(x => x.MenuPrivileges)
                .WithOne(x => x.Menu)
                .HasForeignKey(x => x.MenuId);
        }
    }
}
