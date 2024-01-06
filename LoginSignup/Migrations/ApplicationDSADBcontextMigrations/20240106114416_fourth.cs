using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginSignup.Migrations.ApplicationDSADBcontextMigrations
{
    /// <inheritdoc />
    public partial class fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dsadetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dsadetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DSATables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<int>(type: "int", nullable: false),
                    DSAName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DSAQuestion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DSAAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DSAFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DSALevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DSAIntuition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DSALanguage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DSATables", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dsadetails");

            migrationBuilder.DropTable(
                name: "DSATables");
        }
    }
}
