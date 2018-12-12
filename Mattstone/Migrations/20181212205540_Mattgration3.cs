using Microsoft.EntityFrameworkCore.Migrations;

namespace Mattstone.Migrations
{
    public partial class Mattgration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "347eb623-321f-4afd-a275-5580e7cab005", "963cc917-fa87-4732-b672-e1351966b599" });

            migrationBuilder.AddColumn<string>(
                name: "UserHandle",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FamilyId", "FamilyRole", "FirstName", "LastName", "UserHandle" },
                values: new object[] { "03294b8a-9e67-49d3-aef0-eae39ca42afb", 0, "26156491-4739-4e2b-ad57-3462e8743363", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEJI0qDLYcW7Y/iUcWJdyVSck2CECz+xwQI0Mg9xkK7forGhLy79tqF+9xt1H/W1inw==", null, false, "256670b7-cbb3-4e37-a4fa-b60202fc730f", false, "admin@admin.com", null, "papa", "admin", "admin", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "03294b8a-9e67-49d3-aef0-eae39ca42afb", "26156491-4739-4e2b-ad57-3462e8743363" });

            migrationBuilder.DropColumn(
                name: "UserHandle",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FamilyId", "FamilyRole", "FirstName", "LastName" },
                values: new object[] { "347eb623-321f-4afd-a275-5580e7cab005", 0, "963cc917-fa87-4732-b672-e1351966b599", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEC69jFIm/YolITeghajlTJu6A7ZFUQqSYt34IkdqZVC74Ak/gWJ4J4zUo8/KF4TVrQ==", null, false, "d0e98f5c-6bf0-4431-a5fc-9395d68298ed", false, "admin@admin.com", null, "papa", "admin", "admin" });
        }
    }
}
