using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumList.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Album",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album", x => x.AlbumId);
                });

            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "AlbumId", "Name", "Year" },
                values: new object[] { 1, "Example Album", 2020 });

            migrationBuilder.InsertData(
                table: "Album",
                columns: new[] { "AlbumId", "Name", "Year" },
                values: new object[] { 2, "Example Album 2", 2021 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Album");
        }
    }
}
