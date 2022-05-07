using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1951852-04a8-4eef-9538-13b21627a185",
                column: "ConcurrencyStamp",
                value: "5d10ae46-d83c-4d70-ab28-a099458c0dac");

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
    }
}
