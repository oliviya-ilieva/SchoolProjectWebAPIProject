using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolProjectWebAPI.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Street", "StudentId", "TeacherId", "ZipCode" },
                values: new object[] { 1, "Burgas", "Slivnitsa", 0, null, 8000 });
        }
    }
}
