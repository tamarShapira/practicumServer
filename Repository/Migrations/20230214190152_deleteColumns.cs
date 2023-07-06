using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class deleteColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChildFirstName",
                table: "Child");

            migrationBuilder.DropColumn(
                name: "ChildHMO",
                table: "Child");

            migrationBuilder.DropColumn(
                name: "ChildLastName",
                table: "Child");

            migrationBuilder.RenameColumn(
                name: "ChildSpecies",
                table: "Child",
                newName: "ChildName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ChildName",
                table: "Child",
                newName: "ChildSpecies");

            migrationBuilder.AddColumn<string>(
                name: "ChildFirstName",
                table: "Child",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ChildHMO",
                table: "Child",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ChildLastName",
                table: "Child",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
