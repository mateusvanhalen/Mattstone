using Microsoft.EntityFrameworkCore.Migrations;

namespace Mattstone.Migrations
{
    public partial class Mattgration8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Chore_DayId",
                table: "Chore");

            migrationBuilder.CreateIndex(
                name: "IX_Chore_DayId",
                table: "Chore",
                column: "DayId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Chore_DayId",
                table: "Chore");

            migrationBuilder.CreateIndex(
                name: "IX_Chore_DayId",
                table: "Chore",
                column: "DayId",
                unique: true);
        }
    }
}
