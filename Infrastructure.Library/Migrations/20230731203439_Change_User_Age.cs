using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Library.Migrations
{
    /// <inheritdoc />
    public partial class Change_User_Age : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Age",
                schema: "SEC",
                table: "Users",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Age",
                schema: "SEC",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreateDate", "DeleteDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 30, 1, 40, 50, 196, DateTimeKind.Local).AddTicks(6225), new DateTime(2023, 7, 30, 1, 40, 50, 196, DateTimeKind.Local).AddTicks(6223), new DateTime(2023, 7, 30, 1, 40, 50, 196, DateTimeKind.Local).AddTicks(6209) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "CreateDate", "DeleteDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 30, 1, 40, 50, 196, DateTimeKind.Local).AddTicks(6260), new DateTime(2023, 7, 30, 1, 40, 50, 196, DateTimeKind.Local).AddTicks(6259), new DateTime(2023, 7, 30, 1, 40, 50, 196, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "CreateDate", "DeleteDate", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 30, 1, 40, 50, 196, DateTimeKind.Local).AddTicks(6277), new DateTime(2023, 7, 30, 1, 40, 50, 196, DateTimeKind.Local).AddTicks(6276), new DateTime(2023, 7, 30, 1, 40, 50, 196, DateTimeKind.Local).AddTicks(6275) });
        }
    }
}
