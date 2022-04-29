using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABPosSolutions.TechnicalTest.Web.Data.Migrations
{
    public partial class UpdatePropertyValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "107b9d7e-7d8d-466f-bc51-db8f9c52706b",
                column: "ConcurrencyStamp",
                value: "7f203297-c979-42f2-8e88-6bbadddff509");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71c1036c-3617-480a-9e6f-fec4d5ad7a89",
                column: "ConcurrencyStamp",
                value: "364be93d-d455-4067-b51c-d015af27562d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "854fbbba-f694-43a5-a73e-96b956e74ce0",
                column: "ConcurrencyStamp",
                value: "e1cd0bda-14b4-451c-896b-f3c445453939");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5895cd79-0c1d-43f1-b2d6-fb2509c5c1a0",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "97d64c63-62f0-4e2e-a553-f92cca569783", "inspector@localhost.com", "AQAAAAEAACcQAAAAEHM1hlYdO4+p9XiQh9G77dpQb0t1CqF+iieQJQqmJTckk65ZyCtRs2ONyfw8F4YhXQ==", "4862a1ce-fdf6-4ff2-95f5-dfc6a925db90", "inspector@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "669c8f71-36b0-4342-bf34-e828a143e672",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0ffccb28-d3a4-4b37-8d15-89237e1fa8e8", "admin@localhost.com", "AQAAAAEAACcQAAAAEJsFhn2lfAMBqJ/3KHa9E+bB1i31GCuQTFwns8+hNyOaSGp4TbkZXRGl8wKnmbUO9Q==", "d5880573-4547-4874-8dda-b4cfd7479af7", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d9d25759-2db6-4a02-80a4-dde2a685a196",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b0df7969-3bf3-4599-96a7-6f946ed353c5", "supervisor@localhost.com", "AQAAAAEAACcQAAAAEOHKrDS6+3z3Mcwsv2x7tKXM9ZMFxVkSc4kgsSN+dLfGTUaYTghcmSEQ7qocpep/WA==", "30765619-c1ab-45f7-bd0b-4e80259fd0ac", "supervisor@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "107b9d7e-7d8d-466f-bc51-db8f9c52706b",
                column: "ConcurrencyStamp",
                value: "aa3f86a1-8d1b-4b7e-a584-7ef54ead975c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "71c1036c-3617-480a-9e6f-fec4d5ad7a89",
                column: "ConcurrencyStamp",
                value: "99cd7c51-1f2b-4f78-a1dd-6c99fe7c8149");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "854fbbba-f694-43a5-a73e-96b956e74ce0",
                column: "ConcurrencyStamp",
                value: "a06a8275-e2d5-44ec-bcc3-389c77b16c57");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5895cd79-0c1d-43f1-b2d6-fb2509c5c1a0",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "53b58615-7b4e-4e3c-b414-20fab03430b9", "inspector", "AQAAAAEAACcQAAAAEP/a6lqM4ZTzWmJ/fihxrXlqSUjFCJ7AR2CZh4G17jpZvmkR7S7qdzTSUdSJ4JcZPg==", "6b542ebd-dd7c-42f0-9874-edf770fb0a53", "inspector" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "669c8f71-36b0-4342-bf34-e828a143e672",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "66660529-2846-4b07-bd7b-b31dc24d6b9f", "admin", "AQAAAAEAACcQAAAAEBTtWzFh82QrBK0W/QNsvIV+EImF6r5QEhI3ulJgu667ls3iw1+kecUy/XHznKFarQ==", "f67751b2-b779-4d7f-ab3c-25b590a63656", "admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d9d25759-2db6-4a02-80a4-dde2a685a196",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "97308887-5105-47f2-9bda-4c7878c3a18a", "supervisor", "AQAAAAEAACcQAAAAED6dZl6IvEx6vCQvxqq2+D4+GBZAV8ssaQVtiX9SUjR6U4fJgjulKaZawF/uT8JgPw==", "3674ff37-6cc5-4080-9109-261e82c5d02b", "supervisor" });
        }
    }
}
