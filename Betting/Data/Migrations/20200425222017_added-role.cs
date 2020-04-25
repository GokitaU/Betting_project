using Microsoft.EntityFrameworkCore.Migrations;

namespace Betting.Data.Migrations
{
    public partial class addedrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e134e932-2d41-49d5-83f5-8c9f889b0976");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "02e9d37d-9620-4c45-ae6d-4808d61536f7", "5b4dc3f2-fd77-4734-ac8b-60cdec89e8f6", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "33db4551-842d-4d13-aa86-95138b5b3f22", "e0affcd7-57a5-4836-8d29-5260f55ed544", "Member", "MEMBER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02e9d37d-9620-4c45-ae6d-4808d61536f7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33db4551-842d-4d13-aa86-95138b5b3f22");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e134e932-2d41-49d5-83f5-8c9f889b0976", "3fd4fe32-e534-439f-ba34-7bf1b662b483", "Admin", "ADMIN" });
        }
    }
}
