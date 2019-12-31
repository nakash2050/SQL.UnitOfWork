using Microsoft.EntityFrameworkCore.Migrations;

namespace UOW.DAL.Migrations
{
    public partial class ChangedColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Department",
                table: "tblEmployees");

            migrationBuilder.AddColumn<string>(
                name: "Designation",
                table: "tblEmployees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Designation",
                table: "tblEmployees");

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "tblEmployees",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
