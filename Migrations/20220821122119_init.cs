using Microsoft.EntityFrameworkCore.Migrations;

namespace MasterMind.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ColorSelections",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerColor1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerColor2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerColor3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerColor4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorrectColorCorrectPosition = table.Column<int>(type: "int", nullable: false),
                    CorrectColorWrongPosition = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorSelections", x => x.PlayerId);
                });

            migrationBuilder.CreateTable(
                name: "GameColors",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameColor1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameColor2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameColor3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameColor4 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameColors", x => x.GameId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColorSelections");

            migrationBuilder.DropTable(
                name: "GameColors");
        }
    }
}
