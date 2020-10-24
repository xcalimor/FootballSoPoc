using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlayerResourceAccess.Migrations
{
    public partial class AddedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GoalStatsDetails_Players_PlayerId",
                table: "GoalStatsDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerAggregatedStats_Players_PlayertId",
                table: "PlayerAggregatedStats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerAggregatedStats",
                table: "PlayerAggregatedStats");

            migrationBuilder.DropIndex(
                name: "IX_PlayerAggregatedStats_PlayertId",
                table: "PlayerAggregatedStats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GoalStatsDetails",
                table: "GoalStatsDetails");

            migrationBuilder.DropIndex(
                name: "IX_GoalStatsDetails_PlayerId",
                table: "GoalStatsDetails");

            migrationBuilder.DropColumn(
                name: "PlayertId",
                table: "PlayerAggregatedStats");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "GoalStatsDetails");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "PlayerAggregatedStats",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "LeagueId",
                table: "PlayerAggregatedStats",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Team",
                table: "PlayerAggregatedStats",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "PlayerId",
                table: "GoalStatsDetails",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerAggregatedStats",
                table: "PlayerAggregatedStats",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GoalStatsDetails",
                table: "GoalStatsDetails",
                column: "PlayerId");

            migrationBuilder.InsertData(
                table: "GoalStatsDetails",
                columns: new[] { "PlayerId", "At", "ForTeamId", "GameTime", "GoalMadeNotSaved", "InLeagueId" },
                values: new object[,]
                {
                    { new Guid("540eb7bc-95f6-4978-b2a7-57190c27c62a"), new DateTime(2020, 10, 24, 17, 48, 10, 971, DateTimeKind.Local).AddTicks(3696), new Guid("29090939-1d95-4ac2-ab29-de91a2db1368"), 73, true, new Guid("c7128ccb-09ce-40c4-8a42-9180bab68360") },
                    { new Guid("742f4d2b-9cfb-4076-a31a-69e214ee3e9b"), new DateTime(2020, 10, 24, 17, 48, 10, 975, DateTimeKind.Local).AddTicks(2835), new Guid("0d5e25bf-f764-4644-bbf3-cf7ab2cff0ad"), 73, true, new Guid("c449b789-41ef-400c-b08a-4dd863be2182") },
                    { new Guid("ae0c3e2b-6268-47bc-9698-1c93d3546829"), new DateTime(2020, 10, 24, 17, 48, 10, 975, DateTimeKind.Local).AddTicks(2729), new Guid("a4772a68-55f2-4d03-bf18-1bfe313d2935"), 73, true, new Guid("90778e95-e2bf-4975-9ad1-664f97cd984f") },
                    { new Guid("c50db5c5-7689-41c7-9887-c5ed7b2580a5"), new DateTime(2020, 10, 24, 17, 48, 10, 975, DateTimeKind.Local).AddTicks(2675), new Guid("159136ef-515e-472c-bbb7-ca74d5129ae7"), 73, true, new Guid("12c7102a-24a5-49de-8a30-20d3baaca880") },
                    { new Guid("fcfaeb2c-2ea4-4572-a54e-06673bd2b75b"), new DateTime(2020, 10, 24, 17, 48, 10, 975, DateTimeKind.Local).AddTicks(2621), new Guid("e748c6a4-74a1-442a-8d04-3d5309f04129"), 73, true, new Guid("1c5bdb49-518a-420b-992f-89b328bcc28b") },
                    { new Guid("8c869811-81fa-47fa-8536-164a9dcd3b69"), new DateTime(2020, 10, 24, 17, 48, 10, 975, DateTimeKind.Local).AddTicks(2569), new Guid("793f4d54-481e-42ae-80aa-1e714fd72a45"), 73, true, new Guid("8433662e-bbae-46ba-b3a1-eefcee373c51") },
                    { new Guid("3bddf1ee-6be8-4634-aabd-e7a1151c1b50"), new DateTime(2020, 10, 24, 17, 48, 10, 975, DateTimeKind.Local).AddTicks(2514), new Guid("9de989da-e454-46af-9faa-2f281cafa48b"), 73, true, new Guid("7030ea78-a034-4ea4-b027-0a71c641eda8") },
                    { new Guid("78955ce8-fb5c-4c85-99cc-1845b11a0a12"), new DateTime(2020, 10, 24, 17, 48, 10, 975, DateTimeKind.Local).AddTicks(2461), new Guid("72ad2911-1718-4196-8bbe-cc75c59318c0"), 73, true, new Guid("7ecbebda-8312-463a-bd5f-4c9441ed3df8") },
                    { new Guid("fad463d7-abc3-4e1b-b279-d84f52bf8426"), new DateTime(2020, 10, 24, 17, 48, 10, 975, DateTimeKind.Local).AddTicks(2369), new Guid("f5779213-14b6-45df-8033-d99355b8315c"), 73, true, new Guid("a9fb103d-5118-4839-8925-0d279306e231") },
                    { new Guid("e8fdafee-a7cd-4f1f-8359-b39507f9af93"), new DateTime(2020, 10, 24, 17, 48, 10, 975, DateTimeKind.Local).AddTicks(2317), new Guid("52bff2ff-b926-4f4a-8c0b-3ee37b245e2d"), 73, true, new Guid("49fbcee7-c525-480f-9ca8-3c6557d2a8a4") },
                    { new Guid("6e31581c-777d-4c1a-a5df-efa51b782e6e"), new DateTime(2020, 10, 24, 17, 48, 10, 975, DateTimeKind.Local).AddTicks(2783), new Guid("04e9d666-dfcb-4692-8d87-f4840b8549d5"), 73, true, new Guid("c4bd2cf3-2a13-47ea-af72-31922c0eec57") },
                    { new Guid("58ce6649-c1fb-473f-9685-6f85ff87b84b"), new DateTime(2020, 10, 24, 17, 48, 10, 975, DateTimeKind.Local).AddTicks(2208), new Guid("2b0100f3-18b7-42c5-87e1-6805923f352d"), 73, true, new Guid("a39bd94c-6566-4ef0-80ba-69412ae8a300") },
                    { new Guid("0682baec-826b-4197-a64c-42c4a6b53e40"), new DateTime(2020, 10, 24, 17, 48, 10, 975, DateTimeKind.Local).AddTicks(2262), new Guid("7f61b85f-6c4f-453c-ba64-9d00df45ba8a"), 73, true, new Guid("1fe0998b-8504-475d-b59e-571d1773352a") },
                    { new Guid("bd3d62fb-8e71-41f4-a555-a1ae2c8e89d7"), new DateTime(2020, 10, 24, 17, 48, 10, 975, DateTimeKind.Local).AddTicks(1818), new Guid("d9b1b83d-4e3d-45a1-bc68-c7828b92aad4"), 73, true, new Guid("3720d8c3-11e8-4795-9cc6-e58c26ef32c9") },
                    { new Guid("9ae9e82d-79aa-4cfb-bf39-f18e09e2d6eb"), new DateTime(2020, 10, 24, 17, 48, 10, 975, DateTimeKind.Local).AddTicks(1879), new Guid("8c7e4657-c9bc-4cab-b825-e749cd42c358"), 73, true, new Guid("1ff0169b-d9b5-46af-b0b5-92fbbc0ac76d") },
                    { new Guid("6a2e96a5-9876-4e73-9bb3-7bfc0cf772a3"), new DateTime(2020, 10, 24, 17, 48, 10, 975, DateTimeKind.Local).AddTicks(1630), new Guid("091eab68-b90d-4e2c-ad39-87b06b9e46eb"), 73, true, new Guid("4b1f9e19-a606-43e9-ad44-1efac3e8cd0c") },
                    { new Guid("99793a6c-6e50-4a48-b10a-57125f64060f"), new DateTime(2020, 10, 24, 17, 48, 10, 975, DateTimeKind.Local).AddTicks(2043), new Guid("ef6ab149-ca29-4ec1-9f22-8875a4aa6bdf"), 73, true, new Guid("03406e0d-6464-470b-aa51-e7a83bb0f60c") },
                    { new Guid("fe5effd4-02b6-436e-87f9-f51b4f340c23"), new DateTime(2020, 10, 24, 17, 48, 10, 975, DateTimeKind.Local).AddTicks(2100), new Guid("13c721dd-c33f-4519-ba1f-712237a06323"), 73, true, new Guid("9cc07c34-2bac-4e45-9cac-a85a240d393c") },
                    { new Guid("45dd0326-135f-46c1-bb85-a29801da504e"), new DateTime(2020, 10, 24, 17, 48, 10, 975, DateTimeKind.Local).AddTicks(2154), new Guid("1a1dc4db-08cb-4ade-a7f4-f8843013c857"), 73, true, new Guid("dc7361e4-9b7c-4a41-bce4-176be1c49441") },
                    { new Guid("eee18c0c-1696-4cf6-bb78-b2680da9499d"), new DateTime(2020, 10, 24, 17, 48, 10, 975, DateTimeKind.Local).AddTicks(1984), new Guid("6512a227-b8b0-4aab-95a4-62f44e264bc8"), 73, true, new Guid("23d68bb6-f81e-4bd5-84ad-cd782b6320cd") }
                });

            migrationBuilder.InsertData(
                table: "PlayerAggregatedStats",
                columns: new[] { "Id", "Assists", "GamesPlayed", "GoalsMade", "GoalsSaved", "LeagueId", "MinutesPlayed", "PlayerId", "Team" },
                values: new object[,]
                {
                    { new Guid("336c91c1-1cf4-44b7-8adc-229eb19f45b3"), 12, 12, 12, 21, new Guid("00000000-0000-0000-0000-000000000000"), 123, new Guid("bd3d62fb-8e71-41f4-a555-a1ae2c8e89d7"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("1c340774-dbce-4f06-b441-d6287c7b4aa2"), 12, 12, 12, 21, new Guid("00000000-0000-0000-0000-000000000000"), 123, new Guid("58ce6649-c1fb-473f-9685-6f85ff87b84b"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("5678a97c-cd99-441f-be38-5a55a3acc810"), 12, 12, 12, 21, new Guid("00000000-0000-0000-0000-000000000000"), 123, new Guid("9ae9e82d-79aa-4cfb-bf39-f18e09e2d6eb"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("dbd69dfd-0ae6-47ee-987b-d1963024ff96"), 12, 12, 12, 21, new Guid("00000000-0000-0000-0000-000000000000"), 123, new Guid("eee18c0c-1696-4cf6-bb78-b2680da9499d"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("77617889-fb46-4295-a659-f0418df74e63"), 12, 12, 12, 21, new Guid("00000000-0000-0000-0000-000000000000"), 123, new Guid("99793a6c-6e50-4a48-b10a-57125f64060f"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("51b34ed2-64f3-4f91-8fc6-b5b8bbb31f01"), 12, 12, 12, 21, new Guid("00000000-0000-0000-0000-000000000000"), 123, new Guid("fe5effd4-02b6-436e-87f9-f51b4f340c23"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("027ee014-f0a2-40c3-994e-c70ca61a2d2e"), 12, 12, 12, 21, new Guid("00000000-0000-0000-0000-000000000000"), 123, new Guid("45dd0326-135f-46c1-bb85-a29801da504e"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("4430729a-49e2-4933-b026-1acb7f0a92ff"), 12, 12, 12, 21, new Guid("00000000-0000-0000-0000-000000000000"), 123, new Guid("0682baec-826b-4197-a64c-42c4a6b53e40"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7b8988cf-ff94-4715-9057-6f3afcb562df"), 12, 12, 12, 21, new Guid("00000000-0000-0000-0000-000000000000"), 123, new Guid("3bddf1ee-6be8-4634-aabd-e7a1151c1b50"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bb80d622-da97-430a-8a4d-6a61bf3dc1ce"), 12, 12, 12, 21, new Guid("00000000-0000-0000-0000-000000000000"), 123, new Guid("fad463d7-abc3-4e1b-b279-d84f52bf8426"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("55c42fd4-f1bc-4951-aaad-438b4d598502"), 12, 12, 12, 21, new Guid("00000000-0000-0000-0000-000000000000"), 123, new Guid("78955ce8-fb5c-4c85-99cc-1845b11a0a12"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("e112d89a-47a8-4102-87ca-fde3726133e8"), 12, 12, 12, 21, new Guid("00000000-0000-0000-0000-000000000000"), 123, new Guid("8c869811-81fa-47fa-8536-164a9dcd3b69"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ad24f748-d872-47e9-8550-8d522990429b"), 12, 12, 12, 21, new Guid("00000000-0000-0000-0000-000000000000"), 123, new Guid("fcfaeb2c-2ea4-4572-a54e-06673bd2b75b"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("bbed6536-36d6-4c71-8ac3-642a021b7cc7"), 12, 12, 12, 21, new Guid("00000000-0000-0000-0000-000000000000"), 123, new Guid("c50db5c5-7689-41c7-9887-c5ed7b2580a5"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("dfe7f98c-68c1-4c7b-93b9-1d833ad45538"), 12, 12, 12, 21, new Guid("00000000-0000-0000-0000-000000000000"), 123, new Guid("ae0c3e2b-6268-47bc-9698-1c93d3546829"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("7872f236-2b74-41c9-8702-f53417144bce"), 12, 12, 12, 21, new Guid("00000000-0000-0000-0000-000000000000"), 123, new Guid("6a2e96a5-9876-4e73-9bb3-7bfc0cf772a3"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("d1e3be08-f470-4ebf-b029-25225e25c150"), 12, 12, 12, 21, new Guid("00000000-0000-0000-0000-000000000000"), 123, new Guid("e8fdafee-a7cd-4f1f-8359-b39507f9af93"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ea0fdcb0-8d0f-47a4-b770-f98e7738e7d9"), 12, 12, 12, 21, new Guid("00000000-0000-0000-0000-000000000000"), 123, new Guid("540eb7bc-95f6-4978-b2a7-57190c27c62a"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("0846bdab-281d-4621-8e9b-8182700f2c4c"), 12, 12, 12, 21, new Guid("00000000-0000-0000-0000-000000000000"), 123, new Guid("742f4d2b-9cfb-4076-a31a-69e214ee3e9b"), new Guid("00000000-0000-0000-0000-000000000000") },
                    { new Guid("ff572d68-5174-4bf3-b037-d5797cd99e87"), 12, 12, 12, 21, new Guid("00000000-0000-0000-0000-000000000000"), 123, new Guid("6e31581c-777d-4c1a-a5df-efa51b782e6e"), new Guid("00000000-0000-0000-0000-000000000000") }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "Deffensive", "Firstname", "GameIQ", "Height", "Offensive", "Reaction", "Stamina", "Surname", "TeamId", "Weight" },
                values: new object[,]
                {
                    { new Guid("742f4d2b-9cfb-4076-a31a-69e214ee3e9b"), 39, 60, "Arne", 98, 182, 63, 99, 90, "Swinton", new Guid("0d5e25bf-f764-4644-bbf3-cf7ab2cff0ad"), 99 },
                    { new Guid("540eb7bc-95f6-4978-b2a7-57190c27c62a"), 28, 90, "Arne", 91, 192, 83, 90, 90, "Swinton", new Guid("29090939-1d95-4ac2-ab29-de91a2db1368"), 109 },
                    { new Guid("6a2e96a5-9876-4e73-9bb3-7bfc0cf772a3"), 18, 73, "Arne", 90, 199, 62, 95, 92, "Swinton", new Guid("091eab68-b90d-4e2c-ad39-87b06b9e46eb"), 91 },
                    { new Guid("bd3d62fb-8e71-41f4-a555-a1ae2c8e89d7"), 37, 77, "Arne", 96, 180, 55, 94, 94, "Swinton", new Guid("d9b1b83d-4e3d-45a1-bc68-c7828b92aad4"), 79 },
                    { new Guid("9ae9e82d-79aa-4cfb-bf39-f18e09e2d6eb"), 19, 66, "Arne", 90, 176, 75, 96, 92, "Swinton", new Guid("8c7e4657-c9bc-4cab-b825-e749cd42c358"), 94 },
                    { new Guid("eee18c0c-1696-4cf6-bb78-b2680da9499d"), 34, 97, "Arne", 94, 185, 63, 91, 90, "Swinton", new Guid("6512a227-b8b0-4aab-95a4-62f44e264bc8"), 74 },
                    { new Guid("99793a6c-6e50-4a48-b10a-57125f64060f"), 41, 73, "Arne", 98, 189, 65, 98, 90, "Swinton", new Guid("ef6ab149-ca29-4ec1-9f22-8875a4aa6bdf"), 79 },
                    { new Guid("fe5effd4-02b6-436e-87f9-f51b4f340c23"), 33, 58, "Arne", 95, 173, 58, 90, 94, "Swinton", new Guid("13c721dd-c33f-4519-ba1f-712237a06323"), 99 },
                    { new Guid("45dd0326-135f-46c1-bb85-a29801da504e"), 32, 54, "Arne", 93, 198, 47, 90, 97, "Swinton", new Guid("1a1dc4db-08cb-4ade-a7f4-f8843013c857"), 105 },
                    { new Guid("58ce6649-c1fb-473f-9685-6f85ff87b84b"), 25, 78, "Arne", 98, 178, 93, 93, 95, "Swinton", new Guid("2b0100f3-18b7-42c5-87e1-6805923f352d"), 93 },
                    { new Guid("e8fdafee-a7cd-4f1f-8359-b39507f9af93"), 41, 73, "Arne", 92, 172, 85, 99, 94, "Swinton", new Guid("52bff2ff-b926-4f4a-8c0b-3ee37b245e2d"), 80 },
                    { new Guid("fad463d7-abc3-4e1b-b279-d84f52bf8426"), 18, 51, "Arne", 96, 175, 68, 90, 96, "Swinton", new Guid("f5779213-14b6-45df-8033-d99355b8315c"), 76 },
                    { new Guid("78955ce8-fb5c-4c85-99cc-1845b11a0a12"), 20, 73, "Arne", 94, 189, 48, 99, 98, "Swinton", new Guid("72ad2911-1718-4196-8bbe-cc75c59318c0"), 105 },
                    { new Guid("3bddf1ee-6be8-4634-aabd-e7a1151c1b50"), 32, 52, "Arne", 92, 180, 96, 97, 97, "Swinton", new Guid("9de989da-e454-46af-9faa-2f281cafa48b"), 76 },
                    { new Guid("8c869811-81fa-47fa-8536-164a9dcd3b69"), 32, 47, "Arne", 94, 179, 87, 90, 98, "Swinton", new Guid("793f4d54-481e-42ae-80aa-1e714fd72a45"), 93 },
                    { new Guid("fcfaeb2c-2ea4-4572-a54e-06673bd2b75b"), 25, 71, "Arne", 95, 186, 50, 98, 97, "Swinton", new Guid("e748c6a4-74a1-442a-8d04-3d5309f04129"), 96 },
                    { new Guid("c50db5c5-7689-41c7-9887-c5ed7b2580a5"), 28, 69, "Arne", 94, 175, 96, 99, 92, "Swinton", new Guid("159136ef-515e-472c-bbb7-ca74d5129ae7"), 107 },
                    { new Guid("ae0c3e2b-6268-47bc-9698-1c93d3546829"), 40, 41, "Arne", 93, 177, 40, 91, 90, "Swinton", new Guid("a4772a68-55f2-4d03-bf18-1bfe313d2935"), 90 },
                    { new Guid("6e31581c-777d-4c1a-a5df-efa51b782e6e"), 36, 68, "Arne", 90, 170, 78, 98, 91, "Swinton", new Guid("04e9d666-dfcb-4692-8d87-f4840b8549d5"), 76 },
                    { new Guid("0682baec-826b-4197-a64c-42c4a6b53e40"), 27, 87, "Arne", 93, 171, 83, 91, 93, "Swinton", new Guid("7f61b85f-6c4f-453c-ba64-9d00df45ba8a"), 101 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PlayerAggregatedStats",
                table: "PlayerAggregatedStats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GoalStatsDetails",
                table: "GoalStatsDetails");

            migrationBuilder.DeleteData(
                table: "GoalStatsDetails",
                keyColumn: "PlayerId",
                keyValue: new Guid("0682baec-826b-4197-a64c-42c4a6b53e40"));

            migrationBuilder.DeleteData(
                table: "GoalStatsDetails",
                keyColumn: "PlayerId",
                keyValue: new Guid("3bddf1ee-6be8-4634-aabd-e7a1151c1b50"));

            migrationBuilder.DeleteData(
                table: "GoalStatsDetails",
                keyColumn: "PlayerId",
                keyValue: new Guid("45dd0326-135f-46c1-bb85-a29801da504e"));

            migrationBuilder.DeleteData(
                table: "GoalStatsDetails",
                keyColumn: "PlayerId",
                keyValue: new Guid("540eb7bc-95f6-4978-b2a7-57190c27c62a"));

            migrationBuilder.DeleteData(
                table: "GoalStatsDetails",
                keyColumn: "PlayerId",
                keyValue: new Guid("58ce6649-c1fb-473f-9685-6f85ff87b84b"));

            migrationBuilder.DeleteData(
                table: "GoalStatsDetails",
                keyColumn: "PlayerId",
                keyValue: new Guid("6a2e96a5-9876-4e73-9bb3-7bfc0cf772a3"));

            migrationBuilder.DeleteData(
                table: "GoalStatsDetails",
                keyColumn: "PlayerId",
                keyValue: new Guid("6e31581c-777d-4c1a-a5df-efa51b782e6e"));

            migrationBuilder.DeleteData(
                table: "GoalStatsDetails",
                keyColumn: "PlayerId",
                keyValue: new Guid("742f4d2b-9cfb-4076-a31a-69e214ee3e9b"));

            migrationBuilder.DeleteData(
                table: "GoalStatsDetails",
                keyColumn: "PlayerId",
                keyValue: new Guid("78955ce8-fb5c-4c85-99cc-1845b11a0a12"));

            migrationBuilder.DeleteData(
                table: "GoalStatsDetails",
                keyColumn: "PlayerId",
                keyValue: new Guid("8c869811-81fa-47fa-8536-164a9dcd3b69"));

            migrationBuilder.DeleteData(
                table: "GoalStatsDetails",
                keyColumn: "PlayerId",
                keyValue: new Guid("99793a6c-6e50-4a48-b10a-57125f64060f"));

            migrationBuilder.DeleteData(
                table: "GoalStatsDetails",
                keyColumn: "PlayerId",
                keyValue: new Guid("9ae9e82d-79aa-4cfb-bf39-f18e09e2d6eb"));

            migrationBuilder.DeleteData(
                table: "GoalStatsDetails",
                keyColumn: "PlayerId",
                keyValue: new Guid("ae0c3e2b-6268-47bc-9698-1c93d3546829"));

            migrationBuilder.DeleteData(
                table: "GoalStatsDetails",
                keyColumn: "PlayerId",
                keyValue: new Guid("bd3d62fb-8e71-41f4-a555-a1ae2c8e89d7"));

            migrationBuilder.DeleteData(
                table: "GoalStatsDetails",
                keyColumn: "PlayerId",
                keyValue: new Guid("c50db5c5-7689-41c7-9887-c5ed7b2580a5"));

            migrationBuilder.DeleteData(
                table: "GoalStatsDetails",
                keyColumn: "PlayerId",
                keyValue: new Guid("e8fdafee-a7cd-4f1f-8359-b39507f9af93"));

            migrationBuilder.DeleteData(
                table: "GoalStatsDetails",
                keyColumn: "PlayerId",
                keyValue: new Guid("eee18c0c-1696-4cf6-bb78-b2680da9499d"));

            migrationBuilder.DeleteData(
                table: "GoalStatsDetails",
                keyColumn: "PlayerId",
                keyValue: new Guid("fad463d7-abc3-4e1b-b279-d84f52bf8426"));

            migrationBuilder.DeleteData(
                table: "GoalStatsDetails",
                keyColumn: "PlayerId",
                keyValue: new Guid("fcfaeb2c-2ea4-4572-a54e-06673bd2b75b"));

            migrationBuilder.DeleteData(
                table: "GoalStatsDetails",
                keyColumn: "PlayerId",
                keyValue: new Guid("fe5effd4-02b6-436e-87f9-f51b4f340c23"));

            migrationBuilder.DeleteData(
                table: "PlayerAggregatedStats",
                keyColumn: "Id",
                keyValue: new Guid("027ee014-f0a2-40c3-994e-c70ca61a2d2e"));

            migrationBuilder.DeleteData(
                table: "PlayerAggregatedStats",
                keyColumn: "Id",
                keyValue: new Guid("0846bdab-281d-4621-8e9b-8182700f2c4c"));

            migrationBuilder.DeleteData(
                table: "PlayerAggregatedStats",
                keyColumn: "Id",
                keyValue: new Guid("1c340774-dbce-4f06-b441-d6287c7b4aa2"));

            migrationBuilder.DeleteData(
                table: "PlayerAggregatedStats",
                keyColumn: "Id",
                keyValue: new Guid("336c91c1-1cf4-44b7-8adc-229eb19f45b3"));

            migrationBuilder.DeleteData(
                table: "PlayerAggregatedStats",
                keyColumn: "Id",
                keyValue: new Guid("4430729a-49e2-4933-b026-1acb7f0a92ff"));

            migrationBuilder.DeleteData(
                table: "PlayerAggregatedStats",
                keyColumn: "Id",
                keyValue: new Guid("51b34ed2-64f3-4f91-8fc6-b5b8bbb31f01"));

            migrationBuilder.DeleteData(
                table: "PlayerAggregatedStats",
                keyColumn: "Id",
                keyValue: new Guid("55c42fd4-f1bc-4951-aaad-438b4d598502"));

            migrationBuilder.DeleteData(
                table: "PlayerAggregatedStats",
                keyColumn: "Id",
                keyValue: new Guid("5678a97c-cd99-441f-be38-5a55a3acc810"));

            migrationBuilder.DeleteData(
                table: "PlayerAggregatedStats",
                keyColumn: "Id",
                keyValue: new Guid("77617889-fb46-4295-a659-f0418df74e63"));

            migrationBuilder.DeleteData(
                table: "PlayerAggregatedStats",
                keyColumn: "Id",
                keyValue: new Guid("7872f236-2b74-41c9-8702-f53417144bce"));

            migrationBuilder.DeleteData(
                table: "PlayerAggregatedStats",
                keyColumn: "Id",
                keyValue: new Guid("7b8988cf-ff94-4715-9057-6f3afcb562df"));

            migrationBuilder.DeleteData(
                table: "PlayerAggregatedStats",
                keyColumn: "Id",
                keyValue: new Guid("ad24f748-d872-47e9-8550-8d522990429b"));

            migrationBuilder.DeleteData(
                table: "PlayerAggregatedStats",
                keyColumn: "Id",
                keyValue: new Guid("bb80d622-da97-430a-8a4d-6a61bf3dc1ce"));

            migrationBuilder.DeleteData(
                table: "PlayerAggregatedStats",
                keyColumn: "Id",
                keyValue: new Guid("bbed6536-36d6-4c71-8ac3-642a021b7cc7"));

            migrationBuilder.DeleteData(
                table: "PlayerAggregatedStats",
                keyColumn: "Id",
                keyValue: new Guid("d1e3be08-f470-4ebf-b029-25225e25c150"));

            migrationBuilder.DeleteData(
                table: "PlayerAggregatedStats",
                keyColumn: "Id",
                keyValue: new Guid("dbd69dfd-0ae6-47ee-987b-d1963024ff96"));

            migrationBuilder.DeleteData(
                table: "PlayerAggregatedStats",
                keyColumn: "Id",
                keyValue: new Guid("dfe7f98c-68c1-4c7b-93b9-1d833ad45538"));

            migrationBuilder.DeleteData(
                table: "PlayerAggregatedStats",
                keyColumn: "Id",
                keyValue: new Guid("e112d89a-47a8-4102-87ca-fde3726133e8"));

            migrationBuilder.DeleteData(
                table: "PlayerAggregatedStats",
                keyColumn: "Id",
                keyValue: new Guid("ea0fdcb0-8d0f-47a4-b770-f98e7738e7d9"));

            migrationBuilder.DeleteData(
                table: "PlayerAggregatedStats",
                keyColumn: "Id",
                keyValue: new Guid("ff572d68-5174-4bf3-b037-d5797cd99e87"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("0682baec-826b-4197-a64c-42c4a6b53e40"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("3bddf1ee-6be8-4634-aabd-e7a1151c1b50"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("45dd0326-135f-46c1-bb85-a29801da504e"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("540eb7bc-95f6-4978-b2a7-57190c27c62a"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("58ce6649-c1fb-473f-9685-6f85ff87b84b"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("6a2e96a5-9876-4e73-9bb3-7bfc0cf772a3"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("6e31581c-777d-4c1a-a5df-efa51b782e6e"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("742f4d2b-9cfb-4076-a31a-69e214ee3e9b"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("78955ce8-fb5c-4c85-99cc-1845b11a0a12"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("8c869811-81fa-47fa-8536-164a9dcd3b69"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("99793a6c-6e50-4a48-b10a-57125f64060f"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("9ae9e82d-79aa-4cfb-bf39-f18e09e2d6eb"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("ae0c3e2b-6268-47bc-9698-1c93d3546829"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("bd3d62fb-8e71-41f4-a555-a1ae2c8e89d7"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("c50db5c5-7689-41c7-9887-c5ed7b2580a5"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("e8fdafee-a7cd-4f1f-8359-b39507f9af93"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("eee18c0c-1696-4cf6-bb78-b2680da9499d"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("fad463d7-abc3-4e1b-b279-d84f52bf8426"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("fcfaeb2c-2ea4-4572-a54e-06673bd2b75b"));

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: new Guid("fe5effd4-02b6-436e-87f9-f51b4f340c23"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PlayerAggregatedStats");

            migrationBuilder.DropColumn(
                name: "LeagueId",
                table: "PlayerAggregatedStats");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "PlayerAggregatedStats");

            migrationBuilder.AddColumn<Guid>(
                name: "PlayertId",
                table: "PlayerAggregatedStats",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "PlayerId",
                table: "GoalStatsDetails",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "GoalStatsDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_PlayerAggregatedStats",
                table: "PlayerAggregatedStats",
                column: "PlayerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GoalStatsDetails",
                table: "GoalStatsDetails",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerAggregatedStats_PlayertId",
                table: "PlayerAggregatedStats",
                column: "PlayertId",
                unique: true,
                filter: "[PlayertId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GoalStatsDetails_PlayerId",
                table: "GoalStatsDetails",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_GoalStatsDetails_Players_PlayerId",
                table: "GoalStatsDetails",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerAggregatedStats_Players_PlayertId",
                table: "PlayerAggregatedStats",
                column: "PlayertId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
