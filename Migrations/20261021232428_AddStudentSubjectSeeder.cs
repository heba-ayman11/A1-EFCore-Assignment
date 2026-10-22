using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace A1.Migrations
{
    /// <inheritdoc />
    public partial class AddStudentSubjectSeeder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StudentSubject",
                columns: new[] { "StudentsId", "SubjectsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentSubject",
                keyColumns: new[] { "StudentsId", "SubjectsId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "StudentSubject",
                keyColumns: new[] { "StudentsId", "SubjectsId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "StudentSubject",
                keyColumns: new[] { "StudentsId", "SubjectsId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "StudentSubject",
                keyColumns: new[] { "StudentsId", "SubjectsId" },
                keyValues: new object[] { 3, 3 });
        }
    }
}
