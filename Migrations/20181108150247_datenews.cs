using Microsoft.EntityFrameworkCore.Migrations;

namespace Coun.Migrations
{
    public partial class datenews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "NewsModels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "NewsModels");
        }
    }
}
