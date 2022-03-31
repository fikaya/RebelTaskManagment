using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RebelsTasks.DataAccess.Migrations
{
    public partial class EmployeeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeFirstName = table.Column<string>(type: "varchar(100)", nullable: false),
                    EmployeeLastName = table.Column<string>(type: "varchar(100)", nullable: false),
                    Title = table.Column<string>(type: "varchar(100)", nullable: true),
                    HireDate = table.Column<DateTime>(type: "date", nullable: true),
                    LeaveDate = table.Column<DateTime>(type: "date", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employee_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "EmployeeId", "DepartmentId", "EmployeeFirstName", "EmployeeLastName", "HireDate", "LeaveDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Tsubsa", "Ozora", new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Yazılım Geliştiricisi" },
                    { 2, 1, "Misaki", "Taro", new DateTime(2015, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Yazılım Geliştiricisi" },
                    { 3, 1, "Kojiro", "Huga", new DateTime(2014, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yazılım Geliştiricisi" },
                    { 4, 2, "Sanae", " Nakazawa", new DateTime(2014, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "İş Analisti" },
                    { 5, 2, "Yayoi", "Aoba", new DateTime(2014, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yazılım Geliştiricisi" },
                    { 6, 3, "Kumi", "Sugimota", new DateTime(2018, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Grafik Tasarımcısı" },
                    { 7, 4, "Roberto", "Hongo", new DateTime(2010, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Proje Yöneticisi" },
                    { 8, 4, "Munemasa", "Mu", new DateTime(2011, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ar-Ge Yöneticisi" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_DepartmentId",
                table: "Employee",
                column: "DepartmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
