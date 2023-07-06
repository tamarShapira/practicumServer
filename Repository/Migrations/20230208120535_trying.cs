using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class trying : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Child",
                columns: table => new
                {
                    ChildId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChildFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChildLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChildDOB = table.Column<DateTime>(type: "date", nullable: false),
                    ChildSpecies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChildHMO = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Child", x => x.ChildId);
                });

            migrationBuilder.CreateTable(
                name: "Parent",
                columns: table => new
                {
                    ParentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ParentFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentDOB = table.Column<DateTime>(type: "date", nullable: false),
                    ParentSpecies = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentHMO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChildId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parent", x => x.ParentId);
                    table.ForeignKey(
                        name: "FK_Parent_Child_ChildId",
                        column: x => x.ChildId,
                        principalTable: "Child",
                        principalColumn: "ChildId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Parent_ChildId",
                table: "Parent",
                column: "ChildId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parent");

            migrationBuilder.DropTable(
                name: "Child");
        }
    }
}
