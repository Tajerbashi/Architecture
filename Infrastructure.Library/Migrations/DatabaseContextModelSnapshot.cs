﻿// <auto-generated />
using System;
using Infrastructure.Library.DatabaseContextDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Library.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Library.Entities.CNT.Menu.Entities.Menu", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long>("CreateByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("DeleteByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("ParentID")
                        .HasColumnType("bigint");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("URL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Menus", "CNT");
                });

            modelBuilder.Entity("Domain.Library.Entities.CNT.Menu.Entities.MenuPrivilege", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long>("CreateByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("DeleteByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("MenuId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("MenuId");

                    b.HasIndex("RoleId");

                    b.ToTable("MenuPrivilege", "LOG");
                });

            modelBuilder.Entity("Domain.Library.Entities.GeneralReport", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long>("CreateByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("DeleteByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("GeneralReports", "RPT");
                });

            modelBuilder.Entity("Domain.Library.Entities.Role", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long>("CreateByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("DeleteByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ID")
                        .IsUnique();

                    b.ToTable("Roles", "SEC");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            CreateByUserRoleID = 1L,
                            CreateDate = new DateTime(2023, 9, 10, 17, 48, 37, 316, DateTimeKind.Local).AddTicks(9398),
                            DeleteByUserRoleID = 0L,
                            DeleteDate = new DateTime(2023, 9, 10, 17, 48, 37, 316, DateTimeKind.Local).AddTicks(9415),
                            Description = "این اطلاعات اولیه است.",
                            Guid = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            IsDeleted = false,
                            Title = "Admin"
                        },
                        new
                        {
                            ID = 2L,
                            CreateByUserRoleID = 1L,
                            CreateDate = new DateTime(2023, 9, 10, 17, 48, 37, 316, DateTimeKind.Local).AddTicks(9452),
                            DeleteByUserRoleID = 0L,
                            DeleteDate = new DateTime(2023, 9, 10, 17, 48, 37, 316, DateTimeKind.Local).AddTicks(9453),
                            Description = "این اطلاعات اولیه است.",
                            Guid = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            IsDeleted = false,
                            Title = "Operator"
                        },
                        new
                        {
                            ID = 3L,
                            CreateByUserRoleID = 1L,
                            CreateDate = new DateTime(2023, 9, 10, 17, 48, 37, 316, DateTimeKind.Local).AddTicks(9470),
                            DeleteByUserRoleID = 0L,
                            DeleteDate = new DateTime(2023, 9, 10, 17, 48, 37, 316, DateTimeKind.Local).AddTicks(9471),
                            Description = "این اطلاعات اولیه است.",
                            Guid = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            IsDeleted = false,
                            Title = "Customer"
                        });
                });

            modelBuilder.Entity("Domain.Library.Entities.SystemLogger", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long>("CreateByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("DeleteByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Error")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Event")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exception")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSuccess")
                        .HasColumnType("bit");

                    b.Property<string>("Method")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Service")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("SystemLogger", "LOG");
                });

            modelBuilder.Entity("Domain.Library.Entities.User", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long>("CreateByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("DeleteByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("ID")
                        .IsUnique();

                    b.ToTable("Users", "SEC");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            CreateByUserRoleID = 1L,
                            CreateDate = new DateTime(2023, 9, 10, 17, 48, 37, 316, DateTimeKind.Local).AddTicks(9528),
                            DeleteByUserRoleID = 0L,
                            DeleteDate = new DateTime(2023, 9, 10, 17, 48, 37, 316, DateTimeKind.Local).AddTicks(9529),
                            Email = "Admin@mail.com",
                            Family = "ادمین",
                            Guid = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            IsDeleted = false,
                            Name = "ادمین",
                            Password = "Admin",
                            Username = "Admin"
                        });
                });

            modelBuilder.Entity("Domain.Library.Entities.UserRole", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<long>("CreateByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("DeleteByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Guid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles", "SEC");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            CreateByUserRoleID = 0L,
                            CreateDate = new DateTime(2023, 9, 10, 17, 48, 37, 316, DateTimeKind.Local).AddTicks(9496),
                            DeleteByUserRoleID = 0L,
                            DeleteDate = new DateTime(2023, 9, 10, 17, 48, 37, 316, DateTimeKind.Local).AddTicks(9497),
                            Guid = new Guid("00000000-0000-0000-0000-000000000000"),
                            IsActive = true,
                            IsDeleted = false,
                            RoleId = 1L,
                            UserId = 1L
                        });
                });

            modelBuilder.Entity("Domain.Library.Entities.CNT.Menu.Entities.MenuPrivilege", b =>
                {
                    b.HasOne("Domain.Library.Entities.CNT.Menu.Entities.Menu", "Menu")
                        .WithMany("MenuPrivileges")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Library.Entities.Role", "Role")
                        .WithMany("MenuPrivileges")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Menu");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("Domain.Library.Entities.UserRole", b =>
                {
                    b.HasOne("Domain.Library.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Library.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Library.Entities.CNT.Menu.Entities.Menu", b =>
                {
                    b.Navigation("MenuPrivileges");
                });

            modelBuilder.Entity("Domain.Library.Entities.Role", b =>
                {
                    b.Navigation("MenuPrivileges");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Domain.Library.Entities.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
