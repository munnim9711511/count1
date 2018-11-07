using Microsoft.EntityFrameworkCore.Migrations;

namespace Coun.Migrations
{
    public partial class anouncement_db_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Catogary",
                table: "anouncementsModels",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Catogary",
                table: "anouncementsModels");
        }
    }
}
