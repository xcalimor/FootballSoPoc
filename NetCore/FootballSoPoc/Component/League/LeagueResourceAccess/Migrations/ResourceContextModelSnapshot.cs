﻿// <auto-generated />
using System;
using LeagueResourceAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeagueResourceAccess.Migrations
{
    [DbContext(typeof(ResourceContext))]
    partial class ResourceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LeagueResourceAccess.Entity.GameDay", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AwayLeagueTeamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("HomeLeagueTeamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LeagueId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("SheduledAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.ToTable("GameDays");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8ebdcc5f-5e09-4b06-85c0-f778c68047c9"),
                            AwayLeagueTeamId = new Guid("03c71860-c086-4eb4-93bc-6f8ac445c703"),
                            HomeLeagueTeamId = new Guid("6cdd9d2b-bd5d-4f2f-82ba-d31cef1a2870"),
                            LeagueId = new Guid("2198ad60-163c-4fa8-9857-71964073bb29"),
                            SheduledAt = new DateTime(2020, 10, 13, 11, 45, 1, 299, DateTimeKind.Local).AddTicks(2154)
                        },
                        new
                        {
                            Id = new Guid("2d449e0c-8b0f-4b1e-8581-bc362db0aa31"),
                            AwayLeagueTeamId = new Guid("fa3a6d42-9b9d-45d5-a860-63069e64c6e2"),
                            HomeLeagueTeamId = new Guid("bc18a38c-9fec-4bcc-b0ee-1f42b968ac3d"),
                            LeagueId = new Guid("2198ad60-163c-4fa8-9857-71964073bb29"),
                            SheduledAt = new DateTime(2020, 10, 13, 11, 45, 1, 302, DateTimeKind.Local).AddTicks(5734)
                        },
                        new
                        {
                            Id = new Guid("b868f1e4-af7b-4c36-ad23-b511d30955d4"),
                            AwayLeagueTeamId = new Guid("bc18a38c-9fec-4bcc-b0ee-1f42b968ac3d"),
                            HomeLeagueTeamId = new Guid("03c71860-c086-4eb4-93bc-6f8ac445c703"),
                            LeagueId = new Guid("2198ad60-163c-4fa8-9857-71964073bb29"),
                            SheduledAt = new DateTime(2020, 10, 13, 11, 50, 1, 302, DateTimeKind.Local).AddTicks(5815)
                        },
                        new
                        {
                            Id = new Guid("e8e81a43-f00a-4eec-8250-f8e5668bab51"),
                            AwayLeagueTeamId = new Guid("6cdd9d2b-bd5d-4f2f-82ba-d31cef1a2870"),
                            HomeLeagueTeamId = new Guid("fa3a6d42-9b9d-45d5-a860-63069e64c6e2"),
                            LeagueId = new Guid("2198ad60-163c-4fa8-9857-71964073bb29"),
                            SheduledAt = new DateTime(2020, 10, 13, 11, 50, 1, 302, DateTimeKind.Local).AddTicks(5824)
                        },
                        new
                        {
                            Id = new Guid("10c4bb54-f2d7-4d61-aa99-2355923fddb3"),
                            AwayLeagueTeamId = new Guid("6cdd9d2b-bd5d-4f2f-82ba-d31cef1a2870"),
                            HomeLeagueTeamId = new Guid("bc18a38c-9fec-4bcc-b0ee-1f42b968ac3d"),
                            LeagueId = new Guid("2198ad60-163c-4fa8-9857-71964073bb29"),
                            SheduledAt = new DateTime(2020, 10, 13, 11, 55, 1, 302, DateTimeKind.Local).AddTicks(5829)
                        },
                        new
                        {
                            Id = new Guid("92b42204-ed04-4072-b46a-7ddfbd43e028"),
                            AwayLeagueTeamId = new Guid("fa3a6d42-9b9d-45d5-a860-63069e64c6e2"),
                            HomeLeagueTeamId = new Guid("03c71860-c086-4eb4-93bc-6f8ac445c703"),
                            LeagueId = new Guid("2198ad60-163c-4fa8-9857-71964073bb29"),
                            SheduledAt = new DateTime(2020, 10, 13, 11, 55, 1, 302, DateTimeKind.Local).AddTicks(5834)
                        });
                });

            modelBuilder.Entity("LeagueResourceAccess.Entity.League", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Leagues");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2198ad60-163c-4fa8-9857-71964073bb29"),
                            Name = "Premieer League"
                        });
                });

            modelBuilder.Entity("LeagueResourceAccess.Entity.LeaguePlayer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("LeaguePlayers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("322ca22b-90bb-47d6-b927-4f7d8568d43e"),
                            PlayerId = new Guid("9522df07-4640-40a9-ab21-d17752dd44a1")
                        },
                        new
                        {
                            Id = new Guid("4797de9c-8e03-44f8-acc5-caedade68465"),
                            PlayerId = new Guid("a63aba53-cfa0-4498-94c7-9389c1576053")
                        },
                        new
                        {
                            Id = new Guid("d943b4fe-5a44-4819-8c4e-9f4fbb511ce7"),
                            PlayerId = new Guid("57edaccd-88e7-4da8-bcd5-b06caabd959e")
                        },
                        new
                        {
                            Id = new Guid("40120376-967e-4521-bc09-b3ea9b9bc676"),
                            PlayerId = new Guid("d83d2a7f-6061-4380-8325-ec03b19b5171")
                        });
                });

            modelBuilder.Entity("LeagueResourceAccess.Entity.LeagueTeam", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LeagueId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<Guid>("TeamId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.ToTable("LeagueTeams");

                    b.HasData(
                        new
                        {
                            Id = new Guid("6cdd9d2b-bd5d-4f2f-82ba-d31cef1a2870"),
                            LeagueId = new Guid("2198ad60-163c-4fa8-9857-71964073bb29"),
                            Rank = 1,
                            TeamId = new Guid("6e9e7d29-a594-4e81-9334-0725e0fc7520")
                        },
                        new
                        {
                            Id = new Guid("03c71860-c086-4eb4-93bc-6f8ac445c703"),
                            LeagueId = new Guid("2198ad60-163c-4fa8-9857-71964073bb29"),
                            Rank = 2,
                            TeamId = new Guid("661a7b09-3f20-48be-8af2-c6bbb6bcaf4e")
                        },
                        new
                        {
                            Id = new Guid("bc18a38c-9fec-4bcc-b0ee-1f42b968ac3d"),
                            LeagueId = new Guid("2198ad60-163c-4fa8-9857-71964073bb29"),
                            Rank = 3,
                            TeamId = new Guid("b936f38f-bafe-4a56-8756-ed1b9da3e864")
                        },
                        new
                        {
                            Id = new Guid("fa3a6d42-9b9d-45d5-a860-63069e64c6e2"),
                            LeagueId = new Guid("2198ad60-163c-4fa8-9857-71964073bb29"),
                            Rank = 4,
                            TeamId = new Guid("551b3e88-46ce-4bf1-bf85-14660168d907")
                        });
                });

            modelBuilder.Entity("LeagueResourceAccess.Entity.Scorer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AssistedByLeaguePlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GameDayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LeaguePlayerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ScoredInMinute")
                        .HasColumnType("int");

                    b.Property<Guid?>("ScorerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("GameDayId");

                    b.HasIndex("ScorerId");

                    b.ToTable("Scorers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ea19cc6b-a63c-4eb0-adad-d00d07652b99"),
                            AssistedByLeaguePlayerId = new Guid("40120376-967e-4521-bc09-b3ea9b9bc676"),
                            GameDayId = new Guid("8ebdcc5f-5e09-4b06-85c0-f778c68047c9"),
                            LeaguePlayerId = new Guid("d943b4fe-5a44-4819-8c4e-9f4fbb511ce7"),
                            ScoredInMinute = 22
                        },
                        new
                        {
                            Id = new Guid("eedb16b4-e575-439f-b1f7-e05f2f2b1376"),
                            AssistedByLeaguePlayerId = new Guid("40120376-967e-4521-bc09-b3ea9b9bc676"),
                            GameDayId = new Guid("8ebdcc5f-5e09-4b06-85c0-f778c68047c9"),
                            LeaguePlayerId = new Guid("d943b4fe-5a44-4819-8c4e-9f4fbb511ce7"),
                            ScoredInMinute = 47
                        },
                        new
                        {
                            Id = new Guid("cf5b0da5-9c4c-446a-8b70-a5690e14ccad"),
                            AssistedByLeaguePlayerId = new Guid("40120376-967e-4521-bc09-b3ea9b9bc676"),
                            GameDayId = new Guid("8ebdcc5f-5e09-4b06-85c0-f778c68047c9"),
                            LeaguePlayerId = new Guid("d943b4fe-5a44-4819-8c4e-9f4fbb511ce7"),
                            ScoredInMinute = 78
                        },
                        new
                        {
                            Id = new Guid("f9f70cf6-ea78-4332-a7e7-472432d043f6"),
                            AssistedByLeaguePlayerId = new Guid("4797de9c-8e03-44f8-acc5-caedade68465"),
                            GameDayId = new Guid("8ebdcc5f-5e09-4b06-85c0-f778c68047c9"),
                            LeaguePlayerId = new Guid("322ca22b-90bb-47d6-b927-4f7d8568d43e"),
                            ScoredInMinute = 37
                        });
                });

            modelBuilder.Entity("LeagueResourceAccess.Entity.Standing", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AwayGames")
                        .HasColumnType("int");

                    b.Property<int>("AwayWins")
                        .HasColumnType("int");

                    b.Property<int>("Draw")
                        .HasColumnType("int");

                    b.Property<int>("GoalsAgainst")
                        .HasColumnType("int");

                    b.Property<int>("GoalsMade")
                        .HasColumnType("int");

                    b.Property<int>("HomeGames")
                        .HasColumnType("int");

                    b.Property<int>("HomeWins")
                        .HasColumnType("int");

                    b.Property<Guid>("LeagueId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LeagueTeamId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MemberId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.ToTable("Standings");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9c30baf9-a28a-485e-bccd-9d43294ffb31"),
                            AwayGames = 0,
                            AwayWins = 0,
                            Draw = 0,
                            GoalsAgainst = 3,
                            GoalsMade = 1,
                            HomeGames = 1,
                            HomeWins = 0,
                            LeagueId = new Guid("2198ad60-163c-4fa8-9857-71964073bb29"),
                            LeagueTeamId = new Guid("6cdd9d2b-bd5d-4f2f-82ba-d31cef1a2870"),
                            MemberId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Points = 0
                        },
                        new
                        {
                            Id = new Guid("50a09551-0f72-4071-8b49-adcefc488070"),
                            AwayGames = 1,
                            AwayWins = 0,
                            Draw = 0,
                            GoalsAgainst = 1,
                            GoalsMade = 3,
                            HomeGames = 0,
                            HomeWins = 0,
                            LeagueId = new Guid("2198ad60-163c-4fa8-9857-71964073bb29"),
                            LeagueTeamId = new Guid("03c71860-c086-4eb4-93bc-6f8ac445c703"),
                            MemberId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Points = 3
                        },
                        new
                        {
                            Id = new Guid("4a295316-e39c-42e5-a1ae-3e240d5a667f"),
                            AwayGames = 0,
                            AwayWins = 0,
                            Draw = 1,
                            GoalsAgainst = 0,
                            GoalsMade = 0,
                            HomeGames = 1,
                            HomeWins = 0,
                            LeagueId = new Guid("2198ad60-163c-4fa8-9857-71964073bb29"),
                            LeagueTeamId = new Guid("bc18a38c-9fec-4bcc-b0ee-1f42b968ac3d"),
                            MemberId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Points = 1
                        },
                        new
                        {
                            Id = new Guid("8b4114ac-1091-40c2-a005-952ffe11793f"),
                            AwayGames = 0,
                            AwayWins = 0,
                            Draw = 1,
                            GoalsAgainst = 0,
                            GoalsMade = 0,
                            HomeGames = 1,
                            HomeWins = 0,
                            LeagueId = new Guid("2198ad60-163c-4fa8-9857-71964073bb29"),
                            LeagueTeamId = new Guid("fa3a6d42-9b9d-45d5-a860-63069e64c6e2"),
                            MemberId = new Guid("00000000-0000-0000-0000-000000000000"),
                            Points = 1
                        });
                });

            modelBuilder.Entity("LeagueResourceAccess.Entity.GameDay", b =>
                {
                    b.HasOne("LeagueResourceAccess.Entity.League", null)
                        .WithMany("GameDays")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LeagueResourceAccess.Entity.LeagueTeam", b =>
                {
                    b.HasOne("LeagueResourceAccess.Entity.League", null)
                        .WithMany("LeagueTeams")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LeagueResourceAccess.Entity.Scorer", b =>
                {
                    b.HasOne("LeagueResourceAccess.Entity.GameDay", null)
                        .WithMany("HomeScorers")
                        .HasForeignKey("GameDayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LeagueResourceAccess.Entity.GameDay", null)
                        .WithMany("AwayScorers")
                        .HasForeignKey("ScorerId");
                });

            modelBuilder.Entity("LeagueResourceAccess.Entity.Standing", b =>
                {
                    b.HasOne("LeagueResourceAccess.Entity.League", null)
                        .WithMany("Standings")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}