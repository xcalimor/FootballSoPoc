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
                    { new Guid("898269d8-b79e-465c-9d40-8d8f577f7a2e"), "London", 8982000 },
                    { new Guid("05436ac7-5fb0-41f0-9939-f5e95c99db52"), "Birmingham", 1086000 },
                    { new Guid("b6fe9a4c-1335-4138-a0b6-b346877119de"), "Brighton & Hove", 229700 },
                    { new Guid("d579678f-471f-4baa-a287-2e79b68c5831"), "Burnley", 87300 },
                    { new Guid("b91daa8f-0264-49de-902b-d37dcaa6747c"), "Liverpool", 552267 },
                    { new Guid("43ce358e-69c1-4057-8858-9c5d9e348ca1"), "Manchester", 5107467 },
                    { new Guid("9393f183-f7b0-429b-be8f-621d064376d7"), "Leeds", 474632 },
                    { new Guid("5909027d-5015-46a8-b9c8-a97b69c07f51"), "Leicester", 329839 },
                    { new Guid("873696eb-739d-418f-9b87-f6426877d898"), "Newcastle", 268064 },
                    { new Guid("977529f5-e55a-4ff4-903f-ea6461b9615e"), "Sheffield", 518090 },
                    { new Guid("ea7e18da-299d-4a7b-a30e-39aa6b3c1150"), "Southampton", 253651 },
                    { new Guid("9ebd32aa-d855-4e2c-bb62-0163bf72731a"), "West Bromwich", 77997 },
                    { new Guid("2516ced0-f6a5-458a-ac44-be956c96efa4"), "Wolverhampton", 77997 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamId", "ArenaCapacity", "ArenaName", "CityId", "Name", "ShortName" },
                values: new object[,]
                {
                    { new Guid("5af268a1-4fa7-4005-a6a6-7b8043369099"), 60704, "Emirates Stadium", new Guid("898269d8-b79e-465c-9d40-8d8f577f7a2e"), "Arsenal", null },
                    { new Guid("d7657658-e19e-419e-939b-761a56cbe8ff"), 32505, "St Mary's Stadium", new Guid("ea7e18da-299d-4a7b-a30e-39aa6b3c1150"), "Southampton", null },
                    { new Guid("36b5f68e-3c7d-4e02-b762-87cb0d188059"), 32609, "Bramall Lane", new Guid("977529f5-e55a-4ff4-903f-ea6461b9615e"), "Sheffield United", null },
                    { new Guid("6a1c09ff-bfba-4de4-80ee-0ba8b22893da"), 52354, "St James' Park", new Guid("873696eb-739d-418f-9b87-f6426877d898"), "Newcastle United", null },
                    { new Guid("28e14756-07e0-45e2-b6d1-2e31d45d30de"), 32312, "King Power Stadium", new Guid("5909027d-5015-46a8-b9c8-a97b69c07f51"), "Leicester City", null },
                    { new Guid("380b51f9-e320-417c-b5a2-c5350b4d237e"), 37890, "Elland Road", new Guid("9393f183-f7b0-429b-be8f-621d064376d7"), "Leeds United", null },
                    { new Guid("cd1854b0-db0d-44b2-9be2-13e3beeef948"), 74994, "Old Trafford", new Guid("43ce358e-69c1-4057-8858-9c5d9e348ca1"), "Manchester United", null },
                    { new Guid("19e7888b-8991-4eaf-9b50-048882907567"), 55097, "Etihad Stadium", new Guid("43ce358e-69c1-4057-8858-9c5d9e348ca1"), "Manchester City", null },
                    { new Guid("de980dbf-f051-4ec1-988d-8c7f3d4e9461"), 54074, "Anfield", new Guid("b91daa8f-0264-49de-902b-d37dcaa6747c"), "Liverpool", null },
                    { new Guid("a0211fe7-a5e2-4e3a-b3f7-4022aeedf913"), 39572, "Goodison Park", new Guid("b91daa8f-0264-49de-902b-d37dcaa6747c"), "Everton", null },
                    { new Guid("30d920d8-5b28-4bf6-85f0-83749e20839a"), 21944, "Turf Moor", new Guid("d579678f-471f-4baa-a287-2e79b68c5831"), "Burnley", null },
                    { new Guid("e054c5ab-cfaf-4922-bcff-f11d25ca8603"), 30750, "American Express Community Stadium", new Guid("b6fe9a4c-1335-4138-a0b6-b346877119de"), "Brighton & Hove Albion", null },
                    { new Guid("68db61d7-c3ea-4b9b-8f6b-77d406e56d38"), 42749, "Villa Park", new Guid("05436ac7-5fb0-41f0-9939-f5e95c99db52"), "Aston Villa", null },
                    { new Guid("d2dadc8f-8d84-429e-8d75-6ae37241efb5"), 60000, "Londons Olympiastadion", new Guid("898269d8-b79e-465c-9d40-8d8f577f7a2e"), "West Ham United", null },
                    { new Guid("01414cc2-6167-4f9d-9788-de3f605d26cc"), 62062, "Tottenham Hotspur Stadium", new Guid("898269d8-b79e-465c-9d40-8d8f577f7a2e"), "Tottenham Hotspur", null },
                    { new Guid("d1442bcb-adae-4f6d-9f6d-a39bfb98c82f"), 25700, "Craven Cottage", new Guid("898269d8-b79e-465c-9d40-8d8f577f7a2e"), "Fulham", null },
                    { new Guid("95338159-781c-466a-a92b-3438d2c30805"), 26125, "Selhurst Park", new Guid("898269d8-b79e-465c-9d40-8d8f577f7a2e"), "Crystal Palace", null },
                    { new Guid("ba21570b-8024-470c-93a5-e65e44ac2f39"), 41631, "Stamford Bridge", new Guid("898269d8-b79e-465c-9d40-8d8f577f7a2e"), "Chelsea", null },
                    { new Guid("cefc13ba-fcdf-4ab6-b862-bec6a70fd81f"), 26688, "The Hawthorns", new Guid("9ebd32aa-d855-4e2c-bb62-0163bf72731a"), "West Bromwich Albion", null },
                    { new Guid("5c3da3dc-35e3-4099-bc9a-258491e8ae21"), 32050, "Molineux Stadium", new Guid("2516ced0-f6a5-458a-ac44-be956c96efa4"), "Wolverhampton Wanderers", null }
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
