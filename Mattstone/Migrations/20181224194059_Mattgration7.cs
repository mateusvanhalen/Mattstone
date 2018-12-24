using Microsoft.EntityFrameworkCore.Migrations;

namespace Mattstone.Migrations
{
    public partial class Mattgration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Chore_DayId",
                table: "Chore");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "1858467e-8ede-4360-8dce-e6e52af52267", "fd2b2715-90bc-4cff-91bd-f7ebcffc66f6" });

            migrationBuilder.AddColumn<int>(
                name: "DayId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Chore_DayId",
                table: "Chore",
                column: "DayId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DayId",
                table: "AspNetUsers",
                column: "DayId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Day_DayId",
                table: "AspNetUsers",
                column: "DayId",
                principalTable: "Day",
                principalColumn: "DayId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Day_DayId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_Chore_DayId",
                table: "Chore");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DayId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DayId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FamilyId", "FamilyRole", "FirstName", "IsParent", "LastName", "UserHandle" },
                values: new object[] { "1858467e-8ede-4360-8dce-e6e52af52267", 0, "fd2b2715-90bc-4cff-91bd-f7ebcffc66f6", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEBCTAwJbQzN+Ji+emiYv1R376avkr1X8Wnn3Jwnr9e47NoOLDUYDluQanjjPmPU/IA==", null, false, "29ce41c3-b50a-4a98-a01b-4bea1a2c9ad3", false, "admin@admin.com", null, "papa", "admin", true, "admin", "adminGuy" });

            migrationBuilder.CreateIndex(
                name: "IX_Chore_DayId",
                table: "Chore",
                column: "DayId");
        }
    }
}
