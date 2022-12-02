using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentWebApplication.Migrations
{
    public partial class IntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentNumber = table.Column<string>(type: "nvarchar(14)", nullable: false),
                    StudentName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    StudentEmail = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    StudentCode = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    StudentStudyTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
