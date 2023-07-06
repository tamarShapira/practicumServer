using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class changes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ChildParentId",
                table: "Child",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Child_ChildParentId",
                table: "Child",
                column: "ChildParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Child_Parent_ChildParentId",
                table: "Child",
                column: "ChildParentId",
                principalTable: "Parent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Child_Parent_ChildParentId",
                table: "Child");

            migrationBuilder.DropIndex(
                name: "IX_Child_ChildParentId",
                table: "Child");

            migrationBuilder.AlterColumn<string>(
                name: "ChildParentId",
                table: "Child",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
