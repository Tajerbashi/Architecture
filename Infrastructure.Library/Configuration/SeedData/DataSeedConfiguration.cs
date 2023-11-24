using Domain.Library.Entities.SEC;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Library.Configuration.SeedData
{
    public static class DataSeedConfiguration
    {
        public static void DataSeeds(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    Key = nameof(RoleDataSeed.ADMIN),
                    ConcurrencyStamp = null,
                    Guid = Guid.NewGuid(),
                    Name = "ادمین",
                    NormalizedName = null,
                    UpdateBy = null,
                    UpdateDate = null,
                    Title = "ادمین",
                    IsDeleted = false,
                    IsActive = true,
                });

            modelBuilder.Entity<User>().HasData(
              new User
              {
                  Id = 1,
                  AccessFailedCount = 0,
                  AvatarFile = "",
                  Email = "ADMIN",
                  UserName = "ADMIN",
                  FirstName = "ADMIN",
                  LastName = "ADMIN",
                  NationalCode = "ADMIN",
                  EmailConfirmed = false,
                  Gender = Domain.Library.Enums.GenderTypeEnum.MALE,
                  LockoutEnabled = false,
                  LockoutEnd = null,
                  NormalizedEmail = null,
                  NormalizedUserName = null,
                  PasswordHash = null,
                  PhoneNumber = null,
                  PhoneNumberConfirmed = false,
                  SecurityStamp = null,
                  SignFile = "ADMIN",
                  TwoFactorEnabled = false,
                  ConcurrencyStamp = null,
                  Guid = Guid.NewGuid(),
                  UpdateBy = null,
                  UpdateDate = null,
                  IsDeleted = false,
                  IsActive = true,
              });

            modelBuilder.Entity<UserRole>().HasData(
                new UserRole
                {
                    ID = 1,
                    EndDate = null,
                    Guid = Guid.NewGuid(),
                    IsDefault = true,
                    RoleId = 1,
                    UserId = 1,
                    StartDate = DateTime.Now,
                    IsDeleted = false,
                    IsActive = true,
                });
        }
    }
}
