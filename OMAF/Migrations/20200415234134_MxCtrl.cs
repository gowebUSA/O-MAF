using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OMAF.Migrations
{
    public partial class MxCtrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReleaseDate",
                table: "Aircraft");

            migrationBuilder.AddColumn<DateTime>(
                name: "ComplDate",
                table: "Aircraft",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CorrAction",
                table: "Aircraft",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discrepancy",
                table: "Aircraft",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "InitiateDate",
                table: "Aircraft",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Initiator",
                table: "Aircraft",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Inspector",
                table: "Aircraft",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "IwDate",
                table: "Aircraft",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "MxCtrl",
                table: "Aircraft",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MxCtrlNotes",
                table: "Aircraft",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Worker",
                table: "Aircraft",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComplDate",
                table: "Aircraft");

            migrationBuilder.DropColumn(
                name: "CorrAction",
                table: "Aircraft");

            migrationBuilder.DropColumn(
                name: "Discrepancy",
                table: "Aircraft");

            migrationBuilder.DropColumn(
                name: "InitiateDate",
                table: "Aircraft");

            migrationBuilder.DropColumn(
                name: "Initiator",
                table: "Aircraft");

            migrationBuilder.DropColumn(
                name: "Inspector",
                table: "Aircraft");

            migrationBuilder.DropColumn(
                name: "IwDate",
                table: "Aircraft");

            migrationBuilder.DropColumn(
                name: "MxCtrl",
                table: "Aircraft");

            migrationBuilder.DropColumn(
                name: "MxCtrlNotes",
                table: "Aircraft");

            migrationBuilder.DropColumn(
                name: "Worker",
                table: "Aircraft");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReleaseDate",
                table: "Aircraft",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
