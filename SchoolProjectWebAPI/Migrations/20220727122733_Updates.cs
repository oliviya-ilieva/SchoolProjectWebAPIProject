using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolProjectWebAPI.Migrations
{
    public partial class Updates : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClassLetter", "Grade" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClassLetter", "Grade" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClassLetter", "Grade" },
                values: new object[] { 4, 3 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassLetter", "FirstName", "Grade", "LastName", "SSN", "Sex" },
                values: new object[] { 4, 6, "Stoyan", 4, "Todorov", "98766876", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClassLetter", "Grade" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClassLetter", "Grade" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClassLetter", "Grade" },
                values: new object[] { 3, 2 });
        }
    }
}
