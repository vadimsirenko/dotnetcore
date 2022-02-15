using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace my_books.Migrations
{
    public partial class AddLogTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LogEvent",
                table: "Logs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LogEvent",
                table: "Logs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
