using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotesBlazorApp.Server.Data.Migrations
{
    public partial class ColorsDataAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ColorCards",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "White", "FFFFFF" },
                    { 2, "Red", "FC6471" },
                    { 3, "Yellow", "FFD275" },
                    { 4, "Green Celadon", "A1E5AB" },
                    { 5, "Blue Purple", "B2ABF2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ColorCards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ColorCards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ColorCards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ColorCards",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ColorCards",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
