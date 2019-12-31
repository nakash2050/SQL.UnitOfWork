using Microsoft.EntityFrameworkCore.Migrations;

namespace UOW.DAL.Migrations
{
    public partial class AddedRelationshipBetweenEmployeeAndEmployeeSkillsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "tblEmployeeSkills",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tblEmployeeSkills_EmployeeId",
                table: "tblEmployeeSkills",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblEmployeeSkills_tblEmployees_EmployeeId",
                table: "tblEmployeeSkills",
                column: "EmployeeId",
                principalTable: "tblEmployees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblEmployeeSkills_tblEmployees_EmployeeId",
                table: "tblEmployeeSkills");

            migrationBuilder.DropIndex(
                name: "IX_tblEmployeeSkills_EmployeeId",
                table: "tblEmployeeSkills");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "tblEmployeeSkills");
        }
    }
}
