using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class changes2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Child_Parent_ChildParentId",
                table: "Child");

            migrationBuilder.AlterColumn<int>(
                name: "ChildParentId",
                table: "Child",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Child_Parent_ChildParentId",
                table: "Child",
                column: "ChildParentId",
                principalTable: "Parent",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Child_Parent_ChildParentId",
                table: "Child");

            migrationBuilder.AlterColumn<int>(
                name: "ChildParentId",
                table: "Child",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Child_Parent_ChildParentId",
                table: "Child",
                column: "ChildParentId",
                principalTable: "Parent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
