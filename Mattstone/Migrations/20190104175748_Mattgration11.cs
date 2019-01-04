using Microsoft.EntityFrameworkCore.Migrations;

namespace Mattstone.Migrations
{
    public partial class Mattgration11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserHandle",
                table: "Day",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserHandle",
                table: "Chore",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserHandle",
                table: "Day");

            migrationBuilder.DropColumn(
                name: "UserHandle",
                table: "Chore");
        }
    }
}
