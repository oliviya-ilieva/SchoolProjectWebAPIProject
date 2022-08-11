using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolProjectWebAPI.Migrations
{
    public partial class SeedDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Street", "StudentId", "TeacherId", "ZipCode" },
                values: new object[] { 2, null, "Slivnitsa", 3, null, 1000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
