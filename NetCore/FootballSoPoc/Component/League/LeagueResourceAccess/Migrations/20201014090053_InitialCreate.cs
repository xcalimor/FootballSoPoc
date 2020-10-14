using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueResourceAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeagueTemplate",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    IsEliminiatingCup = table.Column<bool>(nullable: false),
                    PointsOnWin = table.Column<int>(nullable: false),
                    PointsOnDraw = table.Column<int>(nullable: false),
                    TimesPlayingEachOther = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeagueTemplate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    LeagueTemplateId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Leagues_LeagueTemplate_LeagueTemplateId",
                        column: x => x.LeagueTemplateId,
                        principalTable: "LeagueTemplate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameDays",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LeagueId = table.Column<Guid>(nullable: false),
                    SheduledAt = table.Column<DateTime>(nullable: false),
                    HomeLeagueTeamId = table.Column<Guid>(nullable: false),
                    AwayLeagueTeamId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameDays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameDays_Leagues_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "Leagues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeagueTeams",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LeagueId = table.Column<Guid>(nullable: false),
                    TeamId = table.Column<Guid>(nullable: false),
                    TeamName = table.Column<string>(nullable: true),
                    Rank = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeagueTeams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeagueTeams_Leagues_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "Leagues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Standings",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    LeagueId = table.Column<Guid>(nullable: false),
                    LeagueTeamId = table.Column<Guid>(nullable: false),
                    MemberId = table.Column<Guid>(nullable: false),
                    HomeGames = table.Column<int>(nullable: false),
                    AwayGames = table.Column<int>(nullable: false),
                    HomeWins = table.Column<int>(nullable: false),
                    AwayWins = table.Column<int>(nullable: false),
                    Draw = table.Column<int>(nullable: false),
                    GoalsAgainst = table.Column<int>(nullable: false),
                    GoalsMade = table.Column<int>(nullable: false),
                    Points = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Standings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Standings_Leagues_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "Leagues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Scorers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    GameDayId = table.Column<Guid>(nullable: false),
                    PlayerId = table.Column<Guid>(nullable: false),
                    ScoredInMinute = table.Column<int>(nullable: false),
                    AssistedByLeaguePlayerId = table.Column<Guid>(nullable: true),
                    ScorerId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scorers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Scorers_GameDays_GameDayId",
                        column: x => x.GameDayId,
                        principalTable: "GameDays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Scorers_GameDays_ScorerId",
                        column: x => x.ScorerId,
                        principalTable: "GameDays",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "LeagueTemplate",
                columns: new[] { "Id", "IsEliminiatingCup", "Name", "PointsOnDraw", "PointsOnWin", "TimesPlayingEachOther" },
                values: new object[] { new Guid("d9ef7eb8-b626-44fe-8326-ce84c7dcd34d"), true, "Cup template", 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "LeagueTemplate",
                columns: new[] { "Id", "IsEliminiatingCup", "Name", "PointsOnDraw", "PointsOnWin", "TimesPlayingEachOther" },
                values: new object[] { new Guid("3e40dce2-5e92-400f-b375-5361300f9971"), false, "Series template", 1, 3, 2 });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "LeagueTemplateId", "Name" },
                values: new object[] { new Guid("72a33c26-8971-44fc-b8ad-4630c68450be"), new Guid("d9ef7eb8-b626-44fe-8326-ce84c7dcd34d"), "FA Cup" });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "LeagueTemplateId", "Name" },
                values: new object[] { new Guid("0614a1e6-6ecd-42b7-b5c9-0ac09debcd18"), new Guid("3e40dce2-5e92-400f-b375-5361300f9971"), "Premieer League" });

            migrationBuilder.InsertData(
                table: "LeagueTeams",
                columns: new[] { "Id", "LeagueId", "Rank", "TeamId", "TeamName" },
                values: new object[,]
                {
                    { new Guid("f099df15-ff4e-4ce8-8ceb-190a90ede6e7"), new Guid("72a33c26-8971-44fc-b8ad-4630c68450be"), 1, new Guid("bc01ef2b-3a08-40a8-b9d5-88d6a6d912ca"), null },
                    { new Guid("c1247494-da7e-4048-b57d-69b999262a7d"), new Guid("0614a1e6-6ecd-42b7-b5c9-0ac09debcd18"), 11, new Guid("7719eb1f-028a-42ef-80e8-815f2b228ac4"), null },
                    { new Guid("a6266148-34cf-495a-8a51-5c8b06e891b4"), new Guid("0614a1e6-6ecd-42b7-b5c9-0ac09debcd18"), 10, new Guid("f6082b09-709a-4555-ad1e-150bc8c52b87"), null },
                    { new Guid("71ee929f-090d-4502-ac68-207fd93b919c"), new Guid("0614a1e6-6ecd-42b7-b5c9-0ac09debcd18"), 9, new Guid("64423823-57b4-4599-8ad3-c7f8db3954a3"), null },
                    { new Guid("c8b96505-c40d-46b6-8848-3de7b21f7370"), new Guid("0614a1e6-6ecd-42b7-b5c9-0ac09debcd18"), 8, new Guid("63d13457-c1a2-4724-8cce-da80c2abb707"), null },
                    { new Guid("2e02733f-1c59-479e-9c23-89a5ddb546d6"), new Guid("0614a1e6-6ecd-42b7-b5c9-0ac09debcd18"), 7, new Guid("3ce501b8-595c-44a9-b21e-5bb9cea9d1e0"), null },
                    { new Guid("506b3383-74ea-4638-802e-50e6954dbeea"), new Guid("0614a1e6-6ecd-42b7-b5c9-0ac09debcd18"), 6, new Guid("9e52c0c7-6dda-492e-9de6-54e1a89f3e73"), null },
                    { new Guid("89e4e0c2-899f-4373-b49f-0e52d8404dd6"), new Guid("0614a1e6-6ecd-42b7-b5c9-0ac09debcd18"), 5, new Guid("b3228a56-6321-4aa3-9db0-8d0c76a61b5c"), null },
                    { new Guid("716994b1-0b6f-4d24-98b2-2be692ce0eb9"), new Guid("0614a1e6-6ecd-42b7-b5c9-0ac09debcd18"), 4, new Guid("d6710993-c447-4732-8f8a-d1b708da4612"), null },
                    { new Guid("aa6dc508-4408-4432-b23a-4aab184fa3ae"), new Guid("0614a1e6-6ecd-42b7-b5c9-0ac09debcd18"), 3, new Guid("85e6f2d2-4eb0-4da6-95be-7a4a19621ba0"), null },
                    { new Guid("1e6c23fe-bf21-4971-a7fd-2e071e3b8f98"), new Guid("0614a1e6-6ecd-42b7-b5c9-0ac09debcd18"), 12, new Guid("77b36b59-f481-4e46-9765-a577617c287b"), null },
                    { new Guid("5f11f18d-12ac-46a1-9ff8-042ff9e01882"), new Guid("0614a1e6-6ecd-42b7-b5c9-0ac09debcd18"), 2, new Guid("44fd01e1-e710-4ad2-8cd2-a0ea823e9182"), null },
                    { new Guid("825b4833-2a3b-4159-ab52-975e579e025b"), new Guid("72a33c26-8971-44fc-b8ad-4630c68450be"), 10, new Guid("3bde4063-3317-4163-b9ce-21a36f548ea3"), null },
                    { new Guid("cdd5a09e-467d-4619-bcb6-e9affcbf79c7"), new Guid("72a33c26-8971-44fc-b8ad-4630c68450be"), 9, new Guid("01705f56-9630-4cb0-96d1-3c47e5d82e68"), null },
                    { new Guid("dd27e728-6708-4490-b47d-dab9fc0a20fc"), new Guid("72a33c26-8971-44fc-b8ad-4630c68450be"), 8, new Guid("4fe12e9b-8f15-451a-a791-1d1ff7e83284"), null },
                    { new Guid("f1daadac-3b1e-428a-8839-b591713b3012"), new Guid("72a33c26-8971-44fc-b8ad-4630c68450be"), 7, new Guid("49616e17-beaa-40ae-899f-8216a7aec410"), null },
                    { new Guid("d9508012-e7db-4b20-978a-369a1657e52b"), new Guid("72a33c26-8971-44fc-b8ad-4630c68450be"), 6, new Guid("72d3b148-bd7c-47bc-ad81-ee955f1f9b9c"), null },
                    { new Guid("30eb407c-630b-46e0-98cd-6ac5769c6108"), new Guid("72a33c26-8971-44fc-b8ad-4630c68450be"), 5, new Guid("c685b729-8d38-4bc2-bc81-82e7553c80f7"), null },
                    { new Guid("dba48d58-8d0b-4bc3-ab8c-b57c0460fcc5"), new Guid("72a33c26-8971-44fc-b8ad-4630c68450be"), 4, new Guid("5a39f299-fab8-49dc-993e-11783c8f6fd1"), null },
                    { new Guid("e3771587-afc5-47a6-a221-601921c46508"), new Guid("72a33c26-8971-44fc-b8ad-4630c68450be"), 3, new Guid("8cd59e7d-56f1-45ed-aad6-89e890a1e96b"), null },
                    { new Guid("f82a92aa-6e4e-4dea-ae7e-7f8f66b62b57"), new Guid("72a33c26-8971-44fc-b8ad-4630c68450be"), 2, new Guid("fa24121f-ef5a-41d8-b773-4a018be9ec3c"), null },
                    { new Guid("762a2484-1555-48f0-989b-8221e5e6c02a"), new Guid("0614a1e6-6ecd-42b7-b5c9-0ac09debcd18"), 1, new Guid("b3eb0f55-a4ff-48ab-8dee-4e30b14a343b"), null },
                    { new Guid("9b81fa58-e7a8-4db7-baa1-0bb8b21ce809"), new Guid("0614a1e6-6ecd-42b7-b5c9-0ac09debcd18"), 13, new Guid("55d9d4b5-5bb7-4c94-8cba-d92e3ed5f770"), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameDays_LeagueId",
                table: "GameDays",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_Leagues_LeagueTemplateId",
                table: "Leagues",
                column: "LeagueTemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_LeagueTeams_LeagueId",
                table: "LeagueTeams",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_Scorers_GameDayId",
                table: "Scorers",
                column: "GameDayId");

            migrationBuilder.CreateIndex(
                name: "IX_Scorers_ScorerId",
                table: "Scorers",
                column: "ScorerId");

            migrationBuilder.CreateIndex(
                name: "IX_Standings_LeagueId",
                table: "Standings",
                column: "LeagueId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeagueTeams");

            migrationBuilder.DropTable(
                name: "Scorers");

            migrationBuilder.DropTable(
                name: "Standings");

            migrationBuilder.DropTable(
                name: "GameDays");

            migrationBuilder.DropTable(
                name: "Leagues");

            migrationBuilder.DropTable(
                name: "LeagueTemplate");
        }
    }
}
