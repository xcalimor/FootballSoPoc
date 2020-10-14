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

            var leaguePremId = Guid.NewGuid();
            var faCupId = Guid.NewGuid();
            var listOfPremTeams = new List<LeagueTeam>();
            for(int i = 0; i < 13; i++)
            {
                listOfPremTeams.Add(new LeagueTeam
                {
                    LeagueId = leaguePremId,
                    Id = Guid.NewGuid(),
                    TeamId = Guid.NewGuid(),
                    Rank = i+1
                });
            }
            var listOfCupTeams = new List<LeagueTeam>();
            for (int i = 0; i < 10; i++)
            {
                listOfCupTeams.Add(new LeagueTeam
                {
                    LeagueId = faCupId,
                    Id = Guid.NewGuid(),
                    TeamId = Guid.NewGuid(),
                    Rank = i+1
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
            var faCup = new League { Id = faCupId, Name = "FA Cup", LeagueTemplateId = cupTemplate.Id};

            modelBuilder.Entity<League>().HasData(theLeague, faCup);
            modelBuilder.Entity<LeagueTeam>().HasData(
                listOfPremTeams[0],
                listOfPremTeams[1],
                listOfPremTeams[2],
                listOfPremTeams[3],
                listOfPremTeams[4],
                listOfPremTeams[5],
                listOfPremTeams[6],
                listOfPremTeams[7],
                listOfPremTeams[8],
                listOfPremTeams[9],
                listOfPremTeams[10],
                listOfPremTeams[11],
                listOfPremTeams[12],
                listOfCupTeams[0],
                listOfCupTeams[1],
                listOfCupTeams[2],
                listOfCupTeams[3],
                listOfCupTeams[4],
                listOfCupTeams[5],
                listOfCupTeams[6],
                listOfCupTeams[7],
                listOfCupTeams[8],
                listOfCupTeams[9]
                );
        }
    }
}
