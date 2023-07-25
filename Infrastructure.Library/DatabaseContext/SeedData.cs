using Domain.Library.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Library
{
    public static class SeedData
    {
        public static void Roles(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(new Role { ID = 1, Title = nameof(UserRolesSeed.Admin), Description = "این نقش اولیه است" });
            modelBuilder.Entity<Role>().HasData(new Role { ID = 2, Title = nameof(UserRolesSeed.Operator), Description = "این نقش اولیه است" });
            modelBuilder.Entity<Role>().HasData(new Role { ID = 3, Title = nameof(UserRolesSeed.User), Description = "این نقش اولیه است" });
        }
    }
    public class UserRolesSeed
    {
        public const string Admin = "Admin";
        public const string Operator = "Operator";
        public const string User = "User";

    }
}
