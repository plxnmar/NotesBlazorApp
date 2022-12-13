using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotesBlazorApp.Server.Data.Migrations
{
    public partial class DescriptionToColorAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ColorCards",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "ColorCards");
        }
    }
}
