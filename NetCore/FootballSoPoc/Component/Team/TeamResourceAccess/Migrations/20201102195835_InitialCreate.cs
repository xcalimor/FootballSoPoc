using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamResourceAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Population = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ShortName = table.Column<string>(nullable: true),
                    ArenaName = table.Column<string>(nullable: true),
                    ArenaCapacity = table.Column<int>(nullable: false),
                    CityId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Teams_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Name", "Population" },
                values: new object[,]
                {
                    { new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"), "London", 8982000 },
                    { new Guid("e0b4c7fb-42c4-464a-a228-f38e38dcbb76"), "Middlesbrough", 140398 },
                    { new Guid("dd8e0177-2b75-404e-97bd-67bebade0ff2"), "Preston", 148836 },
                    { new Guid("f322e797-9f48-4025-90c3-ebe077933ca0"), "Blackburn", 117963 },
                    { new Guid("05bf0f04-df87-4edc-a228-ff7cd95e8c07"), "Stoke-on-Trent", 275000 },
                    { new Guid("4f0836d2-f05b-4cfc-95f8-d88b3bb6b703"), "Luton", 258018 },
                    { new Guid("9d6176f3-c202-4c9c-8c1a-db656f25e037"), "Swansea", 179485 },
                    { new Guid("cf492a97-7694-4d1b-b823-8bbdd207dbee"), "Norwich", 174047 },
                    { new Guid("cf0832cf-4597-4ed3-862b-3a1a199bfa62"), "Bournemouth", 187503 },
                    { new Guid("ce223e9c-3bdb-4708-8967-eb0db5141af7"), "Watford", 120960 },
                    { new Guid("4935afd2-4e06-469b-a473-bbb45fbdc96b"), "Bristol", 535907 },
                    { new Guid("f7059739-061f-4607-aed0-835dbf1afa43"), "Reading", 77997 },
                    { new Guid("5dda2ea6-e7c5-4c8f-a33f-ad6a2888419b"), "Wolverhampton", 77997 },
                    { new Guid("569510a4-0838-4b45-b16b-ebf75e2488e7"), "West Bromwich", 77997 },
                    { new Guid("4c3dc9ac-9e0d-448b-a8ae-d5148678e85f"), "Southampton", 253651 },
                    { new Guid("1a1f7b0c-aeb8-4c69-abe6-ef2fc3d34514"), "Sheffield", 518090 },
                    { new Guid("47d4ec37-672b-420b-bd89-d516b3198ee6"), "Newcastle", 268064 },
                    { new Guid("da404828-476e-4b75-a2bf-d3e3637fb192"), "Leicester", 329839 },
                    { new Guid("95159a2f-220c-4f10-a609-91877f025225"), "Leeds", 474632 },
                    { new Guid("735cd09a-54c1-4099-a42c-74ba561104cd"), "Manchester", 5107467 },
                    { new Guid("1cdfbf78-be27-4af0-a6e2-475bbfa72523"), "Liverpool", 552267 },
                    { new Guid("80170b4d-11a1-41c0-be79-3dedd6aef779"), "Burnley", 87300 },
                    { new Guid("97383535-9dd0-44b5-8387-11b4a12aee41"), "Brighton & Hove", 229700 },
                    { new Guid("ad1708fe-9ccb-4f2b-a541-00360e568a85"), "Birmingham", 1086000 },
                    { new Guid("0586927b-140b-4b7f-a8c4-f9bb57eb44ca"), "Huddersfield", 162949 },
                    { new Guid("9d320c88-6187-4f82-ab58-71c25e4a1567"), "Cardiff", 327706 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamId", "ArenaCapacity", "ArenaName", "CityId", "Name", "ShortName" },
                values: new object[,]
                {
                    { new Guid("29090939-1d95-4ac2-ab29-de91a2db1368"), 60704, "Emirates Stadium", new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"), "Arsenal", null },
                    { new Guid("2b0100f3-18b7-42c5-87e1-6805923f352d"), 37890, "Elland Road", new Guid("95159a2f-220c-4f10-a609-91877f025225"), "Leeds United", null },
                    { new Guid("7f61b85f-6c4f-453c-ba64-9d00df45ba8a"), 32312, "King Power Stadium", new Guid("da404828-476e-4b75-a2bf-d3e3637fb192"), "Leicester City", null },
                    { new Guid("9de989da-e454-46af-9faa-2f281cafa48b"), 52354, "St James' Park", new Guid("47d4ec37-672b-420b-bd89-d516b3198ee6"), "Newcastle United", null },
                    { new Guid("793f4d54-481e-42ae-80aa-1e714fd72a45"), 32609, "Bramall Lane", new Guid("1a1f7b0c-aeb8-4c69-abe6-ef2fc3d34514"), "Sheffield United", null },
                    { new Guid("e748c6a4-74a1-442a-8d04-3d5309f04129"), 32505, "St Mary's Stadium", new Guid("4c3dc9ac-9e0d-448b-a8ae-d5148678e85f"), "Southampton", null },
                    { new Guid("a4772a68-55f2-4d03-bf18-1bfe313d2935"), 26688, "The Hawthorns", new Guid("569510a4-0838-4b45-b16b-ebf75e2488e7"), "West Bromwich Albion", null },
                    { new Guid("0d5e25bf-f764-4644-bbf3-cf7ab2cff0ad"), 32050, "Molineux Stadium", new Guid("5dda2ea6-e7c5-4c8f-a33f-ad6a2888419b"), "Wolverhampton Wanderers", null },
                    { new Guid("a3f8eef4-8a92-407a-9402-d7dae78a7499"), 24161, "Madejski Stadium", new Guid("f7059739-061f-4607-aed0-835dbf1afa43"), "Reading", null },
                    { new Guid("72ad2911-1718-4196-8bbe-cc75c59318c0"), 74994, "Old Trafford", new Guid("735cd09a-54c1-4099-a42c-74ba561104cd"), "Manchester United", null },
                    { new Guid("bf852fa5-60f6-4104-94dd-71746b309d1b"), 27000, "Ashton Gate Stadium", new Guid("4935afd2-4e06-469b-a473-bbb45fbdc96b"), "Bristol City", null },
                    { new Guid("7fd4962c-a1e0-4c18-b7c5-1e2c9748debf"), 11364, "Vitality Stadium", new Guid("cf0832cf-4597-4ed3-862b-3a1a199bfa62"), "Bournemouth", null },
                    { new Guid("3fd0e4d7-5574-4de4-957f-41da87b26f5d"), 27244, "Carrow Road", new Guid("cf492a97-7694-4d1b-b823-8bbdd207dbee"), "Norwich City", null },
                    { new Guid("ce43f7ea-f0d8-4354-b2ac-c411b216a87b"), 21088, "Liberty Stadium", new Guid("9d6176f3-c202-4c9c-8c1a-db656f25e037"), "Swansea City", null },
                    { new Guid("7be361b9-46bb-4797-98b5-12d985492302"), 10356, "Kenilworth Road", new Guid("4f0836d2-f05b-4cfc-95f8-d88b3bb6b703"), "Luton Town", null },
                    { new Guid("76ab740d-8bd5-428a-a2a5-3d63779805f2"), 30089, "Bet365 Stadium", new Guid("05bf0f04-df87-4edc-a228-ff7cd95e8c07"), "Stoke City", null },
                    { new Guid("ba6d5954-364c-45cf-a55d-8a207c369761"), 31367, "Ewood Park", new Guid("f322e797-9f48-4025-90c3-ebe077933ca0"), "Blackburn Rovers", null },
                    { new Guid("3b52b592-a4bc-4b1c-8f7c-4fe467810dac"), 23404, "Deepdale", new Guid("dd8e0177-2b75-404e-97bd-67bebade0ff2"), "Preston North End", null },
                    { new Guid("676aa12b-2d46-4e4d-8dc9-67fecccd2ba5"), 34742, "Riverside Stadium", new Guid("e0b4c7fb-42c4-464a-a228-f38e38dcbb76"), "Middlesbrough", null },
                    { new Guid("d45e9dfb-7032-40e9-b871-18901f791536"), 21577, "Vicarage Road", new Guid("ce223e9c-3bdb-4708-8967-eb0db5141af7"), "Watford", null },
                    { new Guid("f5779213-14b6-45df-8033-d99355b8315c"), 55097, "Etihad Stadium", new Guid("735cd09a-54c1-4099-a42c-74ba561104cd"), "Manchester City", null },
                    { new Guid("52bff2ff-b926-4f4a-8c0b-3ee37b245e2d"), 54074, "Anfield", new Guid("1cdfbf78-be27-4af0-a6e2-475bbfa72523"), "Liverpool", null },
                    { new Guid("13c721dd-c33f-4519-ba1f-712237a06323"), 39572, "Goodison Park", new Guid("1cdfbf78-be27-4af0-a6e2-475bbfa72523"), "Everton", null },
                    { new Guid("6512a227-b8b0-4aab-95a4-62f44e264bc8"), 41631, "Stamford Bridge", new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"), "Chelsea", null },
                    { new Guid("ef6ab149-ca29-4ec1-9f22-8875a4aa6bdf"), 26125, "Selhurst Park", new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"), "Crystal Palace", null },
                    { new Guid("1a1dc4db-08cb-4ade-a7f4-f8843013c857"), 25700, "Craven Cottage", new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"), "Fulham", null },
                    { new Guid("159136ef-515e-472c-bbb7-ca74d5129ae7"), 62062, "Tottenham Hotspur Stadium", new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"), "Tottenham Hotspur", null },
                    { new Guid("04e9d666-dfcb-4692-8d87-f4840b8549d5"), 60000, "Londons Olympiastadion", new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"), "West Ham United", null },
                    { new Guid("7e560e4b-cdc0-4d3d-998b-df9053813467"), 20146, "The Den", new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"), "Millwall", null },
                    { new Guid("a596da7e-8406-42ab-ab87-9f103ee47272"), 17250, "Brentford Community Stadium", new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"), "Brentford", null },
                    { new Guid("ed671605-1872-4089-8f2e-4cd9a9f68b72"), 18439, "Loftus Road", new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"), "Queens Park Rangers", null },
                    { new Guid("78d33450-f3dc-4bfd-a01f-1a0e91b75f1a"), 18439, "Loftus Road", new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"), "Birmingham City", null },
                    { new Guid("38c2bce5-de53-42e4-b61f-b64113c9d463"), 18439, "Loftus Road", new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"), "Rotherham United", null },
                    { new Guid("446090dc-4edf-49ef-be12-0f337caa5c39"), 18439, "Loftus Road", new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"), "Nottingham Forest", null },
                    { new Guid("ccc7f427-9b43-4149-9d30-d381a86a146d"), 18439, "Loftus Road", new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"), "Coventry City", null },
                    { new Guid("787aba1d-e768-4c7e-9128-e04fc7f25564"), 18439, "Loftus Road", new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"), "Barnsley", null },
                    { new Guid("3ba8507e-90de-4c09-97ad-eec460368c6c"), 18439, "Loftus Road", new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"), "Derby County", null },
                    { new Guid("0c1c9d69-7d41-4a85-840b-13cff90fc467"), 18439, "Loftus Road", new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"), "Wycombe Wanderers", null },
                    { new Guid("f9e13d86-cddd-4400-90d5-43571530b7db"), 18439, "Loftus Road", new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"), "Sheffield Wednesday", null },
                    { new Guid("091eab68-b90d-4e2c-ad39-87b06b9e46eb"), 42749, "Villa Park", new Guid("ad1708fe-9ccb-4f2b-a541-00360e568a85"), "Aston Villa", null },
                    { new Guid("d9b1b83d-4e3d-45a1-bc68-c7828b92aad4"), 30750, "American Express Community Stadium", new Guid("97383535-9dd0-44b5-8387-11b4a12aee41"), "Brighton & Hove Albion", null },
                    { new Guid("8c7e4657-c9bc-4cab-b825-e749cd42c358"), 21944, "Turf Moor", new Guid("80170b4d-11a1-41c0-be79-3dedd6aef779"), "Burnley", null },
                    { new Guid("ae927c9d-fcd1-4bfc-8259-f8014e74b2e5"), 24500, "John Smith's Stadium", new Guid("0586927b-140b-4b7f-a8c4-f9bb57eb44ca"), "Huddersfield Town", null },
                    { new Guid("ef0e5227-f51f-4f7f-9d24-9a6a208c3a15"), 33280, "Cardiff City Stadium", new Guid("9d320c88-6187-4f82-ab58-71c25e4a1567"), "Cardiff City", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CityId",
                table: "Teams",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
