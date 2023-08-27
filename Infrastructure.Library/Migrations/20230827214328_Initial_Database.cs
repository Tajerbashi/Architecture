using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Library.Migrations
{
    /// <inheritdoc />
    public partial class Initial_Database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "SEC");

            migrationBuilder.CreateTable(
                name: "Roles",
                schema: "SEC",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateByUserRoleID = table.Column<long>(type: "bigint", nullable: false),
                    DeleteByUserRoleID = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "SEC",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Family = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateByUserRoleID = table.Column<long>(type: "bigint", nullable: false),
                    DeleteByUserRoleID = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                schema: "SEC",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateByUserRoleID = table.Column<long>(type: "bigint", nullable: false),
                    DeleteByUserRoleID = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "SEC",
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalSchema: "SEC",
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "SEC",
                table: "Roles",
                columns: new[] { "ID", "CreateByUserRoleID", "CreateDate", "DeleteByUserRoleID", "DeleteDate", "Description", "Guid", "IsActive", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2023, 8, 28, 1, 13, 28, 144, DateTimeKind.Local).AddTicks(1889), 0L, new DateTime(2023, 8, 28, 1, 13, 28, 144, DateTimeKind.Local).AddTicks(1904), "این اطلاعات اولیه است.", new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Admin" },
                    { 2L, 1L, new DateTime(2023, 8, 28, 1, 13, 28, 144, DateTimeKind.Local).AddTicks(1942), 0L, new DateTime(2023, 8, 28, 1, 13, 28, 144, DateTimeKind.Local).AddTicks(1943), "این اطلاعات اولیه است.", new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Operator" },
                    { 3L, 1L, new DateTime(2023, 8, 28, 1, 13, 28, 144, DateTimeKind.Local).AddTicks(1962), 0L, new DateTime(2023, 8, 28, 1, 13, 28, 144, DateTimeKind.Local).AddTicks(1963), "این اطلاعات اولیه است.", new Guid("00000000-0000-0000-0000-000000000000"), true, false, "Customer" }
                });

            migrationBuilder.InsertData(
                schema: "SEC",
                table: "Users",
                columns: new[] { "ID", "CreateByUserRoleID", "CreateDate", "DeleteByUserRoleID", "DeleteDate", "Email", "Family", "Guid", "IsActive", "IsDeleted", "Name", "Password", "Username" },
                values: new object[] { 1L, 1L, new DateTime(2023, 8, 28, 1, 13, 28, 144, DateTimeKind.Local).AddTicks(2061), 0L, new DateTime(2023, 8, 28, 1, 13, 28, 144, DateTimeKind.Local).AddTicks(2061), "Admin@mail.com", "ادمین", new Guid("00000000-0000-0000-0000-000000000000"), true, false, "ادمین", "Admin", "Admin" });

            migrationBuilder.InsertData(
                schema: "SEC",
                table: "UserRoles",
                columns: new[] { "ID", "CreateByUserRoleID", "CreateDate", "DeleteByUserRoleID", "DeleteDate", "Guid", "IsActive", "IsDeleted", "RoleId", "UserId" },
                values: new object[] { 1L, 0L, new DateTime(2023, 8, 28, 1, 13, 28, 144, DateTimeKind.Local).AddTicks(2031), 0L, new DateTime(2023, 8, 28, 1, 13, 28, 144, DateTimeKind.Local).AddTicks(2032), new Guid("00000000-0000-0000-0000-000000000000"), true, false, 1L, 1L });

            migrationBuilder.CreateIndex(
                name: "IX_Roles_ID",
                schema: "SEC",
                table: "Roles",
                column: "ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                schema: "SEC",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                schema: "SEC",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_ID",
                schema: "SEC",
                table: "Users",
                column: "ID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRoles",
                schema: "SEC");

            migrationBuilder.DropTable(
                name: "Roles",
                schema: "SEC");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "SEC");
        }
    }
}
