using Microsoft.EntityFrameworkCore.Migrations;

namespace Mattstone.Migrations
{
    public partial class Mattgration9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chore_AspNetUsers_UserId",
                table: "Chore");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Chore",
                newName: "UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_Chore_UserId",
                table: "Chore",
                newName: "IX_Chore_UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chore_AspNetUsers_UsersId",
                table: "Chore",
                column: "UsersId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chore_AspNetUsers_UsersId",
                table: "Chore");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "Chore",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Chore_UsersId",
                table: "Chore",
                newName: "IX_Chore_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chore_AspNetUsers_UserId",
                table: "Chore",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
