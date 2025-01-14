using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Clean.Data.Migrations
{
    public partial class CreatDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "guards",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Professional_Level = table.Column<int>(type: "int", nullable: false),
                    PrisonToFloor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_guards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "prisoners",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    YearsInPrison = table.Column<int>(type: "int", nullable: false),
                    Meals = table.Column<int>(type: "int", nullable: false),
                    Level1_10 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_prisoners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Well_groomed = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tiny_Neglected = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "guards");

            migrationBuilder.DropTable(
                name: "prisoners");

            migrationBuilder.DropTable(
                name: "rooms");
        }
    }
}
