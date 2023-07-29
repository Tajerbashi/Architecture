using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Library.Migrations
{
    /// <inheritdoc />
    public partial class V2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreateDate", "DeleteDate", "IsDeleted", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 30, 1, 40, 50, 196, DateTimeKind.Local).AddTicks(6225), new DateTime(2023, 7, 30, 1, 40, 50, 196, DateTimeKind.Local).AddTicks(6223), false, new DateTime(2023, 7, 30, 1, 40, 50, 196, DateTimeKind.Local).AddTicks(6209) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "CreateDate", "DeleteDate", "IsDeleted", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 30, 1, 40, 50, 196, DateTimeKind.Local).AddTicks(6260), new DateTime(2023, 7, 30, 1, 40, 50, 196, DateTimeKind.Local).AddTicks(6259), false, new DateTime(2023, 7, 30, 1, 40, 50, 196, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "CreateDate", "DeleteDate", "IsDeleted", "UpdateDate" },
                values: new object[] { new DateTime(2023, 7, 30, 1, 40, 50, 196, DateTimeKind.Local).AddTicks(6277), new DateTime(2023, 7, 30, 1, 40, 50, 196, DateTimeKind.Local).AddTicks(6276), false, new DateTime(2023, 7, 30, 1, 40, 50, 196, DateTimeKind.Local).AddTicks(6275) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "CreateDate", "DeleteDate", "IsDeleted", "UpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "CreateDate", "DeleteDate", "IsDeleted", "UpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "SEC",
                table: "Roles",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "CreateDate", "DeleteDate", "IsDeleted", "UpdateDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
