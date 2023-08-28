using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Library.Migrations
{
    /// <inheritdoc />
    public partial class Create_RPT_LOG : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "RPT");

            migrationBuilder.EnsureSchema(
                name: "LOG");

            migrationBuilder.CreateTable(
                name: "GeneralReports",
                schema: "RPT",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    table.PrimaryKey("PK_GeneralReports", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SystemLogger",
                schema: "LOG",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Event = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exception = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Error = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Service = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsSuccess = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_SystemLogger", x => x.ID);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GeneralReports",
                schema: "RPT");

            migrationBuilder.DropTable(
                name: "SystemLogger",
                schema: "LOG");

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreateDate", "DeleteDate" },
                values: new object[] { new DateTime(2023, 8, 28, 1, 13, 28, 144, DateTimeKind.Local).AddTicks(1889), new DateTime(2023, 8, 28, 1, 13, 28, 144, DateTimeKind.Local).AddTicks(1904) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "CreateDate", "DeleteDate" },
                values: new object[] { new DateTime(2023, 8, 28, 1, 13, 28, 144, DateTimeKind.Local).AddTicks(1942), new DateTime(2023, 8, 28, 1, 13, 28, 144, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "CreateDate", "DeleteDate" },
                values: new object[] { new DateTime(2023, 8, 28, 1, 13, 28, 144, DateTimeKind.Local).AddTicks(1962), new DateTime(2023, 8, 28, 1, 13, 28, 144, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "UserRoles",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreateDate", "DeleteDate" },
                values: new object[] { new DateTime(2023, 8, 28, 1, 13, 28, 144, DateTimeKind.Local).AddTicks(2031), new DateTime(2023, 8, 28, 1, 13, 28, 144, DateTimeKind.Local).AddTicks(2032) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Users",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreateDate", "DeleteDate" },
                values: new object[] { new DateTime(2023, 8, 28, 1, 13, 28, 144, DateTimeKind.Local).AddTicks(2061), new DateTime(2023, 8, 28, 1, 13, 28, 144, DateTimeKind.Local).AddTicks(2061) });
        }
    }
}
