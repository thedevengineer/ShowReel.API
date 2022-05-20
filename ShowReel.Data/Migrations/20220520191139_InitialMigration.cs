using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowReel.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    VideoStandard = table.Column<string>(type: "TEXT", nullable: false),
                    VideoDefinition = table.Column<string>(type: "TEXT", nullable: false),
                    Duration = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SessionId = table.Column<string>(type: "TEXT", nullable: false),
                    TimeStamp = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReelSession",
                columns: table => new
                {
                    ReelCollectionId = table.Column<int>(type: "INTEGER", nullable: false),
                    SessionCollectionId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReelSession", x => new { x.ReelCollectionId, x.SessionCollectionId });
                    table.ForeignKey(
                        name: "FK_ReelSession_Reels_ReelCollectionId",
                        column: x => x.ReelCollectionId,
                        principalTable: "Reels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReelSession_Sessions_SessionCollectionId",
                        column: x => x.SessionCollectionId,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Reels",
                columns: new[] { "Id", "Description", "Duration", "Name", "VideoDefinition", "VideoStandard" },
                values: new object[] { 1, "A factory is working on the new Bud Light Platinum.", "00:00:30:12", "Bud Light", "SD", "PAL" });

            migrationBuilder.InsertData(
                table: "Reels",
                columns: new[] { "Id", "Description", "Duration", "Name", "VideoDefinition", "VideoStandard" },
                values: new object[] { 2, "At a party, a brown shelled M&M is mistaken for being naked. As a result, the red M&M tears off its skin and dances to \"Sexy and I Know It\" by LMFAO.", "00:00:15:27", "M&M's", "SD", "NTSC" });

            migrationBuilder.InsertData(
                table: "Reels",
                columns: new[] { "Id", "Description", "Duration", "Name", "VideoDefinition", "VideoStandard" },
                values: new object[] { 3, "A group of vampires are having a party in the woods. The vampire in charge of drinks (blood types) arrives in his Audi. The bright lights of the car kills all of the vampires, with him wondering where everyone went afterwards.", "00:01:30:00", "Audi", "SD", "PAL" });

            migrationBuilder.InsertData(
                table: "Reels",
                columns: new[] { "Id", "Description", "Duration", "Name", "VideoDefinition", "VideoStandard" },
                values: new object[] { 4, "Clint Eastwood recounts how the automotive industry survived the Great Recession.", "00:00:10:14", "Chrysler", "SD", "PAL" });

            migrationBuilder.InsertData(
                table: "Reels",
                columns: new[] { "Id", "Description", "Duration", "Name", "VideoDefinition", "VideoStandard" },
                values: new object[] { 5, "A man walks through a street to discover a beautiful woman (Catrinel Menghia) standing on a parking space, who proceeds to approach and seduce him, when successfully doing so he then discovers he was about to kiss a Fiat 500 Abarth.", "00:00:18:11", "Fiat", "SD", "NTSC" });

            migrationBuilder.InsertData(
                table: "Reels",
                columns: new[] { "Id", "Description", "Duration", "Name", "VideoDefinition", "VideoStandard" },
                values: new object[] { 6, "People in the Middles Ages try to entertain their king (Elton John) for a Pepsi. While the first person fails, a mysterious person (Season 1 X Factor winner Melanie Amaro) wins the Pepsi by singing Aretha Franklin's \"Respect\".\" After she wins, she overthrows the king and gives Pepsi to all the town.", "00:00:20:00", "Pepsi", "SD", "NTSC" });

            migrationBuilder.InsertData(
                table: "Reels",
                columns: new[] { "Id", "Description", "Duration", "Name", "VideoDefinition", "VideoStandard" },
                values: new object[] { 7, "An ad featuring the creators of the camera phone, Siri, and the first text message. The creators of Words with Friends also appear parodying the incident involving Alec Baldwin playing the game on an airplane.", "00:00:10:05", "Best Buy", "HD", "PAL" });

            migrationBuilder.InsertData(
                table: "Reels",
                columns: new[] { "Id", "Description", "Duration", "Name", "VideoDefinition", "VideoStandard" },
                values: new object[] { 8, "Video Promo", "00:00:20:10", "Captain America The First Avenger", "HD", "PAL" });

            migrationBuilder.InsertData(
                table: "Reels",
                columns: new[] { "Id", "Description", "Duration", "Name", "VideoDefinition", "VideoStandard" },
                values: new object[] { 9, "A computer generated black beetle runs fast, as it is referencing the new,Volkswagen model", "00:00:30:00", "Volkswagen \"Black Beetle\"", "HD", "NTSC" });

            migrationBuilder.CreateIndex(
                name: "IX_ReelSession_SessionCollectionId",
                table: "ReelSession",
                column: "SessionCollectionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReelSession");

            migrationBuilder.DropTable(
                name: "Reels");

            migrationBuilder.DropTable(
                name: "Sessions");
        }
    }
}
