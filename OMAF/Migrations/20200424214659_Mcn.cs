using Microsoft.EntityFrameworkCore.Migrations;

namespace OMAF.Migrations
{
    public partial class Mcn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MCN",
                table: "Aircraft",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MCN",
                table: "Aircraft");
        }
    }
}
