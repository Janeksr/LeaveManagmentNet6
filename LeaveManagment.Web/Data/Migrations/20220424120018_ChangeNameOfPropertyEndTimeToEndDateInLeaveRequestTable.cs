using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    public partial class ChangeNameOfPropertyEndTimeToEndDateInLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "LeaveRequests",
                newName: "EndDate");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1951852-04a8-4eef-9538-13b21627a185",
                column: "ConcurrencyStamp",
                value: "73b46fce-a179-4198-9f5a-772af486c688");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1951852-04c8-2eef-9238-13b31627b185",
                column: "ConcurrencyStamp",
                value: "6cc298d6-7be5-469f-a73f-426cb0f47258");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119acbc4-bb39-426b-b645-160c3ef3c3a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9014b084-4c17-4541-ad80-2befc8ff9f49", "AQAAAAEAACcQAAAAEP8Xx5XMy0NLGlcycHUaflr45NxqDs8thdpXrRYG+uLWH0Snw2GCaIowIjUsfK8zDA==", "615ac0fd-9a3c-4908-ad79-df53d044470b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119acbc4-bb39-436b-a66e-b60c6d634395",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cdf5a9fa-e6b7-4306-91dd-00276c6186c2", "AQAAAAEAACcQAAAAEGGA3QN43YaWDCw2hmf2D/98GIlexO9e4hbKZ0OwaubunFTJedZTfcTlVBM38eIbxw==", "8eee738e-5e63-4d05-8503-70f9fc8d1193" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EndDate",
                table: "LeaveRequests",
                newName: "EndTime");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1951852-04a8-4eef-9538-13b21627a185",
                column: "ConcurrencyStamp",
                value: "8aecc82c-f81d-48be-b421-64d601a90fb8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1951852-04c8-2eef-9238-13b31627b185",
                column: "ConcurrencyStamp",
                value: "f067f050-7c6d-4c2b-aa9f-8cd060370a40");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119acbc4-bb39-426b-b645-160c3ef3c3a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58a46396-98ab-4ac4-ab61-0fe08e4b3e69", "AQAAAAEAACcQAAAAEO7rRzkrof1aoVyjkGvnK5bJY0CkV1J+FStuPuG153mJo/+A6QYuJ8ghoLVbUia6gw==", "5a4e6e27-3585-454a-9118-2009a40929fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119acbc4-bb39-436b-a66e-b60c6d634395",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea74d5c1-2e98-4b0c-b013-47f81fd71654", "AQAAAAEAACcQAAAAEHkL+TJ7bMhcYdIwT5ftUGSVpYJhdpoZA2zMaDVWY9gOgR4qe/5vPHIkaO9n8dk4SQ==", "9781b368-478c-4ab6-89f5-10d828664845" });
        }
    }
}
