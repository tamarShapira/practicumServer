using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class listOfChildren : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Child_Parent_ChildParentId",
                table: "Child");

            migrationBuilder.RenameColumn(
                name: "ChildParentId",
                table: "Child",
                newName: "ParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Child_ChildParentId",
                table: "Child",
                newName: "IX_Child_ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Child_Parent_ParentId",
                table: "Child",
                column: "ParentId",
                principalTable: "Parent",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Child_Parent_ParentId",
                table: "Child");

            migrationBuilder.RenameColumn(
                name: "ParentId",
                table: "Child",
                newName: "ChildParentId");

            migrationBuilder.RenameIndex(
                name: "IX_Child_ParentId",
                table: "Child",
                newName: "IX_Child_ChildParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Child_Parent_ChildParentId",
                table: "Child",
                column: "ChildParentId",
                principalTable: "Parent",
                principalColumn: "Id");
        }
    }
}
