using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Library.Migrations
{
    /// <inheritdoc />
    public partial class MenuLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserRoles_ID",
                schema: "SEC",
                table: "UserRoles");

            migrationBuilder.CreateTable(
                name: "MenuLinks",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<long>(type: "bigint", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedByUserRoleID = table.Column<long>(type: "bigint", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateByUserRoleID = table.Column<long>(type: "bigint", nullable: false),
                    DeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeleteByUserID = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RowGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuLinks", x => x.ID);
                });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreateDate", "DeleteDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 8, 13, 240, DateTimeKind.Local).AddTicks(5467), new DateTime(2023, 8, 6, 22, 8, 13, 240, DateTimeKind.Local).AddTicks(5465), new DateTime(2023, 8, 6, 22, 8, 13, 240, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "CreateDate", "DeleteDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 8, 13, 240, DateTimeKind.Local).AddTicks(5499), new DateTime(2023, 8, 6, 22, 8, 13, 240, DateTimeKind.Local).AddTicks(5498), new DateTime(2023, 8, 6, 22, 8, 13, 240, DateTimeKind.Local).AddTicks(5498) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "CreateDate", "DeleteDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 6, 22, 8, 13, 240, DateTimeKind.Local).AddTicks(5516), new DateTime(2023, 8, 6, 22, 8, 13, 240, DateTimeKind.Local).AddTicks(5515), new DateTime(2023, 8, 6, 22, 8, 13, 240, DateTimeKind.Local).AddTicks(5514) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuLinks");

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreateDate", "DeleteDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 1, 0, 4, 39, 359, DateTimeKind.Local).AddTicks(7817), new DateTime(2023, 8, 1, 0, 4, 39, 359, DateTimeKind.Local).AddTicks(7815), new DateTime(2023, 8, 1, 0, 4, 39, 359, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "CreateDate", "DeleteDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 1, 0, 4, 39, 359, DateTimeKind.Local).AddTicks(7854), new DateTime(2023, 8, 1, 0, 4, 39, 359, DateTimeKind.Local).AddTicks(7854), new DateTime(2023, 8, 1, 0, 4, 39, 359, DateTimeKind.Local).AddTicks(7853) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "CreateDate", "DeleteDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 8, 1, 0, 4, 39, 359, DateTimeKind.Local).AddTicks(7873), new DateTime(2023, 8, 1, 0, 4, 39, 359, DateTimeKind.Local).AddTicks(7872), new DateTime(2023, 8, 1, 0, 4, 39, 359, DateTimeKind.Local).AddTicks(7872) });

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_ID",
                schema: "SEC",
                table: "UserRoles",
                column: "ID",
                unique: true);
        }
    }
}
