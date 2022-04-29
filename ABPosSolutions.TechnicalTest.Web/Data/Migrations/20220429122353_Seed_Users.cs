using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABPosSolutions.TechnicalTest.Web.Data.Migrations
{
    public partial class Seed_Users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "107b9d7e-7d8d-466f-bc51-db8f9c52706b", "aa3f86a1-8d1b-4b7e-a584-7ef54ead975c", "Admin", "Admin" },
                    { "71c1036c-3617-480a-9e6f-fec4d5ad7a89", "99cd7c51-1f2b-4f78-a1dd-6c99fe7c8149", "Inspector", "INSPECTOR" },
                    { "854fbbba-f694-43a5-a73e-96b956e74ce0", "a06a8275-e2d5-44ec-bcc3-389c77b16c57", "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5895cd79-0c1d-43f1-b2d6-fb2509c5c1a0", 0, "53b58615-7b4e-4e3c-b414-20fab03430b9", "ApplicationUser", "inspector@localhost.com", false, "Inspector", false, null, "Inspector", "inspector@localhost.com", "inspector", "AQAAAAEAACcQAAAAEP/a6lqM4ZTzWmJ/fihxrXlqSUjFCJ7AR2CZh4G17jpZvmkR7S7qdzTSUdSJ4JcZPg==", null, false, "6b542ebd-dd7c-42f0-9874-edf770fb0a53", false, "inspector" },
                    { "669c8f71-36b0-4342-bf34-e828a143e672", 0, "66660529-2846-4b07-bd7b-b31dc24d6b9f", "ApplicationUser", "admin@localhost.com", false, "Administrator", false, null, "Administrator", "admin@localhost.com", "admin", "AQAAAAEAACcQAAAAEBTtWzFh82QrBK0W/QNsvIV+EImF6r5QEhI3ulJgu667ls3iw1+kecUy/XHznKFarQ==", null, false, "f67751b2-b779-4d7f-ab3c-25b590a63656", false, "admin" },
                    { "d9d25759-2db6-4a02-80a4-dde2a685a196", 0, "97308887-5105-47f2-9bda-4c7878c3a18a", "ApplicationUser", "supervisor@localhost.com", false, "Supervisor", false, null, "Supervisor", "supervisor@localhost.com", "supervisor", "AQAAAAEAACcQAAAAED6dZl6IvEx6vCQvxqq2+D4+GBZAV8ssaQVtiX9SUjR6U4fJgjulKaZawF/uT8JgPw==", null, false, "3674ff37-6cc5-4080-9109-261e82c5d02b", false, "supervisor" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "71c1036c-3617-480a-9e6f-fec4d5ad7a89", "5895cd79-0c1d-43f1-b2d6-fb2509c5c1a0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "107b9d7e-7d8d-466f-bc51-db8f9c52706b", "669c8f71-36b0-4342-bf34-e828a143e672" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "854fbbba-f694-43a5-a73e-96b956e74ce0", "d9d25759-2db6-4a02-80a4-dde2a685a196" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "71c1036c-3617-480a-9e6f-fec4d5ad7a89", "5895cd79-0c1d-43f1-b2d6-fb2509c5c1a0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "107b9d7e-7d8d-466f-bc51-db8f9c52706b", "669c8f71-36b0-4342-bf34-e828a143e672" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "854fbbba-f694-43a5-a73e-96b956e74ce0", "d9d25759-2db6-4a02-80a4-dde2a685a196" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "107b9d7e-7d8d-466f-bc51-db8f9c52706b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71c1036c-3617-480a-9e6f-fec4d5ad7a89");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "854fbbba-f694-43a5-a73e-96b956e74ce0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5895cd79-0c1d-43f1-b2d6-fb2509c5c1a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "669c8f71-36b0-4342-bf34-e828a143e672");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d9d25759-2db6-4a02-80a4-dde2a685a196");
        }
    }
}
