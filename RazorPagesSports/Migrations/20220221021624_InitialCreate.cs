using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RazorPagesSports.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sports",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name_of_Game = table.Column<string>(type: "TEXT", nullable: true),
                    Uniform_Color = table.Column<string>(type: "TEXT", nullable: true),
                    Number_of_Player = table.Column<int>(type: "INTEGER", nullable: false),
                    First_Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sports", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sports");
        }
    }
}
