using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ABPosSolutions.TechnicalTest.Infrastructure.Migrations
{
    public partial class Insert_SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "Id", "Address", "BuildingName", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate" },
                values: new object[,]
                {
                    { "3bcf902f-399e-4a52-af6d-5a30dc702fc0", "Building 2", "Building 2", "d9d25759-2db6-4a02-80a4-dde2a685a196", new DateTime(2022, 4, 30, 4, 23, 8, 384, DateTimeKind.Utc).AddTicks(6804), null, null },
                    { "54f97371-d8a2-4201-b076-95d5f0bcc136", "Building 1", "Building 1", "d9d25759-2db6-4a02-80a4-dde2a685a196", new DateTime(2022, 4, 30, 4, 23, 8, 384, DateTimeKind.Utc).AddTicks(6813), null, null }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "StatusName" },
                values: new object[,]
                {
                    { "030CD480-A2CD-4986-B186-7281D3CE2153", "d9d25759-2db6-4a02-80a4-dde2a685a196", new DateTime(2022, 4, 30, 4, 23, 8, 384, DateTimeKind.Utc).AddTicks(7214), null, null, "Unsatisfactory" },
                    { "9A5851E2-A057-4477-9A0F-038928B17F83", "d9d25759-2db6-4a02-80a4-dde2a685a196", new DateTime(2022, 4, 30, 4, 23, 8, 384, DateTimeKind.Utc).AddTicks(7219), null, null, "Satisfactory" }
                });

            migrationBuilder.InsertData(
                table: "InspectionTypes",
                columns: new[] { "Id", "BuildingId", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "TypeName" },
                values: new object[] { "24C2BF02-EECF-4C23-8459-43B4F0A96019", "3bcf902f-399e-4a52-af6d-5a30dc702fc0", "d9d25759-2db6-4a02-80a4-dde2a685a196", new DateTime(2022, 4, 30, 4, 23, 8, 384, DateTimeKind.Utc).AddTicks(7073), null, null, "Technical Inspection" });

            migrationBuilder.InsertData(
                table: "InspectionTypes",
                columns: new[] { "Id", "BuildingId", "CreatedBy", "CreatedDate", "LastModifiedBy", "LastModifiedDate", "TypeName" },
                values: new object[] { "63F6CB37-A46F-450C-A5B7-63497088E594", "54f97371-d8a2-4201-b076-95d5f0bcc136", "d9d25759-2db6-4a02-80a4-dde2a685a196", new DateTime(2022, 4, 30, 4, 23, 8, 384, DateTimeKind.Utc).AddTicks(7078), null, null, "Formal Inspection" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InspectionTypes",
                keyColumn: "Id",
                keyValue: "24C2BF02-EECF-4C23-8459-43B4F0A96019");

            migrationBuilder.DeleteData(
                table: "InspectionTypes",
                keyColumn: "Id",
                keyValue: "63F6CB37-A46F-450C-A5B7-63497088E594");

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: "030CD480-A2CD-4986-B186-7281D3CE2153");

            migrationBuilder.DeleteData(
                table: "Statuses",
                keyColumn: "Id",
                keyValue: "9A5851E2-A057-4477-9A0F-038928B17F83");

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: "3bcf902f-399e-4a52-af6d-5a30dc702fc0");

            migrationBuilder.DeleteData(
                table: "Buildings",
                keyColumn: "Id",
                keyValue: "54f97371-d8a2-4201-b076-95d5f0bcc136");
        }
    }
}
