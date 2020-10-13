using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LeagueResourceAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaguePlayers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    PlayerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaguePlayers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Leagues",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leagues", x => x.Id);
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
                    LeaguePlayerId = table.Column<Guid>(nullable: false),
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
                table: "LeaguePlayers",
                columns: new[] { "Id", "PlayerId" },
                values: new object[,]
                {
                    { new Guid("322ca22b-90bb-47d6-b927-4f7d8568d43e"), new Guid("9522df07-4640-40a9-ab21-d17752dd44a1") },
                    { new Guid("4797de9c-8e03-44f8-acc5-caedade68465"), new Guid("a63aba53-cfa0-4498-94c7-9389c1576053") },
                    { new Guid("d943b4fe-5a44-4819-8c4e-9f4fbb511ce7"), new Guid("57edaccd-88e7-4da8-bcd5-b06caabd959e") },
                    { new Guid("40120376-967e-4521-bc09-b3ea9b9bc676"), new Guid("d83d2a7f-6061-4380-8325-ec03b19b5171") }
                });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("2198ad60-163c-4fa8-9857-71964073bb29"), "Premieer League" });

            migrationBuilder.InsertData(
                table: "GameDays",
                columns: new[] { "Id", "AwayLeagueTeamId", "HomeLeagueTeamId", "LeagueId", "SheduledAt" },
                values: new object[,]
                {
                    { new Guid("8ebdcc5f-5e09-4b06-85c0-f778c68047c9"), new Guid("03c71860-c086-4eb4-93bc-6f8ac445c703"), new Guid("6cdd9d2b-bd5d-4f2f-82ba-d31cef1a2870"), new Guid("2198ad60-163c-4fa8-9857-71964073bb29"), new DateTime(2020, 10, 13, 11, 45, 1, 299, DateTimeKind.Local).AddTicks(2154) },
                    { new Guid("2d449e0c-8b0f-4b1e-8581-bc362db0aa31"), new Guid("fa3a6d42-9b9d-45d5-a860-63069e64c6e2"), new Guid("bc18a38c-9fec-4bcc-b0ee-1f42b968ac3d"), new Guid("2198ad60-163c-4fa8-9857-71964073bb29"), new DateTime(2020, 10, 13, 11, 45, 1, 302, DateTimeKind.Local).AddTicks(5734) },
                    { new Guid("b868f1e4-af7b-4c36-ad23-b511d30955d4"), new Guid("bc18a38c-9fec-4bcc-b0ee-1f42b968ac3d"), new Guid("03c71860-c086-4eb4-93bc-6f8ac445c703"), new Guid("2198ad60-163c-4fa8-9857-71964073bb29"), new DateTime(2020, 10, 13, 11, 50, 1, 302, DateTimeKind.Local).AddTicks(5815) },
                    { new Guid("e8e81a43-f00a-4eec-8250-f8e5668bab51"), new Guid("6cdd9d2b-bd5d-4f2f-82ba-d31cef1a2870"), new Guid("fa3a6d42-9b9d-45d5-a860-63069e64c6e2"), new Guid("2198ad60-163c-4fa8-9857-71964073bb29"), new DateTime(2020, 10, 13, 11, 50, 1, 302, DateTimeKind.Local).AddTicks(5824) },
                    { new Guid("10c4bb54-f2d7-4d61-aa99-2355923fddb3"), new Guid("6cdd9d2b-bd5d-4f2f-82ba-d31cef1a2870"), new Guid("bc18a38c-9fec-4bcc-b0ee-1f42b968ac3d"), new Guid("2198ad60-163c-4fa8-9857-71964073bb29"), new DateTime(2020, 10, 13, 11, 55, 1, 302, DateTimeKind.Local).AddTicks(5829) },
                    { new Guid("92b42204-ed04-4072-b46a-7ddfbd43e028"), new Guid("fa3a6d42-9b9d-45d5-a860-63069e64c6e2"), new Guid("03c71860-c086-4eb4-93bc-6f8ac445c703"), new Guid("2198ad60-163c-4fa8-9857-71964073bb29"), new DateTime(2020, 10, 13, 11, 55, 1, 302, DateTimeKind.Local).AddTicks(5834) }
                });

            migrationBuilder.InsertData(
                table: "LeagueTeams",
                columns: new[] { "Id", "LeagueId", "Rank", "TeamId" },
                values: new object[,]
                {
                    { new Guid("6cdd9d2b-bd5d-4f2f-82ba-d31cef1a2870"), new Guid("2198ad60-163c-4fa8-9857-71964073bb29"), 1, new Guid("6e9e7d29-a594-4e81-9334-0725e0fc7520") },
                    { new Guid("03c71860-c086-4eb4-93bc-6f8ac445c703"), new Guid("2198ad60-163c-4fa8-9857-71964073bb29"), 2, new Guid("661a7b09-3f20-48be-8af2-c6bbb6bcaf4e") },
                    { new Guid("bc18a38c-9fec-4bcc-b0ee-1f42b968ac3d"), new Guid("2198ad60-163c-4fa8-9857-71964073bb29"), 3, new Guid("b936f38f-bafe-4a56-8756-ed1b9da3e864") },
                    { new Guid("fa3a6d42-9b9d-45d5-a860-63069e64c6e2"), new Guid("2198ad60-163c-4fa8-9857-71964073bb29"), 4, new Guid("551b3e88-46ce-4bf1-bf85-14660168d907") }
                });

            migrationBuilder.InsertData(
                table: "Standings",
                columns: new[] { "Id", "AwayGames", "AwayWins", "Draw", "GoalsAgainst", "GoalsMade", "HomeGames", "HomeWins", "LeagueId", "LeagueTeamId", "MemberId", "Points" },
                values: new object[,]
                {
                    { new Guid("9c30baf9-a28a-485e-bccd-9d43294ffb31"), 0, 0, 0, 3, 1, 1, 0, new Guid("2198ad60-163c-4fa8-9857-71964073bb29"), new Guid("6cdd9d2b-bd5d-4f2f-82ba-d31cef1a2870"), new Guid("00000000-0000-0000-0000-000000000000"), 0 },
                    { new Guid("50a09551-0f72-4071-8b49-adcefc488070"), 1, 0, 0, 1, 3, 0, 0, new Guid("2198ad60-163c-4fa8-9857-71964073bb29"), new Guid("03c71860-c086-4eb4-93bc-6f8ac445c703"), new Guid("00000000-0000-0000-0000-000000000000"), 3 },
                    { new Guid("4a295316-e39c-42e5-a1ae-3e240d5a667f"), 0, 0, 1, 0, 0, 1, 0, new Guid("2198ad60-163c-4fa8-9857-71964073bb29"), new Guid("bc18a38c-9fec-4bcc-b0ee-1f42b968ac3d"), new Guid("00000000-0000-0000-0000-000000000000"), 1 },
                    { new Guid("8b4114ac-1091-40c2-a005-952ffe11793f"), 0, 0, 1, 0, 0, 1, 0, new Guid("2198ad60-163c-4fa8-9857-71964073bb29"), new Guid("fa3a6d42-9b9d-45d5-a860-63069e64c6e2"), new Guid("00000000-0000-0000-0000-000000000000"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Scorers",
                columns: new[] { "Id", "AssistedByLeaguePlayerId", "GameDayId", "LeaguePlayerId", "ScoredInMinute", "ScorerId" },
                values: new object[,]
                {
                    { new Guid("ea19cc6b-a63c-4eb0-adad-d00d07652b99"), new Guid("40120376-967e-4521-bc09-b3ea9b9bc676"), new Guid("8ebdcc5f-5e09-4b06-85c0-f778c68047c9"), new Guid("d943b4fe-5a44-4819-8c4e-9f4fbb511ce7"), 22, null },
                    { new Guid("eedb16b4-e575-439f-b1f7-e05f2f2b1376"), new Guid("40120376-967e-4521-bc09-b3ea9b9bc676"), new Guid("8ebdcc5f-5e09-4b06-85c0-f778c68047c9"), new Guid("d943b4fe-5a44-4819-8c4e-9f4fbb511ce7"), 47, null },
                    { new Guid("cf5b0da5-9c4c-446a-8b70-a5690e14ccad"), new Guid("40120376-967e-4521-bc09-b3ea9b9bc676"), new Guid("8ebdcc5f-5e09-4b06-85c0-f778c68047c9"), new Guid("d943b4fe-5a44-4819-8c4e-9f4fbb511ce7"), 78, null },
                    { new Guid("f9f70cf6-ea78-4332-a7e7-472432d043f6"), new Guid("4797de9c-8e03-44f8-acc5-caedade68465"), new Guid("8ebdcc5f-5e09-4b06-85c0-f778c68047c9"), new Guid("322ca22b-90bb-47d6-b927-4f7d8568d43e"), 37, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameDays_LeagueId",
                table: "GameDays",
                column: "LeagueId");

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
                name: "LeaguePlayers");

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
        }
    }
}
