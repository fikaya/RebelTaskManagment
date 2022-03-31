using Microsoft.EntityFrameworkCore.Migrations;

namespace RebelsTasks.DataAccess.Migrations
{
    public partial class DepartmentMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "varchar(100)", nullable: false),
                    DepartmentDescription = table.Column<string>(type: "varchar(4000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.DepartmentId);
                });

            migrationBuilder.InsertData(
                table: "Department",
                columns: new[] { "DepartmentId", "DepartmentDescription", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "Yazılım Ve Kod Geliştirme Depertmanı", "Yazılım" },
                    { 2, "Proje Analizi ,İş Analizi ve Genel Tasarım", "Proje Analiz" },
                    { 3, "Arayüz Ve Görsel Depertmanı", "Grafik Ve Arayüzü" },
                    { 4, "Yöneticiler Deperatmanı", "Yönetim" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Department");
        }
    }
}
