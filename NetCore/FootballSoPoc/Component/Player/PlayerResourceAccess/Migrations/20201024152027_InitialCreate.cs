using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlayerResourceAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Firstname = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    TeamId = table.Column<Guid>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Height = table.Column<int>(nullable: false),
                    Weight = table.Column<int>(nullable: false),
                    Stamina = table.Column<int>(nullable: false),
                    Reaction = table.Column<int>(nullable: false),
                    GameIQ = table.Column<int>(nullable: false),
                    Offensive = table.Column<int>(nullable: false),
                    Deffensive = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoalStatsDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    GoalMadeNotSaved = table.Column<bool>(nullable: false),
                    At = table.Column<DateTime>(nullable: false),
                    GameTime = table.Column<int>(nullable: false),
                    InLeagueId = table.Column<Guid>(nullable: false),
                    ForTeamId = table.Column<Guid>(nullable: false),
                    PlayerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoalStatsDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GoalStatsDetails_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayerAggregatedStats",
                columns: table => new
                {
                    PlayerId = table.Column<Guid>(nullable: false),
                    PlayertId = table.Column<Guid>(nullable: true),
                    GamesPlayed = table.Column<int>(nullable: false),
                    GoalsMade = table.Column<int>(nullable: false),
                    Assists = table.Column<int>(nullable: false),
                    GoalsSaved = table.Column<int>(nullable: false),
                    MinutesPlayed = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerAggregatedStats", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_PlayerAggregatedStats_Players_PlayertId",
                        column: x => x.PlayertId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GoalStatsDetails_PlayerId",
                table: "GoalStatsDetails",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerAggregatedStats_PlayertId",
                table: "PlayerAggregatedStats",
                column: "PlayertId",
                unique: true,
                filter: "[PlayertId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoalStatsDetails");

            migrationBuilder.DropTable(
                name: "PlayerAggregatedStats");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}
