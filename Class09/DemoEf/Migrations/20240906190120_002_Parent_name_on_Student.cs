using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoEf.Migrations
{
    public partial class _002_Parent_name_on_Student : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ParentName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ParentName",
                table: "Students");
        }
    }
}
