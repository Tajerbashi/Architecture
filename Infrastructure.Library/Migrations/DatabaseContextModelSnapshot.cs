﻿// <auto-generated />
using System;
using Infrastructure.Library.Database;
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
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Library.Entities.CNT.MenuLink", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("CreatedByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<long>("DeleteByUserID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime2");

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

                    b.Property<long?>("ParentId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("RowGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UpdateByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("MenuLinks");
                });

            modelBuilder.Entity("Domain.Library.Entities.Role", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("CreatedByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<long>("DeleteByUserID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("RowGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("UpdateByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ID");

                    b.ToTable("Roles", "SEC");

                    b.HasData(
                        new
                        {
                            ID = 1L,
                            CreateDate = new DateTime(2023, 8, 6, 22, 8, 13, 240, DateTimeKind.Local).AddTicks(5467),
                            CreatedByUserRoleID = 0L,
                            DeleteByUserID = 0L,
                            DeleteDate = new DateTime(2023, 8, 6, 22, 8, 13, 240, DateTimeKind.Local).AddTicks(5465),
                            Description = "این نقش اولیه است",
                            IsActive = true,
                            IsDeleted = false,
                            RowGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            Title = "Admin",
                            UpdateByUserRoleID = 0L,
                            UpdateDate = new DateTime(2023, 8, 6, 22, 8, 13, 240, DateTimeKind.Local).AddTicks(5452)
                        },
                        new
                        {
                            ID = 2L,
                            CreateDate = new DateTime(2023, 8, 6, 22, 8, 13, 240, DateTimeKind.Local).AddTicks(5499),
                            CreatedByUserRoleID = 0L,
                            DeleteByUserID = 0L,
                            DeleteDate = new DateTime(2023, 8, 6, 22, 8, 13, 240, DateTimeKind.Local).AddTicks(5498),
                            Description = "این نقش اولیه است",
                            IsActive = true,
                            IsDeleted = false,
                            RowGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            Title = "Operator",
                            UpdateByUserRoleID = 0L,
                            UpdateDate = new DateTime(2023, 8, 6, 22, 8, 13, 240, DateTimeKind.Local).AddTicks(5498)
                        },
                        new
                        {
                            ID = 3L,
                            CreateDate = new DateTime(2023, 8, 6, 22, 8, 13, 240, DateTimeKind.Local).AddTicks(5516),
                            CreatedByUserRoleID = 0L,
                            DeleteByUserID = 0L,
                            DeleteDate = new DateTime(2023, 8, 6, 22, 8, 13, 240, DateTimeKind.Local).AddTicks(5515),
                            Description = "این نقش اولیه است",
                            IsActive = true,
                            IsDeleted = false,
                            RowGuid = new Guid("00000000-0000-0000-0000-000000000000"),
                            Title = "User",
                            UpdateByUserRoleID = 0L,
                            UpdateDate = new DateTime(2023, 8, 6, 22, 8, 13, 240, DateTimeKind.Local).AddTicks(5514)
                        });
                });

            modelBuilder.Entity("Domain.Library.Entities.User", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("Age")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("CreatedByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<long>("DeleteByUserID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Family")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("RowGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UpdateByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ID");

                    b.ToTable("Users", "SEC");
                });

            modelBuilder.Entity("Domain.Library.Entities.UserRole", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ID"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("CreatedByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<long>("DeleteByUserID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<long?>("RoleID")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.Property<Guid>("RowGuid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UpdateByUserRoleID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("UserID")
                        .IsRequired()
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.HasIndex("UserID");

                    b.ToTable("UserRoles", "SEC");
                });

            modelBuilder.Entity("Domain.Library.Entities.UserRole", b =>
                {
                    b.HasOne("Domain.Library.Entities.Role", "Role")
                        .WithMany("UserRole")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Library.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Library.Entities.Role", b =>
                {
                    b.Navigation("UserRole");
                });

            modelBuilder.Entity("Domain.Library.Entities.User", b =>
                {
                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
