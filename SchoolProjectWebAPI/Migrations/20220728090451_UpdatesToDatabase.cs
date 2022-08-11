using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolProjectWebAPI.Migrations
{
    public partial class UpdatesToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "Street", "StudentId", "TeacherId", "ZipCode" },
                values: new object[] { 1, "Burgas", "Slivnitsa", null, null, 8000 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassLetter", "FirstName", "Grade", "LastName", "SSN", "Sex" },
                values: new object[] { 6, 6, "Stoyan", 11, "Todorov", "9876689", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
