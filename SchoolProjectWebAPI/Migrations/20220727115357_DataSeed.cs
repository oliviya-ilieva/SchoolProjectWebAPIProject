using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolProjectWebAPI.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassLetter", "FirstName", "Grade", "LastName", "SSN", "Sex" },
                values: new object[] { 1, 2, "Peter", 1, "Stotanov", "9806543", 0 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassLetter", "FirstName", "Grade", "LastName", "SSN", "Sex" },
                values: new object[] { 2, 2, "Eleonora", 1, "Dimitrova", "98765798", 0 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ClassLetter", "FirstName", "Grade", "LastName", "SSN", "Sex" },
                values: new object[] { 3, 3, "Dimitar", 2, "Ivanov", "9876609", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
