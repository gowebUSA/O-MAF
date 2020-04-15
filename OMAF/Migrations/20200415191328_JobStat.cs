using Microsoft.EntityFrameworkCore.Migrations;

namespace OMAF.Migrations
{
    public partial class JobStat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JobStat",
                table: "Aircraft",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobStat",
                table: "Aircraft");
        }
    }
}
