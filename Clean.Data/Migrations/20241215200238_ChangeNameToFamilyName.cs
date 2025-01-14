using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.Data.Migrations
{
    public partial class ChangeNameToFamilyName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "prisoners",
                newName: "FamilyName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FamilyName",
                table: "prisoners",
                newName: "Name");
        }
    }
}
