using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneToOne1.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TestStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestStudents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentAdresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pin = table.Column<int>(type: "int", nullable: false),
                    TestStudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAdresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentAdresses_TestStudents_TestStudentId",
                        column: x => x.TestStudentId,
                        principalTable: "TestStudents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentAdresses_TestStudentId",
                table: "StudentAdresses",
                column: "TestStudentId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentAdresses");

            migrationBuilder.DropTable(
                name: "TestStudents");
        }
    }
}
