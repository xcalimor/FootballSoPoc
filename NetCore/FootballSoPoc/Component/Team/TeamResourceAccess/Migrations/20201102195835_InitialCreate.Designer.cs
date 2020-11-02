﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TeamResourceAccess;

namespace TeamResourceAccess.Migrations
{
    [DbContext(typeof(ResourceContext))]
    [Migration("20201102195835_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TeamResourceAccess.Entity.City", b =>
                {
                    b.Property<Guid>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.HasKey("CityId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"),
                            Name = "London",
                            Population = 8982000
                        },
                        new
                        {
                            CityId = new Guid("ad1708fe-9ccb-4f2b-a541-00360e568a85"),
                            Name = "Birmingham",
                            Population = 1086000
                        },
                        new
                        {
                            CityId = new Guid("97383535-9dd0-44b5-8387-11b4a12aee41"),
                            Name = "Brighton & Hove",
                            Population = 229700
                        },
                        new
                        {
                            CityId = new Guid("80170b4d-11a1-41c0-be79-3dedd6aef779"),
                            Name = "Burnley",
                            Population = 87300
                        },
                        new
                        {
                            CityId = new Guid("1cdfbf78-be27-4af0-a6e2-475bbfa72523"),
                            Name = "Liverpool",
                            Population = 552267
                        },
                        new
                        {
                            CityId = new Guid("735cd09a-54c1-4099-a42c-74ba561104cd"),
                            Name = "Manchester",
                            Population = 5107467
                        },
                        new
                        {
                            CityId = new Guid("95159a2f-220c-4f10-a609-91877f025225"),
                            Name = "Leeds",
                            Population = 474632
                        },
                        new
                        {
                            CityId = new Guid("da404828-476e-4b75-a2bf-d3e3637fb192"),
                            Name = "Leicester",
                            Population = 329839
                        },
                        new
                        {
                            CityId = new Guid("47d4ec37-672b-420b-bd89-d516b3198ee6"),
                            Name = "Newcastle",
                            Population = 268064
                        },
                        new
                        {
                            CityId = new Guid("1a1f7b0c-aeb8-4c69-abe6-ef2fc3d34514"),
                            Name = "Sheffield",
                            Population = 518090
                        },
                        new
                        {
                            CityId = new Guid("4c3dc9ac-9e0d-448b-a8ae-d5148678e85f"),
                            Name = "Southampton",
                            Population = 253651
                        },
                        new
                        {
                            CityId = new Guid("569510a4-0838-4b45-b16b-ebf75e2488e7"),
                            Name = "West Bromwich",
                            Population = 77997
                        },
                        new
                        {
                            CityId = new Guid("5dda2ea6-e7c5-4c8f-a33f-ad6a2888419b"),
                            Name = "Wolverhampton",
                            Population = 77997
                        },
                        new
                        {
                            CityId = new Guid("f7059739-061f-4607-aed0-835dbf1afa43"),
                            Name = "Reading",
                            Population = 77997
                        },
                        new
                        {
                            CityId = new Guid("4935afd2-4e06-469b-a473-bbb45fbdc96b"),
                            Name = "Bristol",
                            Population = 535907
                        },
                        new
                        {
                            CityId = new Guid("ce223e9c-3bdb-4708-8967-eb0db5141af7"),
                            Name = "Watford",
                            Population = 120960
                        },
                        new
                        {
                            CityId = new Guid("cf0832cf-4597-4ed3-862b-3a1a199bfa62"),
                            Name = "Bournemouth",
                            Population = 187503
                        },
                        new
                        {
                            CityId = new Guid("cf492a97-7694-4d1b-b823-8bbdd207dbee"),
                            Name = "Norwich",
                            Population = 174047
                        },
                        new
                        {
                            CityId = new Guid("9d6176f3-c202-4c9c-8c1a-db656f25e037"),
                            Name = "Swansea",
                            Population = 179485
                        },
                        new
                        {
                            CityId = new Guid("4f0836d2-f05b-4cfc-95f8-d88b3bb6b703"),
                            Name = "Luton",
                            Population = 258018
                        },
                        new
                        {
                            CityId = new Guid("05bf0f04-df87-4edc-a228-ff7cd95e8c07"),
                            Name = "Stoke-on-Trent",
                            Population = 275000
                        },
                        new
                        {
                            CityId = new Guid("f322e797-9f48-4025-90c3-ebe077933ca0"),
                            Name = "Blackburn",
                            Population = 117963
                        },
                        new
                        {
                            CityId = new Guid("dd8e0177-2b75-404e-97bd-67bebade0ff2"),
                            Name = "Preston",
                            Population = 148836
                        },
                        new
                        {
                            CityId = new Guid("e0b4c7fb-42c4-464a-a228-f38e38dcbb76"),
                            Name = "Middlesbrough",
                            Population = 140398
                        },
                        new
                        {
                            CityId = new Guid("0586927b-140b-4b7f-a8c4-f9bb57eb44ca"),
                            Name = "Huddersfield",
                            Population = 162949
                        },
                        new
                        {
                            CityId = new Guid("9d320c88-6187-4f82-ab58-71c25e4a1567"),
                            Name = "Cardiff",
                            Population = 327706
                        });
                });

            modelBuilder.Entity("TeamResourceAccess.Entity.Team", b =>
                {
                    b.Property<Guid>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ArenaCapacity")
                        .HasColumnType("int");

                    b.Property<string>("ArenaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("CityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamId");

                    b.HasIndex("CityId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            TeamId = new Guid("29090939-1d95-4ac2-ab29-de91a2db1368"),
                            ArenaCapacity = 60704,
                            ArenaName = "Emirates Stadium",
                            CityId = new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"),
                            Name = "Arsenal"
                        },
                        new
                        {
                            TeamId = new Guid("091eab68-b90d-4e2c-ad39-87b06b9e46eb"),
                            ArenaCapacity = 42749,
                            ArenaName = "Villa Park",
                            CityId = new Guid("ad1708fe-9ccb-4f2b-a541-00360e568a85"),
                            Name = "Aston Villa"
                        },
                        new
                        {
                            TeamId = new Guid("d9b1b83d-4e3d-45a1-bc68-c7828b92aad4"),
                            ArenaCapacity = 30750,
                            ArenaName = "American Express Community Stadium",
                            CityId = new Guid("97383535-9dd0-44b5-8387-11b4a12aee41"),
                            Name = "Brighton & Hove Albion"
                        },
                        new
                        {
                            TeamId = new Guid("8c7e4657-c9bc-4cab-b825-e749cd42c358"),
                            ArenaCapacity = 21944,
                            ArenaName = "Turf Moor",
                            CityId = new Guid("80170b4d-11a1-41c0-be79-3dedd6aef779"),
                            Name = "Burnley"
                        },
                        new
                        {
                            TeamId = new Guid("6512a227-b8b0-4aab-95a4-62f44e264bc8"),
                            ArenaCapacity = 41631,
                            ArenaName = "Stamford Bridge",
                            CityId = new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"),
                            Name = "Chelsea"
                        },
                        new
                        {
                            TeamId = new Guid("ef6ab149-ca29-4ec1-9f22-8875a4aa6bdf"),
                            ArenaCapacity = 26125,
                            ArenaName = "Selhurst Park",
                            CityId = new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"),
                            Name = "Crystal Palace"
                        },
                        new
                        {
                            TeamId = new Guid("13c721dd-c33f-4519-ba1f-712237a06323"),
                            ArenaCapacity = 39572,
                            ArenaName = "Goodison Park",
                            CityId = new Guid("1cdfbf78-be27-4af0-a6e2-475bbfa72523"),
                            Name = "Everton"
                        },
                        new
                        {
                            TeamId = new Guid("1a1dc4db-08cb-4ade-a7f4-f8843013c857"),
                            ArenaCapacity = 25700,
                            ArenaName = "Craven Cottage",
                            CityId = new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"),
                            Name = "Fulham"
                        },
                        new
                        {
                            TeamId = new Guid("2b0100f3-18b7-42c5-87e1-6805923f352d"),
                            ArenaCapacity = 37890,
                            ArenaName = "Elland Road",
                            CityId = new Guid("95159a2f-220c-4f10-a609-91877f025225"),
                            Name = "Leeds United"
                        },
                        new
                        {
                            TeamId = new Guid("7f61b85f-6c4f-453c-ba64-9d00df45ba8a"),
                            ArenaCapacity = 32312,
                            ArenaName = "King Power Stadium",
                            CityId = new Guid("da404828-476e-4b75-a2bf-d3e3637fb192"),
                            Name = "Leicester City"
                        },
                        new
                        {
                            TeamId = new Guid("52bff2ff-b926-4f4a-8c0b-3ee37b245e2d"),
                            ArenaCapacity = 54074,
                            ArenaName = "Anfield",
                            CityId = new Guid("1cdfbf78-be27-4af0-a6e2-475bbfa72523"),
                            Name = "Liverpool"
                        },
                        new
                        {
                            TeamId = new Guid("f5779213-14b6-45df-8033-d99355b8315c"),
                            ArenaCapacity = 55097,
                            ArenaName = "Etihad Stadium",
                            CityId = new Guid("735cd09a-54c1-4099-a42c-74ba561104cd"),
                            Name = "Manchester City"
                        },
                        new
                        {
                            TeamId = new Guid("72ad2911-1718-4196-8bbe-cc75c59318c0"),
                            ArenaCapacity = 74994,
                            ArenaName = "Old Trafford",
                            CityId = new Guid("735cd09a-54c1-4099-a42c-74ba561104cd"),
                            Name = "Manchester United"
                        },
                        new
                        {
                            TeamId = new Guid("9de989da-e454-46af-9faa-2f281cafa48b"),
                            ArenaCapacity = 52354,
                            ArenaName = "St James' Park",
                            CityId = new Guid("47d4ec37-672b-420b-bd89-d516b3198ee6"),
                            Name = "Newcastle United"
                        },
                        new
                        {
                            TeamId = new Guid("793f4d54-481e-42ae-80aa-1e714fd72a45"),
                            ArenaCapacity = 32609,
                            ArenaName = "Bramall Lane",
                            CityId = new Guid("1a1f7b0c-aeb8-4c69-abe6-ef2fc3d34514"),
                            Name = "Sheffield United"
                        },
                        new
                        {
                            TeamId = new Guid("e748c6a4-74a1-442a-8d04-3d5309f04129"),
                            ArenaCapacity = 32505,
                            ArenaName = "St Mary's Stadium",
                            CityId = new Guid("4c3dc9ac-9e0d-448b-a8ae-d5148678e85f"),
                            Name = "Southampton"
                        },
                        new
                        {
                            TeamId = new Guid("159136ef-515e-472c-bbb7-ca74d5129ae7"),
                            ArenaCapacity = 62062,
                            ArenaName = "Tottenham Hotspur Stadium",
                            CityId = new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"),
                            Name = "Tottenham Hotspur"
                        },
                        new
                        {
                            TeamId = new Guid("a4772a68-55f2-4d03-bf18-1bfe313d2935"),
                            ArenaCapacity = 26688,
                            ArenaName = "The Hawthorns",
                            CityId = new Guid("569510a4-0838-4b45-b16b-ebf75e2488e7"),
                            Name = "West Bromwich Albion"
                        },
                        new
                        {
                            TeamId = new Guid("04e9d666-dfcb-4692-8d87-f4840b8549d5"),
                            ArenaCapacity = 60000,
                            ArenaName = "Londons Olympiastadion",
                            CityId = new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"),
                            Name = "West Ham United"
                        },
                        new
                        {
                            TeamId = new Guid("0d5e25bf-f764-4644-bbf3-cf7ab2cff0ad"),
                            ArenaCapacity = 32050,
                            ArenaName = "Molineux Stadium",
                            CityId = new Guid("5dda2ea6-e7c5-4c8f-a33f-ad6a2888419b"),
                            Name = "Wolverhampton Wanderers"
                        },
                        new
                        {
                            TeamId = new Guid("a3f8eef4-8a92-407a-9402-d7dae78a7499"),
                            ArenaCapacity = 24161,
                            ArenaName = "Madejski Stadium",
                            CityId = new Guid("f7059739-061f-4607-aed0-835dbf1afa43"),
                            Name = "Reading"
                        },
                        new
                        {
                            TeamId = new Guid("bf852fa5-60f6-4104-94dd-71746b309d1b"),
                            ArenaCapacity = 27000,
                            ArenaName = "Ashton Gate Stadium",
                            CityId = new Guid("4935afd2-4e06-469b-a473-bbb45fbdc96b"),
                            Name = "Bristol City"
                        },
                        new
                        {
                            TeamId = new Guid("d45e9dfb-7032-40e9-b871-18901f791536"),
                            ArenaCapacity = 21577,
                            ArenaName = "Vicarage Road",
                            CityId = new Guid("ce223e9c-3bdb-4708-8967-eb0db5141af7"),
                            Name = "Watford"
                        },
                        new
                        {
                            TeamId = new Guid("7fd4962c-a1e0-4c18-b7c5-1e2c9748debf"),
                            ArenaCapacity = 11364,
                            ArenaName = "Vitality Stadium",
                            CityId = new Guid("cf0832cf-4597-4ed3-862b-3a1a199bfa62"),
                            Name = "Bournemouth"
                        },
                        new
                        {
                            TeamId = new Guid("3fd0e4d7-5574-4de4-957f-41da87b26f5d"),
                            ArenaCapacity = 27244,
                            ArenaName = "Carrow Road",
                            CityId = new Guid("cf492a97-7694-4d1b-b823-8bbdd207dbee"),
                            Name = "Norwich City"
                        },
                        new
                        {
                            TeamId = new Guid("ce43f7ea-f0d8-4354-b2ac-c411b216a87b"),
                            ArenaCapacity = 21088,
                            ArenaName = "Liberty Stadium",
                            CityId = new Guid("9d6176f3-c202-4c9c-8c1a-db656f25e037"),
                            Name = "Swansea City"
                        },
                        new
                        {
                            TeamId = new Guid("7e560e4b-cdc0-4d3d-998b-df9053813467"),
                            ArenaCapacity = 20146,
                            ArenaName = "The Den",
                            CityId = new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"),
                            Name = "Millwall"
                        },
                        new
                        {
                            TeamId = new Guid("76ab740d-8bd5-428a-a2a5-3d63779805f2"),
                            ArenaCapacity = 30089,
                            ArenaName = "Bet365 Stadium",
                            CityId = new Guid("05bf0f04-df87-4edc-a228-ff7cd95e8c07"),
                            Name = "Stoke City"
                        },
                        new
                        {
                            TeamId = new Guid("7be361b9-46bb-4797-98b5-12d985492302"),
                            ArenaCapacity = 10356,
                            ArenaName = "Kenilworth Road",
                            CityId = new Guid("4f0836d2-f05b-4cfc-95f8-d88b3bb6b703"),
                            Name = "Luton Town"
                        },
                        new
                        {
                            TeamId = new Guid("ba6d5954-364c-45cf-a55d-8a207c369761"),
                            ArenaCapacity = 31367,
                            ArenaName = "Ewood Park",
                            CityId = new Guid("f322e797-9f48-4025-90c3-ebe077933ca0"),
                            Name = "Blackburn Rovers"
                        },
                        new
                        {
                            TeamId = new Guid("a596da7e-8406-42ab-ab87-9f103ee47272"),
                            ArenaCapacity = 17250,
                            ArenaName = "Brentford Community Stadium",
                            CityId = new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"),
                            Name = "Brentford"
                        },
                        new
                        {
                            TeamId = new Guid("3b52b592-a4bc-4b1c-8f7c-4fe467810dac"),
                            ArenaCapacity = 23404,
                            ArenaName = "Deepdale",
                            CityId = new Guid("dd8e0177-2b75-404e-97bd-67bebade0ff2"),
                            Name = "Preston North End"
                        },
                        new
                        {
                            TeamId = new Guid("676aa12b-2d46-4e4d-8dc9-67fecccd2ba5"),
                            ArenaCapacity = 34742,
                            ArenaName = "Riverside Stadium",
                            CityId = new Guid("e0b4c7fb-42c4-464a-a228-f38e38dcbb76"),
                            Name = "Middlesbrough"
                        },
                        new
                        {
                            TeamId = new Guid("ae927c9d-fcd1-4bfc-8259-f8014e74b2e5"),
                            ArenaCapacity = 24500,
                            ArenaName = "John Smith's Stadium",
                            CityId = new Guid("0586927b-140b-4b7f-a8c4-f9bb57eb44ca"),
                            Name = "Huddersfield Town"
                        },
                        new
                        {
                            TeamId = new Guid("ef0e5227-f51f-4f7f-9d24-9a6a208c3a15"),
                            ArenaCapacity = 33280,
                            ArenaName = "Cardiff City Stadium",
                            CityId = new Guid("9d320c88-6187-4f82-ab58-71c25e4a1567"),
                            Name = "Cardiff City"
                        },
                        new
                        {
                            TeamId = new Guid("ed671605-1872-4089-8f2e-4cd9a9f68b72"),
                            ArenaCapacity = 18439,
                            ArenaName = "Loftus Road",
                            CityId = new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"),
                            Name = "Queens Park Rangers"
                        },
                        new
                        {
                            TeamId = new Guid("78d33450-f3dc-4bfd-a01f-1a0e91b75f1a"),
                            ArenaCapacity = 18439,
                            ArenaName = "Loftus Road",
                            CityId = new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"),
                            Name = "Birmingham City"
                        },
                        new
                        {
                            TeamId = new Guid("38c2bce5-de53-42e4-b61f-b64113c9d463"),
                            ArenaCapacity = 18439,
                            ArenaName = "Loftus Road",
                            CityId = new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"),
                            Name = "Rotherham United"
                        },
                        new
                        {
                            TeamId = new Guid("446090dc-4edf-49ef-be12-0f337caa5c39"),
                            ArenaCapacity = 18439,
                            ArenaName = "Loftus Road",
                            CityId = new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"),
                            Name = "Nottingham Forest"
                        },
                        new
                        {
                            TeamId = new Guid("ccc7f427-9b43-4149-9d30-d381a86a146d"),
                            ArenaCapacity = 18439,
                            ArenaName = "Loftus Road",
                            CityId = new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"),
                            Name = "Coventry City"
                        },
                        new
                        {
                            TeamId = new Guid("787aba1d-e768-4c7e-9128-e04fc7f25564"),
                            ArenaCapacity = 18439,
                            ArenaName = "Loftus Road",
                            CityId = new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"),
                            Name = "Barnsley"
                        },
                        new
                        {
                            TeamId = new Guid("3ba8507e-90de-4c09-97ad-eec460368c6c"),
                            ArenaCapacity = 18439,
                            ArenaName = "Loftus Road",
                            CityId = new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"),
                            Name = "Derby County"
                        },
                        new
                        {
                            TeamId = new Guid("0c1c9d69-7d41-4a85-840b-13cff90fc467"),
                            ArenaCapacity = 18439,
                            ArenaName = "Loftus Road",
                            CityId = new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"),
                            Name = "Wycombe Wanderers"
                        },
                        new
                        {
                            TeamId = new Guid("f9e13d86-cddd-4400-90d5-43571530b7db"),
                            ArenaCapacity = 18439,
                            ArenaName = "Loftus Road",
                            CityId = new Guid("5ba310dc-7218-4a59-8f63-e0e7443d1667"),
                            Name = "Sheffield Wednesday"
                        });
                });

            modelBuilder.Entity("TeamResourceAccess.Entity.Team", b =>
                {
                    b.HasOne("TeamResourceAccess.Entity.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}