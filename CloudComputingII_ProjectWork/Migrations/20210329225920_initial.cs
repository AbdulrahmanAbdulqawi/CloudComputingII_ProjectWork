using Microsoft.EntityFrameworkCore.Migrations;

namespace CloudComputingII_ProjectWork.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nvarchar250 = table.Column<string>(name: "nvarchar(250)", type: "nvarchar(max)", nullable: false),
                    nvarchar10 = table.Column<string>(name: "nvarchar(10)", type: "nvarchar(max)", nullable: true),
                    nvarchar1000 = table.Column<string>(name: "nvarchar(1000)", type: "nvarchar(max)", nullable: true),
                    nvarchar100 = table.Column<string>(name: "nvarchar(100)", type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
