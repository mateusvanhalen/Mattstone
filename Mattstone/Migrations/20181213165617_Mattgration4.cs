using Microsoft.EntityFrameworkCore.Migrations;

namespace Mattstone.Migrations
{
    public partial class Mattgration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "03294b8a-9e67-49d3-aef0-eae39ca42afb", "26156491-4739-4e2b-ad57-3462e8743363" });

            migrationBuilder.AddColumn<bool>(
                name: "IsParent",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FamilyId", "FamilyRole", "FirstName", "IsParent", "LastName", "UserHandle" },
                values: new object[] { "15fd67f9-17d8-4222-8920-421794b452ac", 0, "0adec16d-df0c-4976-91ac-13cd7be5d88b", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEKa3NhXJlAl1f3zGPMXzhXYWFLMbPxnQdTVJMcWRaF9vVT1jpLg1JN2RF8vOIS18jA==", null, false, "e684426e-72b1-4d5e-93fd-44a7b9b5a439", false, "admin@admin.com", null, "papa", "admin", true, "admin", "adminGuy" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "15fd67f9-17d8-4222-8920-421794b452ac", "0adec16d-df0c-4976-91ac-13cd7be5d88b" });

            migrationBuilder.DropColumn(
                name: "IsParent",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FamilyId", "FamilyRole", "FirstName", "LastName", "UserHandle" },
                values: new object[] { "03294b8a-9e67-49d3-aef0-eae39ca42afb", 0, "26156491-4739-4e2b-ad57-3462e8743363", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJI0qDLYcW7Y/iUcWJdyVSck2CECz+xwQI0Mg9xkK7forGhLy79tqF+9xt1H/W1inw==", null, false, "256670b7-cbb3-4e37-a4fa-b60202fc730f", false, "admin@admin.com", null, "papa", "admin", "admin", null });
        }
    }
}
