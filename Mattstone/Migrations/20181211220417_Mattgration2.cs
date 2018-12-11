using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Mattstone.Migrations
{
    public partial class Mattgration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "d22d94ba-5b15-4350-8fdc-da394865ab95", "52646210-f08c-483b-bf36-a2cd578315a1" });

            migrationBuilder.CreateTable(
                name: "Day",
                columns: table => new
                {
                    DayId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DayName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Day", x => x.DayId);
                });

            migrationBuilder.CreateTable(
                name: "Chore",
                columns: table => new
                {
                    ChoreId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ChoreName = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    Done = table.Column<bool>(nullable: false),
                    DayId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chore", x => x.ChoreId);
                    table.ForeignKey(
                        name: "FK_Chore_Day_DayId",
                        column: x => x.DayId,
                        principalTable: "Day",
                        principalColumn: "DayId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chore_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FamilyId", "FamilyRole", "FirstName", "LastName" },
                values: new object[] { "347eb623-321f-4afd-a275-5580e7cab005", 0, "963cc917-fa87-4732-b672-e1351966b599", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEC69jFIm/YolITeghajlTJu6A7ZFUQqSYt34IkdqZVC74Ak/gWJ4J4zUo8/KF4TVrQ==", null, false, "d0e98f5c-6bf0-4431-a5fc-9395d68298ed", false, "admin@admin.com", null, "papa", "admin", "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Chore_DayId",
                table: "Chore",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Chore_UserId",
                table: "Chore",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chore");

            migrationBuilder.DropTable(
                name: "Day");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { "347eb623-321f-4afd-a275-5580e7cab005", "963cc917-fa87-4732-b672-e1351966b599" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FamilyId", "FamilyRole", "FirstName", "LastName" },
                values: new object[] { "d22d94ba-5b15-4350-8fdc-da394865ab95", 0, "52646210-f08c-483b-bf36-a2cd578315a1", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEHDopJlGGF76J2Qgtv/5RS7XJj1zRqdTR+E4E/eeP7jYvIHk6eE936CeQLFVLToNqQ==", null, false, "d11e57a5-10ac-4469-8ab7-96b48f8615bd", false, "admin@admin.com", null, "papa", "admin", "admin" });
        }
    }
}
