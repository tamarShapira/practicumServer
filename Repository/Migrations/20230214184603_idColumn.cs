using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class idColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Parent",
                table: "Parent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Child",
                table: "Child");

            migrationBuilder.AlterColumn<string>(
                name: "ParentId",
                table: "Parent",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Parent",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "ChildId",
                table: "Child",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Child",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parent",
                table: "Parent",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Child",
                table: "Child",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Parent",
                table: "Parent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Child",
                table: "Child");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Parent");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Child");

            migrationBuilder.AlterColumn<string>(
                name: "ParentId",
                table: "Parent",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ChildId",
                table: "Child",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parent",
                table: "Parent",
                column: "ParentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Child",
                table: "Child",
                column: "ChildId");
        }
    }
}
