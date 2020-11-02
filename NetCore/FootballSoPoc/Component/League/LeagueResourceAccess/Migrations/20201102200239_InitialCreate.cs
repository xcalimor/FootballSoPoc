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
                values: new object[] { new Guid("2fa6c329-d683-471c-be8f-8aea59aaff13"), true, "Cup template", 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "LeagueTemplate",
                columns: new[] { "Id", "IsEliminiatingCup", "Name", "PointsOnDraw", "PointsOnWin", "TimesPlayingEachOther" },
                values: new object[] { new Guid("92a5b129-e3c2-4fc1-a437-4b346d2d867d"), false, "Series template", 1, 3, 2 });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "LeagueTemplateId", "Name" },
                values: new object[] { new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), new Guid("2fa6c329-d683-471c-be8f-8aea59aaff13"), "FA Cup" });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "LeagueTemplateId", "Name" },
                values: new object[] { new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), new Guid("92a5b129-e3c2-4fc1-a437-4b346d2d867d"), "Premieer League" });

            migrationBuilder.InsertData(
                table: "Leagues",
                columns: new[] { "Id", "LeagueTemplateId", "Name" },
                values: new object[] { new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), new Guid("92a5b129-e3c2-4fc1-a437-4b346d2d867d"), "EFL Championship" });

            migrationBuilder.InsertData(
                table: "LeagueTeams",
                columns: new[] { "Id", "LeagueId", "Rank", "TeamId", "TeamName" },
                values: new object[,]
                {
                    { new Guid("82d8f0b3-7783-4616-9aae-63df5f2e0b1f"), new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), 1, new Guid("29090939-1d95-4ac2-ab29-de91a2db1368"), null },
                    { new Guid("26d08c04-4fa8-411c-a29d-fb66556f6727"), new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), 15, new Guid("793f4d54-481e-42ae-80aa-1e714fd72a45"), null },
                    { new Guid("5b957f9b-45fa-4550-8d13-c6a2c254c8f1"), new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), 16, new Guid("e748c6a4-74a1-442a-8d04-3d5309f04129"), null },
                    { new Guid("83d238de-c811-4886-bcbc-9153ef84a7bb"), new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), 17, new Guid("159136ef-515e-472c-bbb7-ca74d5129ae7"), null },
                    { new Guid("33c639c1-aca7-4920-ae45-6bc809567d9c"), new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), 18, new Guid("a4772a68-55f2-4d03-bf18-1bfe313d2935"), null },
                    { new Guid("bc120ca5-53a2-4fed-80e9-99f4149afdee"), new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), 19, new Guid("04e9d666-dfcb-4692-8d87-f4840b8549d5"), null },
                    { new Guid("7a1ca0c6-5280-46d0-aad0-6bc9b85b4168"), new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), 20, new Guid("0d5e25bf-f764-4644-bbf3-cf7ab2cff0ad"), null },
                    { new Guid("3d00ba04-c982-49a3-b4db-9bfd0bc03e27"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 0, new Guid("a3f8eef4-8a92-407a-9402-d7dae78a7499"), null },
                    { new Guid("7807627f-e9b2-4051-b9a8-d8f195b342a6"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 1, new Guid("bf852fa5-60f6-4104-94dd-71746b309d1b"), null },
                    { new Guid("01f86531-b68e-4a09-9dbb-61dadffc5f9e"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 2, new Guid("d45e9dfb-7032-40e9-b871-18901f791536"), null },
                    { new Guid("031bd56c-6416-47d8-8f11-34a888a91c0d"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 3, new Guid("7fd4962c-a1e0-4c18-b7c5-1e2c9748debf"), null },
                    { new Guid("46499e77-3efe-47b9-ab3f-dd6274d12a52"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 4, new Guid("3fd0e4d7-5574-4de4-957f-41da87b26f5d"), null },
                    { new Guid("d708dff6-c783-4e50-a54e-b57c0f96276e"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 5, new Guid("ce43f7ea-f0d8-4354-b2ac-c411b216a87b"), null },
                    { new Guid("f0587179-c6fc-4365-a871-70780b6639a1"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 6, new Guid("7e560e4b-cdc0-4d3d-998b-df9053813467"), null },
                    { new Guid("0c3240d3-c03f-4562-8eef-1983614cc6a8"), new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), 14, new Guid("9de989da-e454-46af-9faa-2f281cafa48b"), null },
                    { new Guid("b4b0caa4-9781-47e1-a90a-3403b0389d71"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 7, new Guid("76ab740d-8bd5-428a-a2a5-3d63779805f2"), null },
                    { new Guid("e1e5bb20-c8d7-4f01-928d-8feb26054f1c"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 9, new Guid("ba6d5954-364c-45cf-a55d-8a207c369761"), null },
                    { new Guid("3ec2de15-cc38-4a6b-ae3a-325d55209ff5"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 10, new Guid("a596da7e-8406-42ab-ab87-9f103ee47272"), null },
                    { new Guid("34cac657-0252-4837-9b0a-83085155efa6"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 11, new Guid("3b52b592-a4bc-4b1c-8f7c-4fe467810dac"), null },
                    { new Guid("1083d6f1-feeb-4908-9f45-e63ea8a8fe23"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 12, new Guid("676aa12b-2d46-4e4d-8dc9-67fecccd2ba5"), null },
                    { new Guid("efce1dbe-dab7-4023-9c97-c6ed1e443bb3"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 13, new Guid("ae927c9d-fcd1-4bfc-8259-f8014e74b2e5"), null },
                    { new Guid("1fc16b77-9f0c-4665-b6e2-5986aed07e2a"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 14, new Guid("ef0e5227-f51f-4f7f-9d24-9a6a208c3a15"), null },
                    { new Guid("31354e46-8453-40c5-94aa-00594e18dd8f"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 15, new Guid("ed671605-1872-4089-8f2e-4cd9a9f68b72"), null },
                    { new Guid("41520332-1119-4d48-a135-574ca4a7f522"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 16, new Guid("78d33450-f3dc-4bfd-a01f-1a0e91b75f1a"), null },
                    { new Guid("a75b5bcd-3e45-4bc5-869f-2ef3230e4b0f"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 17, new Guid("38c2bce5-de53-42e4-b61f-b64113c9d463"), null },
                    { new Guid("218ea63c-a6cf-47e4-86b7-02febc750bfe"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 18, new Guid("446090dc-4edf-49ef-be12-0f337caa5c39"), null },
                    { new Guid("5eb417e3-0666-4e8f-b623-90418e70f362"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 19, new Guid("ccc7f427-9b43-4149-9d30-d381a86a146d"), null },
                    { new Guid("1854dabf-9358-4caf-b4c9-16015fcdb236"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 20, new Guid("787aba1d-e768-4c7e-9128-e04fc7f25564"), null },
                    { new Guid("daebf396-c4ef-439e-96ff-1270de5c2f03"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 21, new Guid("3ba8507e-90de-4c09-97ad-eec460368c6c"), null },
                    { new Guid("a0a435f8-692a-4c6e-8093-2e4e5155a69e"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 8, new Guid("7be361b9-46bb-4797-98b5-12d985492302"), null },
                    { new Guid("bd2987ce-4dd9-4a5e-82d2-0bfdcd754949"), new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), 13, new Guid("72ad2911-1718-4196-8bbe-cc75c59318c0"), null },
                    { new Guid("67e50ed1-aab8-42b9-91dc-d443e1d7d14c"), new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), 12, new Guid("f5779213-14b6-45df-8033-d99355b8315c"), null },
                    { new Guid("dd7e029b-1b4a-43e7-bc7f-8760b82beb59"), new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), 11, new Guid("52bff2ff-b926-4f4a-8c0b-3ee37b245e2d"), null },
                    { new Guid("d80a0cae-fb4d-4568-b349-7908e7500458"), new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), 50, new Guid("a3f8eef4-8a92-407a-9402-d7dae78a7499"), null },
                    { new Guid("0f70d537-b59e-4831-928a-5bd4a5493418"), new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), 2, new Guid("091eab68-b90d-4e2c-ad39-87b06b9e46eb"), null },
                    { new Guid("31787bcc-414b-4b6f-b7ae-4f20ebeca3ba"), new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), 51, new Guid("bf852fa5-60f6-4104-94dd-71746b309d1b"), null },
                    { new Guid("1e8ff714-e050-47ad-bf37-8c71ad9cc2ee"), new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), 3, new Guid("d9b1b83d-4e3d-45a1-bc68-c7828b92aad4"), null },
                    { new Guid("92e0d393-fe1f-4c42-a9fa-3bf9f8f88a29"), new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), 52, new Guid("d45e9dfb-7032-40e9-b871-18901f791536"), null },
                    { new Guid("df9db17e-8fd7-4c85-a6ee-835f2837908e"), new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), 4, new Guid("8c7e4657-c9bc-4cab-b825-e749cd42c358"), null },
                    { new Guid("2271f4a5-4341-493d-abbb-22c4adb2c429"), new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), 53, new Guid("7fd4962c-a1e0-4c18-b7c5-1e2c9748debf"), null },
                    { new Guid("56c2faf0-6806-4114-be4a-c3ef181af824"), new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), 5, new Guid("6512a227-b8b0-4aab-95a4-62f44e264bc8"), null },
                    { new Guid("47b0e245-0634-4413-ad98-391673321c8b"), new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), 54, new Guid("3fd0e4d7-5574-4de4-957f-41da87b26f5d"), null },
                    { new Guid("58af8d91-ad16-4364-95f2-030e20ded96b"), new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), 6, new Guid("ef6ab149-ca29-4ec1-9f22-8875a4aa6bdf"), null },
                    { new Guid("5d83c7a6-059f-41a1-b1bc-4335783c8f1c"), new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), 55, new Guid("ce43f7ea-f0d8-4354-b2ac-c411b216a87b"), null },
                    { new Guid("7cb54c88-4eb3-40bf-911d-9a6975cb9fc5"), new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), 7, new Guid("13c721dd-c33f-4519-ba1f-712237a06323"), null },
                    { new Guid("f834ab9d-0ab4-4ddb-ba80-962d8fa78120"), new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), 56, new Guid("7e560e4b-cdc0-4d3d-998b-df9053813467"), null },
                    { new Guid("235daa1f-eec7-4ab8-8da8-d06c19ea13c8"), new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), 8, new Guid("1a1dc4db-08cb-4ade-a7f4-f8843013c857"), null },
                    { new Guid("703d884f-c38d-4278-bc5d-d6157cf5a7ab"), new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), 57, new Guid("76ab740d-8bd5-428a-a2a5-3d63779805f2"), null },
                    { new Guid("936bf90e-3faf-46eb-9ef4-85bc4bd20eba"), new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), 9, new Guid("2b0100f3-18b7-42c5-87e1-6805923f352d"), null },
                    { new Guid("c9147e42-94c1-45de-9f02-65d3433364fb"), new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), 58, new Guid("7be361b9-46bb-4797-98b5-12d985492302"), null },
                    { new Guid("1f93cf27-90ed-40d3-acca-6839eafe4352"), new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), 10, new Guid("7f61b85f-6c4f-453c-ba64-9d00df45ba8a"), null },
                    { new Guid("846b4d57-6be1-4631-b33e-9016895c0088"), new Guid("dfe40feb-4d01-4fcd-a58f-57a8d36831c0"), 59, new Guid("ba6d5954-364c-45cf-a55d-8a207c369761"), null },
                    { new Guid("b40bd7b0-73c2-4fd5-8b0d-dcc9f97074cb"), new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), 1, new Guid("29090939-1d95-4ac2-ab29-de91a2db1368"), null },
                    { new Guid("e78f14fd-d20e-4001-93b3-d4b9e18e4f19"), new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), 2, new Guid("091eab68-b90d-4e2c-ad39-87b06b9e46eb"), null },
                    { new Guid("6a052a7a-63c4-4044-a668-131017d4dde1"), new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), 3, new Guid("d9b1b83d-4e3d-45a1-bc68-c7828b92aad4"), null },
                    { new Guid("48d59e4a-f269-42ca-8fbe-9e501f8ae333"), new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), 4, new Guid("8c7e4657-c9bc-4cab-b825-e749cd42c358"), null },
                    { new Guid("2173146e-1679-4f43-87da-0dc1eb3ccad9"), new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), 5, new Guid("6512a227-b8b0-4aab-95a4-62f44e264bc8"), null },
                    { new Guid("eadc0316-d4ba-464e-b8a2-0c78569a9457"), new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), 6, new Guid("ef6ab149-ca29-4ec1-9f22-8875a4aa6bdf"), null },
                    { new Guid("42ce521c-f4ca-4ac7-ba2c-dd29b54a2bcf"), new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), 7, new Guid("13c721dd-c33f-4519-ba1f-712237a06323"), null },
                    { new Guid("6a37f097-53b6-4157-a1f4-136326ba857c"), new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), 8, new Guid("1a1dc4db-08cb-4ade-a7f4-f8843013c857"), null },
                    { new Guid("b47770e0-dd5e-428b-bd86-1a9163b4f351"), new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), 9, new Guid("2b0100f3-18b7-42c5-87e1-6805923f352d"), null },
                    { new Guid("fc84db75-3d5a-4a5f-82c0-76f86244d820"), new Guid("2a07367c-6a5c-442d-94d8-5429035e3972"), 10, new Guid("7f61b85f-6c4f-453c-ba64-9d00df45ba8a"), null },
                    { new Guid("c73660c9-8b08-458d-b1b1-7218536b4dad"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 22, new Guid("0c1c9d69-7d41-4a85-840b-13cff90fc467"), null },
                    { new Guid("5fb6a1a9-39bb-4c60-b86a-a9f514f3dc1b"), new Guid("3ab62c3e-89c7-4abf-909c-176f9cd1442d"), 23, new Guid("f9e13d86-cddd-4400-90d5-43571530b7db"), null }
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
