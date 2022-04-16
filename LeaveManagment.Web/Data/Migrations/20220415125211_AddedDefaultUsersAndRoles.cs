using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a1951852-04a8-4eef-9538-13b21627a185", "9ddb444e-3284-4f83-98dd-ce8721a77182", "Administrator", "ADMINSTRATOR" },
                    { "a1951852-04c8-2eef-9238-13b31627b185", "3ccc932d-6c63-4472-955f-3209f22582fc", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "119acbc4-bb39-426b-b645-160c3ef3c3a5", 0, "804bd6f9-560b-465f-be6b-f417d870607d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAELE7NKmHN/fl4Httgw6Avyrz5dR4TakvtuXZdg6F1L7NuPxQ+SXxuS/WYaemUx7h8w==", null, false, "6b8bb100-b574-4030-b510-a1ebb64ef81c", null, false, null },
                    { "119acbc4-bb39-436b-a66e-b60c6d634395", 0, "75bcf4a3-4fae-4694-a84f-1eae04723a5f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEEmDpMbgSooYOJYS8ZGJ5ZkcXS7dZ6wkR+hIjg44D38gOKc1fcNEAu/Hiyprjy8LDA==", null, false, "fc1d06b5-05b0-40fd-809e-b23dc269486c", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a1951852-04c8-2eef-9238-13b31627b185", "119acbc4-bb39-426b-b645-160c3ef3c3a5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a1951852-04a8-4eef-9538-13b21627a185", "119acbc4-bb39-436b-a66e-b60c6d634395" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a1951852-04c8-2eef-9238-13b31627b185", "119acbc4-bb39-426b-b645-160c3ef3c3a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a1951852-04a8-4eef-9538-13b21627a185", "119acbc4-bb39-436b-a66e-b60c6d634395" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1951852-04a8-4eef-9538-13b21627a185");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1951852-04c8-2eef-9238-13b31627b185");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119acbc4-bb39-426b-b645-160c3ef3c3a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119acbc4-bb39-436b-a66e-b60c6d634395");
        }
    }
}
