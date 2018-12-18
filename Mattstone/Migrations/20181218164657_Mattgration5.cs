using Microsoft.EntityFrameworkCore.Migrations;

namespace Mattstone.Migrations
{
    public partial class Mattgration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chore_Day_DayId",
                table: "Chore");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "15fd67f9-17d8-4222-8920-421794b452ac", "0adec16d-df0c-4976-91ac-13cd7be5d88b" });

            migrationBuilder.AlterColumn<int>(
                name: "DayId",
                table: "Chore",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FamilyId", "FamilyRole", "FirstName", "IsParent", "LastName", "UserHandle" },
                values: new object[] { "f16eac1a-6c21-4387-be16-c9fcbceff3bf", 0, "4bf0f5e9-e56c-4a22-88c9-fb393758bb91", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEKv2vIzACoYmls/U6xzIYBaYG1MvY1wPeD8hj53M+FwZIkif6zYqSHW930jVMaewEw==", null, false, "e0092e74-a5a9-4714-91f7-f5c579075847", false, "admin@admin.com", null, "papa", "admin", true, "admin", "adminGuy" });

            migrationBuilder.AddForeignKey(
                name: "FK_Chore_Day_DayId",
                table: "Chore",
                column: "DayId",
                principalTable: "Day",
                principalColumn: "DayId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chore_Day_DayId",
                table: "Chore");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "f16eac1a-6c21-4387-be16-c9fcbceff3bf", "4bf0f5e9-e56c-4a22-88c9-fb393758bb91" });

            migrationBuilder.AlterColumn<int>(
                name: "DayId",
                table: "Chore",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FamilyId", "FamilyRole", "FirstName", "IsParent", "LastName", "UserHandle" },
                values: new object[] { "15fd67f9-17d8-4222-8920-421794b452ac", 0, "0adec16d-df0c-4976-91ac-13cd7be5d88b", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEKa3NhXJlAl1f3zGPMXzhXYWFLMbPxnQdTVJMcWRaF9vVT1jpLg1JN2RF8vOIS18jA==", null, false, "e684426e-72b1-4d5e-93fd-44a7b9b5a439", false, "admin@admin.com", null, "papa", "admin", true, "admin", "adminGuy" });

            migrationBuilder.AddForeignKey(
                name: "FK_Chore_Day_DayId",
                table: "Chore",
                column: "DayId",
                principalTable: "Day",
                principalColumn: "DayId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
