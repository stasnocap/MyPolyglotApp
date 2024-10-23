using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "identity",
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { new Guid("978a8de7-9ab5-4d52-84f8-59e7ebb48ae7"), "d7e5d09c-a389-4773-82f7-043d780069aa", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("978a8de7-9ab5-4d52-84f8-59e7ebb48ae7"), new Guid("af800c3d-717a-48b3-8181-3b432a450f5e") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "identity",
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("978a8de7-9ab5-4d52-84f8-59e7ebb48ae7"), new Guid("af800c3d-717a-48b3-8181-3b432a450f5e") });

            migrationBuilder.DeleteData(
                schema: "identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("978a8de7-9ab5-4d52-84f8-59e7ebb48ae7"));
        }
    }
}
