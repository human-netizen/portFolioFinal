using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortFolioFInal.Migrations
{
    /// <inheritdoc />
    public partial class seedTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "skillDescription",
                table: "Skills");

            migrationBuilder.RenameColumn(
                name: "username",
                table: "Logins",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "password",
                table: "Logins",
                newName: "details");

            migrationBuilder.AddColumn<int>(
                name: "level",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Logins",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "id", "Email", "details", "title" },
                values: new object[] { 1, "", "This is my details1", "Title1" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "id", "projectDescription", "projectLink", "projectName" },
                values: new object[,]
                {
                    { 1, "This is my project1", "https://github.com/abc", "Project1" },
                    { 2, "This is Project2", "https://github.com/abcd", "Project2" },
                    { 3, "This is my Project3", "https://github.com/abcde", "Project3" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "id", "level", "skillName" },
                values: new object[,]
                {
                    { 1, 5, "C#" },
                    { 2, 4, "Python" },
                    { 3, 3, "Java" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Skills",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "level",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Logins");

            migrationBuilder.RenameColumn(
                name: "title",
                table: "Logins",
                newName: "username");

            migrationBuilder.RenameColumn(
                name: "details",
                table: "Logins",
                newName: "password");

            migrationBuilder.AddColumn<string>(
                name: "skillDescription",
                table: "Skills",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
