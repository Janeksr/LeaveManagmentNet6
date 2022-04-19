using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1951852-04a8-4eef-9538-13b21627a185",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "5d10ae46-d83c-4d70-ab28-a099458c0dac", "ADMINISTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1951852-04c8-2eef-9238-13b31627b185",
                column: "ConcurrencyStamp",
                value: "9a09596f-1bb5-4f56-b3f9-ae0d74e59ca3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119acbc4-bb39-426b-b645-160c3ef3c3a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "348f3eef-cacf-4d65-a73a-bb11988d523c", "AQAAAAEAACcQAAAAEAkxQel/SVeJPzLVpiVnTUYbN0rrP/hlzbPFyHsv9/KBVnzVYnEIcRxAjEEBPcnTSg==", "13d3f715-6307-4686-8981-6b8ded6a2ec4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119acbc4-bb39-436b-a66e-b60c6d634395",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12a8a43c-1b72-4955-bbd0-ddad9ed0fea7", "AQAAAAEAACcQAAAAEC8VqNEpxgp37FngCLGCbE/8s82cSeMOvKZvYf1N8NoweG9LGN1O+ftYCq43Z2z9dw==", "4fda1051-f7cb-40dc-b785-4ae154e33706" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1951852-04a8-4eef-9538-13b21627a185",
                columns: new[] { "ConcurrencyStamp", "NormalizedName" },
                values: new object[] { "caa2dfee-2cc2-48fe-8075-abc87bcf12fe", "ADMINSTRATOR" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1951852-04c8-2eef-9238-13b31627b185",
                column: "ConcurrencyStamp",
                value: "5961b8f2-bde6-4a73-b38e-5bb09fd651c2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119acbc4-bb39-426b-b645-160c3ef3c3a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3662c3f-141c-4101-bd4b-361ed5821496", "AQAAAAEAACcQAAAAEDXzylGySNi9XirGddGEEVntDmiV8Q40SEK+l7JBsXo/82T5h9/9g/ZtgAwdA8s5Cw==", "60c44c6a-44d4-455a-93ad-196a91d17950" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119acbc4-bb39-436b-a66e-b60c6d634395",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3083240f-cbf3-4d24-a0db-be26c31639a1", "AQAAAAEAACcQAAAAEEmBJiv5MZSsrEeUZh3mLh/dtwd5AjctuckCFozzHqwgXYe4brlA6OKeGH4uS2dXjg==", "568dfe7f-9e98-41e7-b188-f9a54f5cee08" });
        }
    }
}
