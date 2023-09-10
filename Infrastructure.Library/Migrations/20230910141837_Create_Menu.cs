using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Library.Migrations
{
    /// <inheritdoc />
    public partial class Create_Menu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "CNT");

            migrationBuilder.CreateTable(
                name: "Menus",
                schema: "CNT",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentID = table.Column<long>(type: "bigint", nullable: false),
                    Guid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreateByUserRoleID = table.Column<long>(type: "bigint", nullable: false),
                    DeleteByUserRoleID = table.Column<long>(type: "bigint", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MenuPrivilege",
                schema: "LOG",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_MenuPrivilege", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MenuPrivilege_Menus_MenuId",
                        column: x => x.MenuId,
                        principalSchema: "CNT",
                        principalTable: "Menus",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuPrivilege_Roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "SEC",
                        principalTable: "Roles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreateDate", "DeleteDate" },
                values: new object[] { new DateTime(2023, 9, 10, 17, 48, 37, 316, DateTimeKind.Local).AddTicks(9398), new DateTime(2023, 9, 10, 17, 48, 37, 316, DateTimeKind.Local).AddTicks(9415) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "CreateDate", "DeleteDate" },
                values: new object[] { new DateTime(2023, 9, 10, 17, 48, 37, 316, DateTimeKind.Local).AddTicks(9452), new DateTime(2023, 9, 10, 17, 48, 37, 316, DateTimeKind.Local).AddTicks(9453) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "CreateDate", "DeleteDate" },
                values: new object[] { new DateTime(2023, 9, 10, 17, 48, 37, 316, DateTimeKind.Local).AddTicks(9470), new DateTime(2023, 9, 10, 17, 48, 37, 316, DateTimeKind.Local).AddTicks(9471) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "UserRoles",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreateDate", "DeleteDate" },
                values: new object[] { new DateTime(2023, 9, 10, 17, 48, 37, 316, DateTimeKind.Local).AddTicks(9496), new DateTime(2023, 9, 10, 17, 48, 37, 316, DateTimeKind.Local).AddTicks(9497) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Users",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreateDate", "DeleteDate" },
                values: new object[] { new DateTime(2023, 9, 10, 17, 48, 37, 316, DateTimeKind.Local).AddTicks(9528), new DateTime(2023, 9, 10, 17, 48, 37, 316, DateTimeKind.Local).AddTicks(9529) });

            migrationBuilder.CreateIndex(
                name: "IX_MenuPrivilege_MenuId",
                schema: "LOG",
                table: "MenuPrivilege",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_MenuPrivilege_RoleId",
                schema: "LOG",
                table: "MenuPrivilege",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuPrivilege",
                schema: "LOG");

            migrationBuilder.DropTable(
                name: "Menus",
                schema: "CNT");

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreateDate", "DeleteDate" },
                values: new object[] { new DateTime(2023, 8, 28, 18, 13, 0, 327, DateTimeKind.Local).AddTicks(172), new DateTime(2023, 8, 28, 18, 13, 0, 327, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "CreateDate", "DeleteDate" },
                values: new object[] { new DateTime(2023, 8, 28, 18, 13, 0, 327, DateTimeKind.Local).AddTicks(213), new DateTime(2023, 8, 28, 18, 13, 0, 327, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "CreateDate", "DeleteDate" },
                values: new object[] { new DateTime(2023, 8, 28, 18, 13, 0, 327, DateTimeKind.Local).AddTicks(223), new DateTime(2023, 8, 28, 18, 13, 0, 327, DateTimeKind.Local).AddTicks(223) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "UserRoles",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreateDate", "DeleteDate" },
                values: new object[] { new DateTime(2023, 8, 28, 18, 13, 0, 327, DateTimeKind.Local).AddTicks(237), new DateTime(2023, 8, 28, 18, 13, 0, 327, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Users",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreateDate", "DeleteDate" },
                values: new object[] { new DateTime(2023, 8, 28, 18, 13, 0, 327, DateTimeKind.Local).AddTicks(258), new DateTime(2023, 8, 28, 18, 13, 0, 327, DateTimeKind.Local).AddTicks(258) });
        }
    }
}
