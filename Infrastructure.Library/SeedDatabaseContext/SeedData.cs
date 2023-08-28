using Domain.Library.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Library.SeedDatabaseContext
{
    public class SeedData
    {
        public SeedData() { }

        public void RoleSeeds(ModelBuilder builder)
        {
            builder.Entity<Role>().HasData(new Role { ID = 1, Title = nameof(UserRolesSeed.Admin), CreateByUserRoleID = 1, Description = "این اطلاعات اولیه است.", Guid = new Guid() });
            builder.Entity<Role>().HasData(new Role { ID = 2, Title = nameof(UserRolesSeed.Operator), CreateByUserRoleID = 1, Description = "این اطلاعات اولیه است.", Guid = new Guid() });
            builder.Entity<Role>().HasData(new Role { ID = 3, Title = nameof(UserRolesSeed.Customer), CreateByUserRoleID = 1, Description = "این اطلاعات اولیه است.", Guid = new Guid() });
        }
        public void AdminSeed(ModelBuilder builder)
        {
            builder.Entity<User>().HasData(new User { ID = 1, Name = "ادمین", Family = "ادمین", Username = "Admin", Password = "Admin", Email = "Admin@mail.com", CreateByUserRoleID = 1, Guid = new Guid() });
        }
        public void UserRoleSeed(ModelBuilder builder)
        {
            builder.Entity<UserRole>().HasData(new UserRole { ID = 1, RoleId = 1, UserId = 1, Guid = new Guid() });
        }
    }
    public enum UserRolesSeed
    {
        Admin,
        Operator,
        Customer,
    }
}
