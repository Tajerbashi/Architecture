using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Library.Migrations
{
    /// <inheritdoc />
    public partial class RelationalV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Groups_GroupUserRoles_GroupUserRoleID",
                schema: "SEC",
                table: "Groups");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRoles_GroupUserRoles_GroupUserRoleID",
                schema: "SEC",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_GroupUserRoleID",
                schema: "SEC",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupUserRoles",
                schema: "SEC",
                table: "GroupUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_Groups_GroupUserRoleID",
                schema: "SEC",
                table: "Groups");

            migrationBuilder.DropColumn(
                name: "GroupUserRoleID",
                schema: "SEC",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "GroupUserRoleID",
                schema: "SEC",
                table: "Groups");

            migrationBuilder.AlterColumn<long>(
                name: "UserRoleID",
                schema: "SEC",
                table: "GroupUserRoles",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "GroupID",
                schema: "SEC",
                table: "GroupUserRoles",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ID",
                schema: "SEC",
                table: "GroupUserRoles",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddUniqueConstraint(
                name: "AK_UserRoles_ID",
                schema: "SEC",
                table: "UserRoles",
                column: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupUserRoles",
                schema: "SEC",
                table: "GroupUserRoles",
                columns: new[] { "UserRoleID", "GroupID" });

            migrationBuilder.CreateIndex(
                name: "IX_GroupUserRoles_GroupID",
                schema: "SEC",
                table: "GroupUserRoles",
                column: "GroupID");

            migrationBuilder.AddForeignKey(
                name: "FK_GroupUserRoles_Groups_GroupID",
                schema: "SEC",
                table: "GroupUserRoles",
                column: "GroupID",
                principalSchema: "SEC",
                principalTable: "Groups",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GroupUserRoles_UserRoles_UserRoleID",
                schema: "SEC",
                table: "GroupUserRoles",
                column: "UserRoleID",
                principalSchema: "SEC",
                principalTable: "UserRoles",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GroupUserRoles_Groups_GroupID",
                schema: "SEC",
                table: "GroupUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_GroupUserRoles_UserRoles_UserRoleID",
                schema: "SEC",
                table: "GroupUserRoles");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_UserRoles_ID",
                schema: "SEC",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GroupUserRoles",
                schema: "SEC",
                table: "GroupUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_GroupUserRoles_GroupID",
                schema: "SEC",
                table: "GroupUserRoles");

            migrationBuilder.AddColumn<long>(
                name: "GroupUserRoleID",
                schema: "SEC",
                table: "UserRoles",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AlterColumn<long>(
                name: "ID",
                schema: "SEC",
                table: "GroupUserRoles",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "GroupID",
                schema: "SEC",
                table: "GroupUserRoles",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "UserRoleID",
                schema: "SEC",
                table: "GroupUserRoles",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<long>(
                name: "GroupUserRoleID",
                schema: "SEC",
                table: "Groups",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddPrimaryKey(
                name: "PK_GroupUserRoles",
                schema: "SEC",
                table: "GroupUserRoles",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_GroupUserRoleID",
                schema: "SEC",
                table: "UserRoles",
                column: "GroupUserRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Groups_GroupUserRoleID",
                schema: "SEC",
                table: "Groups",
                column: "GroupUserRoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_Groups_GroupUserRoles_GroupUserRoleID",
                schema: "SEC",
                table: "Groups",
                column: "GroupUserRoleID",
                principalSchema: "SEC",
                principalTable: "GroupUserRoles",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRoles_GroupUserRoles_GroupUserRoleID",
                schema: "SEC",
                table: "UserRoles",
                column: "GroupUserRoleID",
                principalSchema: "SEC",
                principalTable: "GroupUserRoles",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
