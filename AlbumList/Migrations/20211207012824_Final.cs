using Microsoft.EntityFrameworkCore.Migrations;

namespace AlbumList.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.InsertData(
                table: "Listens",
                columns: new[] { "ListensModelId", "Album", "Artist", "Rating", "Title" },
                values: new object[,]
                {
                    { 1, "Blonde", "Frank Ocean", 6.0, "Ivy" },
                    { 2, "Selected Ambient Works Volume II", "Aphex Twin", 3.0, "#3" },
                    { 3, "The Bends", "Radiohead", 9.0, "Fake Plastic Trees" },
                    { 4, "Kickback", "KanKan", 5.0, "Kickback" },
                    { 5, "After Me", "SoFaygo", 6.0, "Everyday" },
                    { 6, "Let's Skip to the Wedding", "Eyedress", 1.0, "Kiss Me Like It's the First Time" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Listens",
                keyColumn: "ListensModelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Listens",
                keyColumn: "ListensModelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Listens",
                keyColumn: "ListensModelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Listens",
                keyColumn: "ListensModelId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Listens",
                keyColumn: "ListensModelId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Listens",
                keyColumn: "ListensModelId",
                keyValue: 6);

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    AlbumId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.AlbumId);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "Name", "Year" },
                values: new object[] { 1, "Example Album", 2020 });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "AlbumId", "Name", "Year" },
                values: new object[] { 2, "Example Album 2", 2021 });
        }
    }
}
