using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RebelsTasks.DataAccess.Migrations
{
    public partial class SubTaskUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CompletedOn",
                table: "SubTask",
                type: "datetime2(2)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "StartedOn",
                table: "SubTask",
                type: "datetime2(2)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletedOn",
                table: "SubTask");

            migrationBuilder.DropColumn(
                name: "StartedOn",
                table: "SubTask");
        }
    }
}
