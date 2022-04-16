using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1951852-04a8-4eef-9538-13b21627a185",
                column: "ConcurrencyStamp",
                value: "caa2dfee-2cc2-48fe-8075-abc87bcf12fe");

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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "e3662c3f-141c-4101-bd4b-361ed5821496", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEDXzylGySNi9XirGddGEEVntDmiV8Q40SEK+l7JBsXo/82T5h9/9g/ZtgAwdA8s5Cw==", "60c44c6a-44d4-455a-93ad-196a91d17950", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119acbc4-bb39-436b-a66e-b60c6d634395",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "3083240f-cbf3-4d24-a0db-be26c31639a1", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEEmBJiv5MZSsrEeUZh3mLh/dtwd5AjctuckCFozzHqwgXYe4brlA6OKeGH4uS2dXjg==", "568dfe7f-9e98-41e7-b188-f9a54f5cee08", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1951852-04a8-4eef-9538-13b21627a185",
                column: "ConcurrencyStamp",
                value: "9ddb444e-3284-4f83-98dd-ce8721a77182");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1951852-04c8-2eef-9238-13b31627b185",
                column: "ConcurrencyStamp",
                value: "3ccc932d-6c63-4472-955f-3209f22582fc");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119acbc4-bb39-426b-b645-160c3ef3c3a5",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "804bd6f9-560b-465f-be6b-f417d870607d", false, null, "AQAAAAEAACcQAAAAELE7NKmHN/fl4Httgw6Avyrz5dR4TakvtuXZdg6F1L7NuPxQ+SXxuS/WYaemUx7h8w==", "6b8bb100-b574-4030-b510-a1ebb64ef81c", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "119acbc4-bb39-436b-a66e-b60c6d634395",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "75bcf4a3-4fae-4694-a84f-1eae04723a5f", false, null, "AQAAAAEAACcQAAAAEEmDpMbgSooYOJYS8ZGJ5ZkcXS7dZ6wkR+hIjg44D38gOKc1fcNEAu/Hiyprjy8LDA==", "fc1d06b5-05b0-40fd-809e-b23dc269486c", null });
        }
    }
}
