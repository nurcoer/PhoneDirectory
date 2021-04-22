using Microsoft.EntityFrameworkCore.Migrations;

namespace PhoneDirectory.DataAccess.Migrations
{
    public partial class initializeMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Directories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    PhoneDirectoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Personels_Directories_PhoneDirectoryId",
                        column: x => x.PhoneDirectoryId,
                        principalTable: "Directories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Directories",
                columns: new[] { "Id", "Title" },
                values: new object[] { 1, "iş Partfolyösü" });

            migrationBuilder.InsertData(
                table: "Personels",
                columns: new[] { "Id", "Description", "FirstName", "LastName", "PhoneDirectoryId", "PhoneNumber" },
                values: new object[] { 1, "ilk Kişi", "Nur", "Cöer", 1, "0502 216 24 45" });

            migrationBuilder.CreateIndex(
                name: "IX_Personels_PhoneDirectoryId",
                table: "Personels",
                column: "PhoneDirectoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personels");

            migrationBuilder.DropTable(
                name: "Directories");
        }
    }
}
