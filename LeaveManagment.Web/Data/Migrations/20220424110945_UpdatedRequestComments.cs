using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1951852-04a8-4eef-9538-13b21627a185",
                column: "ConcurrencyStamp",
                value: "cbb6af63-cf18-442a-b079-d1a073cb2fe6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1951852-04c8-2eef-9238-13b31627b185",
                column: "ConcurrencyStamp",
                value: "92fcc249-b803-4e6b-a07b-e55f1262972f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119acbc4-bb39-426b-b645-160c3ef3c3a5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3422de78-a4c8-42d5-a92e-f35b5a39af9d", "AQAAAAEAACcQAAAAEATT8dsr/yXM+9Dwsr0OECzz/dIvxEfmuh1k9k60jjXzy2McsbsNjiQ37X4bwez3kQ==", "1ed05b75-d795-4974-9fa1-4e5ec5070964" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119acbc4-bb39-436b-a66e-b60c6d634395",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8c0ce99-afe2-4459-897b-11abff7ee0a6", "AQAAAAEAACcQAAAAEKl1ATEhscpH1PQtqQDjKJUsI/A01z9ATYC1c/aMgpTUfK34AjnioHxDy2RJA1YigQ==", "3e63d19b-0a49-44ba-a12e-3168660cf86b" });
        }
    }
}
