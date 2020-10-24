using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TeamResourceAccess.Migrations
{
    public partial class UpdatedIdToFixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("01414cc2-6167-4f9d-9788-de3f605d26cc"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("19e7888b-8991-4eaf-9b50-048882907567"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("28e14756-07e0-45e2-b6d1-2e31d45d30de"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("30d920d8-5b28-4bf6-85f0-83749e20839a"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("36b5f68e-3c7d-4e02-b762-87cb0d188059"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("380b51f9-e320-417c-b5a2-c5350b4d237e"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("5af268a1-4fa7-4005-a6a6-7b8043369099"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("5c3da3dc-35e3-4099-bc9a-258491e8ae21"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("68db61d7-c3ea-4b9b-8f6b-77d406e56d38"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("6a1c09ff-bfba-4de4-80ee-0ba8b22893da"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("95338159-781c-466a-a92b-3438d2c30805"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("a0211fe7-a5e2-4e3a-b3f7-4022aeedf913"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("ba21570b-8024-470c-93a5-e65e44ac2f39"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("cd1854b0-db0d-44b2-9be2-13e3beeef948"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("cefc13ba-fcdf-4ab6-b862-bec6a70fd81f"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("d1442bcb-adae-4f6d-9f6d-a39bfb98c82f"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("d2dadc8f-8d84-429e-8d75-6ae37241efb5"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("d7657658-e19e-419e-939b-761a56cbe8ff"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("de980dbf-f051-4ec1-988d-8c7f3d4e9461"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("e054c5ab-cfaf-4922-bcff-f11d25ca8603"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("05436ac7-5fb0-41f0-9939-f5e95c99db52"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("2516ced0-f6a5-458a-ac44-be956c96efa4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("43ce358e-69c1-4057-8858-9c5d9e348ca1"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("5909027d-5015-46a8-b9c8-a97b69c07f51"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("873696eb-739d-418f-9b87-f6426877d898"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("898269d8-b79e-465c-9d40-8d8f577f7a2e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("9393f183-f7b0-429b-be8f-621d064376d7"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("977529f5-e55a-4ff4-903f-ea6461b9615e"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("9ebd32aa-d855-4e2c-bb62-0163bf72731a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("b6fe9a4c-1335-4138-a0b6-b346877119de"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("b91daa8f-0264-49de-902b-d37dcaa6747c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("d579678f-471f-4baa-a287-2e79b68c5831"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("ea7e18da-299d-4a7b-a30e-39aa6b3c1150"));

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Name", "Population" },
                values: new object[,]
                {
                    { new Guid("e6702b3d-efba-4cf5-96f8-2d6a04a0afa6"), "London", 8982000 },
                    { new Guid("85e36e3e-c82c-42ef-8abe-bd4dab8330a6"), "Birmingham", 1086000 },
                    { new Guid("0dc27382-45b0-45e5-8bea-5c694909a290"), "Brighton & Hove", 229700 },
                    { new Guid("d24188c9-644e-4e51-ba8d-d9ffcfd24954"), "Burnley", 87300 },
                    { new Guid("369d69e3-966c-40f9-85a8-4df20cea29b8"), "Liverpool", 552267 },
                    { new Guid("146ee191-8c3b-4c21-8889-47ad0222a5fa"), "Manchester", 5107467 },
                    { new Guid("b880e420-84e7-48cd-96bd-ebfd02d7ce0c"), "Leeds", 474632 },
                    { new Guid("8a90901a-340a-4e2f-989f-8f874d354edf"), "Leicester", 329839 },
                    { new Guid("37340c2c-2c9e-448b-9fb7-bb35bd747780"), "Newcastle", 268064 },
                    { new Guid("66300e5b-5e68-49c6-8286-ba74b045f54a"), "Sheffield", 518090 },
                    { new Guid("ee4c692d-ae5a-4230-9d66-e3a071cdeca4"), "Southampton", 253651 },
                    { new Guid("6826604e-3432-4f53-a68f-3a9770292c3f"), "West Bromwich", 77997 },
                    { new Guid("f5b1edea-f64d-4942-8f5d-32441a77303c"), "Wolverhampton", 77997 }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamId", "ArenaCapacity", "ArenaName", "CityId", "Name", "ShortName" },
                values: new object[,]
                {
                    { new Guid("29090939-1d95-4ac2-ab29-de91a2db1368"), 60704, "Emirates Stadium", new Guid("e6702b3d-efba-4cf5-96f8-2d6a04a0afa6"), "Arsenal", null },
                    { new Guid("e748c6a4-74a1-442a-8d04-3d5309f04129"), 32505, "St Mary's Stadium", new Guid("ee4c692d-ae5a-4230-9d66-e3a071cdeca4"), "Southampton", null },
                    { new Guid("793f4d54-481e-42ae-80aa-1e714fd72a45"), 32609, "Bramall Lane", new Guid("66300e5b-5e68-49c6-8286-ba74b045f54a"), "Sheffield United", null },
                    { new Guid("9de989da-e454-46af-9faa-2f281cafa48b"), 52354, "St James' Park", new Guid("37340c2c-2c9e-448b-9fb7-bb35bd747780"), "Newcastle United", null },
                    { new Guid("7f61b85f-6c4f-453c-ba64-9d00df45ba8a"), 32312, "King Power Stadium", new Guid("8a90901a-340a-4e2f-989f-8f874d354edf"), "Leicester City", null },
                    { new Guid("2b0100f3-18b7-42c5-87e1-6805923f352d"), 37890, "Elland Road", new Guid("b880e420-84e7-48cd-96bd-ebfd02d7ce0c"), "Leeds United", null },
                    { new Guid("72ad2911-1718-4196-8bbe-cc75c59318c0"), 74994, "Old Trafford", new Guid("146ee191-8c3b-4c21-8889-47ad0222a5fa"), "Manchester United", null },
                    { new Guid("f5779213-14b6-45df-8033-d99355b8315c"), 55097, "Etihad Stadium", new Guid("146ee191-8c3b-4c21-8889-47ad0222a5fa"), "Manchester City", null },
                    { new Guid("52bff2ff-b926-4f4a-8c0b-3ee37b245e2d"), 54074, "Anfield", new Guid("369d69e3-966c-40f9-85a8-4df20cea29b8"), "Liverpool", null },
                    { new Guid("13c721dd-c33f-4519-ba1f-712237a06323"), 39572, "Goodison Park", new Guid("369d69e3-966c-40f9-85a8-4df20cea29b8"), "Everton", null },
                    { new Guid("8c7e4657-c9bc-4cab-b825-e749cd42c358"), 21944, "Turf Moor", new Guid("d24188c9-644e-4e51-ba8d-d9ffcfd24954"), "Burnley", null },
                    { new Guid("d9b1b83d-4e3d-45a1-bc68-c7828b92aad4"), 30750, "American Express Community Stadium", new Guid("0dc27382-45b0-45e5-8bea-5c694909a290"), "Brighton & Hove Albion", null },
                    { new Guid("091eab68-b90d-4e2c-ad39-87b06b9e46eb"), 42749, "Villa Park", new Guid("85e36e3e-c82c-42ef-8abe-bd4dab8330a6"), "Aston Villa", null },
                    { new Guid("04e9d666-dfcb-4692-8d87-f4840b8549d5"), 60000, "Londons Olympiastadion", new Guid("e6702b3d-efba-4cf5-96f8-2d6a04a0afa6"), "West Ham United", null },
                    { new Guid("159136ef-515e-472c-bbb7-ca74d5129ae7"), 62062, "Tottenham Hotspur Stadium", new Guid("e6702b3d-efba-4cf5-96f8-2d6a04a0afa6"), "Tottenham Hotspur", null },
                    { new Guid("1a1dc4db-08cb-4ade-a7f4-f8843013c857"), 25700, "Craven Cottage", new Guid("e6702b3d-efba-4cf5-96f8-2d6a04a0afa6"), "Fulham", null },
                    { new Guid("ef6ab149-ca29-4ec1-9f22-8875a4aa6bdf"), 26125, "Selhurst Park", new Guid("e6702b3d-efba-4cf5-96f8-2d6a04a0afa6"), "Crystal Palace", null },
                    { new Guid("6512a227-b8b0-4aab-95a4-62f44e264bc8"), 41631, "Stamford Bridge", new Guid("e6702b3d-efba-4cf5-96f8-2d6a04a0afa6"), "Chelsea", null },
                    { new Guid("a4772a68-55f2-4d03-bf18-1bfe313d2935"), 26688, "The Hawthorns", new Guid("6826604e-3432-4f53-a68f-3a9770292c3f"), "West Bromwich Albion", null },
                    { new Guid("0d5e25bf-f764-4644-bbf3-cf7ab2cff0ad"), 32050, "Molineux Stadium", new Guid("f5b1edea-f64d-4942-8f5d-32441a77303c"), "Wolverhampton Wanderers", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("04e9d666-dfcb-4692-8d87-f4840b8549d5"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("091eab68-b90d-4e2c-ad39-87b06b9e46eb"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("0d5e25bf-f764-4644-bbf3-cf7ab2cff0ad"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("13c721dd-c33f-4519-ba1f-712237a06323"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("159136ef-515e-472c-bbb7-ca74d5129ae7"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("1a1dc4db-08cb-4ade-a7f4-f8843013c857"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("29090939-1d95-4ac2-ab29-de91a2db1368"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("2b0100f3-18b7-42c5-87e1-6805923f352d"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("52bff2ff-b926-4f4a-8c0b-3ee37b245e2d"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("6512a227-b8b0-4aab-95a4-62f44e264bc8"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("72ad2911-1718-4196-8bbe-cc75c59318c0"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("793f4d54-481e-42ae-80aa-1e714fd72a45"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("7f61b85f-6c4f-453c-ba64-9d00df45ba8a"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("8c7e4657-c9bc-4cab-b825-e749cd42c358"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("9de989da-e454-46af-9faa-2f281cafa48b"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("a4772a68-55f2-4d03-bf18-1bfe313d2935"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("d9b1b83d-4e3d-45a1-bc68-c7828b92aad4"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("e748c6a4-74a1-442a-8d04-3d5309f04129"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("ef6ab149-ca29-4ec1-9f22-8875a4aa6bdf"));

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: new Guid("f5779213-14b6-45df-8033-d99355b8315c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("0dc27382-45b0-45e5-8bea-5c694909a290"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("146ee191-8c3b-4c21-8889-47ad0222a5fa"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("369d69e3-966c-40f9-85a8-4df20cea29b8"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("37340c2c-2c9e-448b-9fb7-bb35bd747780"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("66300e5b-5e68-49c6-8286-ba74b045f54a"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("6826604e-3432-4f53-a68f-3a9770292c3f"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("85e36e3e-c82c-42ef-8abe-bd4dab8330a6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("8a90901a-340a-4e2f-989f-8f874d354edf"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("b880e420-84e7-48cd-96bd-ebfd02d7ce0c"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("d24188c9-644e-4e51-ba8d-d9ffcfd24954"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("e6702b3d-efba-4cf5-96f8-2d6a04a0afa6"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("ee4c692d-ae5a-4230-9d66-e3a071cdeca4"));

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: new Guid("f5b1edea-f64d-4942-8f5d-32441a77303c"));

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
        }
    }
}
