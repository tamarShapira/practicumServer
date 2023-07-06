using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class childParentId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Parent_Child_ChildId",
                table: "Parent");

            migrationBuilder.DropIndex(
                name: "IX_Parent_ChildId",
                table: "Parent");

            migrationBuilder.DropColumn(
                name: "ChildId",
                table: "Parent");

            migrationBuilder.AddColumn<string>(
                name: "ChildParentId",
                table: "Child",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildParentId",
                table: "Child");

            migrationBuilder.AddColumn<string>(
                name: "ChildId",
                table: "Parent",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Parent_ChildId",
                table: "Parent",
                column: "ChildId");

            migrationBuilder.AddForeignKey(
                name: "FK_Parent_Child_ChildId",
                table: "Parent",
                column: "ChildId",
                principalTable: "Child",
                principalColumn: "ChildId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
