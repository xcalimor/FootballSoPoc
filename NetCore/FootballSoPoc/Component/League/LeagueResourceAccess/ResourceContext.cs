using LeagueResourceAccess.Entity;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LeagueResourceAccess
{
    public class ResourceContext : DbContext
    {
        public ResourceContext(DbContextOptions<ResourceContext> options) : base(options)
        {

        }

        DbSet<League> Leagues { get; set; }
        DbSet<LeagueTeam> LeagueTeams { get; set; }
        DbSet<GameDay> GameDays { get; set; }
        DbSet<Scorer> Scorers { get; set; }
        DbSet<Standing> Standings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var allTeamsId = SoPocDataProducer.TeamProducer.GetAllTeams();
            var firstLayerTeams = allTeamsId.Where(t => t.DivisionRank == 1).OrderByDescending(t=> t.DivisionRank).ToList();
            var secondLayerTeams = allTeamsId.Where(t => t.DivisionRank == 2).OrderByDescending(t=> t.DivisionRank).ToList();

            var leaguePremId = Guid.NewGuid();
            var EFLChampionshipId = Guid.NewGuid();

            var faCupId = Guid.NewGuid();
            var listOfLeagueTeams = new List<LeagueTeam>();
            var rank = 1;
            foreach(var t in firstLayerTeams)
            {
                listOfLeagueTeams.Add(new LeagueTeam
                {
                    LeagueId = leaguePremId,
                    Id = Guid.NewGuid(),
                    TeamId = t.Id,
                    Rank = rank
                });
                rank++;
            }
            rank = 0;
            foreach (var t in secondLayerTeams)
            {
                listOfLeagueTeams.Add(new LeagueTeam
                {
                    LeagueId = EFLChampionshipId,
                    Id = Guid.NewGuid(),
                    TeamId = t.Id,
                    Rank = rank
                });
                rank++;
            }

            var listOfCupTeams = new List<LeagueTeam>();
            for (int i = 0; i < 10; i++)
            {
                listOfLeagueTeams.Add(new LeagueTeam
                {
                    LeagueId = faCupId,
                    Id = Guid.NewGuid(),
                    TeamId = firstLayerTeams[i].Id,
                    Rank = i + 1
                });
                listOfLeagueTeams.Add(new LeagueTeam
                {
                    LeagueId = faCupId,
                    Id = Guid.NewGuid(),
                    TeamId = secondLayerTeams[i].Id,
                    Rank = i + 50
                });
            }

            var cupTemplate = new LeagueTemplate
            {
                Id = Guid.NewGuid(),
                Name = "Cup template",
                IsEliminiatingCup = true
            };

            var leagueTemplate = new LeagueTemplate
            {
                Id = Guid.NewGuid(),
                Name = "Series template",
                IsEliminiatingCup = false,
                PointsOnDraw = 1,
                PointsOnWin = 3,
                TimesPlayingEachOther = 2
            };

            modelBuilder.Entity<LeagueTemplate>().HasData(cupTemplate, leagueTemplate);

            var theLeague = new League { Id = leaguePremId, Name = "Premieer League", LeagueTemplateId = leagueTemplate.Id };
            var theEFLChampionshipId = new League { Id = EFLChampionshipId, Name = "EFL Championship", LeagueTemplateId = leagueTemplate.Id };
            var faCup = new League { Id = faCupId, Name = "FA Cup", LeagueTemplateId = cupTemplate.Id};

            modelBuilder.Entity<League>().HasData(
                new League { Id = leaguePremId, Name = "Premieer League", LeagueTemplateId = leagueTemplate.Id },
                new League { Id = EFLChampionshipId, Name = "EFL Championship", LeagueTemplateId = leagueTemplate.Id },
                new League { Id = faCupId, Name = "FA Cup", LeagueTemplateId = cupTemplate.Id}
            );
            modelBuilder.Entity<LeagueTeam>().HasData(listOfLeagueTeams);
        }
    }
}
