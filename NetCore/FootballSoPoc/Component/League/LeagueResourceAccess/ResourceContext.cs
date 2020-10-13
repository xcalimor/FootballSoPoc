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
        DbSet<LeaguePlayer> LeaguePlayers { get; set; }
        DbSet<GameDay> GameDays { get; set; }
        DbSet<Scorer> Scorers { get; set; }
        DbSet<Standing> Standings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var leaguePremId = Guid.NewGuid();

            var fakeTeam1 = new LeagueTeam
            {
                LeagueId = leaguePremId,
                Id = Guid.NewGuid(),
                TeamId = Guid.NewGuid(),
                Rank = 1
            };
            var fakeTeam2 = new LeagueTeam
            {
                LeagueId = leaguePremId,
                Id = Guid.NewGuid(),
                TeamId = Guid.NewGuid(),
                Rank = 2
            };
            var fakeTeam3 = new LeagueTeam
            {
                LeagueId = leaguePremId,
                Id = Guid.NewGuid(),
                TeamId = Guid.NewGuid(),
                Rank = 3
            };
            var fakeTeam4 = new LeagueTeam
            {
                LeagueId = leaguePremId,
                Id = Guid.NewGuid(),
                TeamId = Guid.NewGuid(),
                Rank = 4
            };

            var teams = new List<LeagueTeam>() {
                fakeTeam1,
                fakeTeam2,
                fakeTeam3,
                fakeTeam4
            };

            var fakePlayer1 = new LeaguePlayer
            {
                Id = Guid.NewGuid(),
                PlayerId = Guid.NewGuid()
            };
            var fakePlayer2 = new LeaguePlayer
            {
                Id = Guid.NewGuid(),
                PlayerId = Guid.NewGuid()
            };
            var fakePlayer3 = new LeaguePlayer
            {
                Id = Guid.NewGuid(),
                PlayerId = Guid.NewGuid()
            };
            var fakePlayer4 = new LeaguePlayer
            {
                Id = Guid.NewGuid(),
                PlayerId = Guid.NewGuid()
            };

            

            var gameddayFirst = Guid.NewGuid();
            var gameddaySecond = Guid.NewGuid();

            var scoreGameOneHomeTeam = new List<Scorer>()
            {
                new Scorer{LeaguePlayerId = fakePlayer1.Id, AssistedByLeaguePlayerId = fakePlayer2.Id, ScoredInMinute = 37}
            };

            var scoreGameOneAwayTeam = new List<Scorer>()
            {
                new Scorer{LeaguePlayerId = fakePlayer3.Id, AssistedByLeaguePlayerId = fakePlayer4.Id, ScoredInMinute = 22},
                new Scorer{LeaguePlayerId = fakePlayer3.Id, AssistedByLeaguePlayerId = fakePlayer4.Id, ScoredInMinute = 47},
                new Scorer{LeaguePlayerId = fakePlayer3.Id, AssistedByLeaguePlayerId = fakePlayer4.Id, ScoredInMinute = 78},
            };



            var theLeague = new League { Id = leaguePremId, Name = "Premieer League" };
            modelBuilder.Entity<League>().HasData(theLeague);
            modelBuilder.Entity<LeaguePlayer>().HasData(
                fakePlayer1,
                fakePlayer2,
                fakePlayer3,
                fakePlayer4
                );
            modelBuilder.Entity<LeagueTeam>().HasData(
                fakeTeam1,
                fakeTeam2,
                fakeTeam3,
                fakeTeam4
                );


            modelBuilder.Entity<GameDay>().HasData(
                new GameDay { Id = gameddayFirst, LeagueId = theLeague.Id, SheduledAt = DateTime.Now.AddMinutes(5), HomeLeagueTeamId = fakeTeam1.Id, AwayLeagueTeamId = fakeTeam2.Id },
                new GameDay { Id = gameddaySecond, LeagueId = theLeague.Id, SheduledAt = DateTime.Now.AddMinutes(5), HomeLeagueTeamId = fakeTeam3.Id, AwayLeagueTeamId = fakeTeam4.Id },
                new GameDay { Id = Guid.NewGuid(), LeagueId = theLeague.Id, SheduledAt = DateTime.Now.AddMinutes(10), HomeLeagueTeamId = fakeTeam2.Id, AwayLeagueTeamId = fakeTeam3.Id },
                new GameDay { Id = Guid.NewGuid(), LeagueId = theLeague.Id, SheduledAt = DateTime.Now.AddMinutes(10), HomeLeagueTeamId = fakeTeam4.Id, AwayLeagueTeamId = fakeTeam1.Id },
                new GameDay { Id = Guid.NewGuid(), LeagueId = theLeague.Id, SheduledAt = DateTime.Now.AddMinutes(15), HomeLeagueTeamId = fakeTeam3.Id, AwayLeagueTeamId = fakeTeam1.Id },
                new GameDay { Id = Guid.NewGuid(), LeagueId = theLeague.Id, SheduledAt = DateTime.Now.AddMinutes(15), HomeLeagueTeamId = fakeTeam2.Id, AwayLeagueTeamId = fakeTeam4.Id }
            );

            modelBuilder.Entity<Scorer>().HasData(
                new Scorer { Id = Guid.NewGuid(), GameDayId = gameddayFirst, LeaguePlayerId = fakePlayer3.Id, AssistedByLeaguePlayerId = fakePlayer4.Id, ScoredInMinute = 22},
                new Scorer { Id = Guid.NewGuid(), GameDayId = gameddayFirst, LeaguePlayerId = fakePlayer3.Id, AssistedByLeaguePlayerId = fakePlayer4.Id, ScoredInMinute = 47},
                new Scorer { Id = Guid.NewGuid(), GameDayId = gameddayFirst, LeaguePlayerId = fakePlayer3.Id, AssistedByLeaguePlayerId = fakePlayer4.Id, ScoredInMinute = 78},
                new Scorer { Id = Guid.NewGuid(), GameDayId = gameddayFirst, LeaguePlayerId = fakePlayer1.Id, AssistedByLeaguePlayerId = fakePlayer2.Id, ScoredInMinute = 37 }
            );

            modelBuilder.Entity<Standing>().HasData(
                new Standing { Id = Guid.NewGuid(), LeagueId = theLeague.Id, LeagueTeamId = fakeTeam1.Id, GoalsAgainst = 3, GoalsMade = 1, HomeGames = 1, Points = 0 },
                new Standing { Id = Guid.NewGuid(), LeagueId = theLeague.Id, LeagueTeamId = fakeTeam2.Id, GoalsAgainst = 1, GoalsMade = 3, AwayGames = 1, Points = 3 },
                new Standing { Id = Guid.NewGuid(), LeagueId = theLeague.Id, LeagueTeamId = fakeTeam3.Id, GoalsAgainst = 0, GoalsMade = 0, HomeGames = 1, Draw = 1, Points = 1 },
                new Standing { Id = Guid.NewGuid(), LeagueId = theLeague.Id, LeagueTeamId = fakeTeam4.Id, GoalsAgainst = 0, GoalsMade = 0, HomeGames = 1, Draw = 1, Points = 1 }
            );




        }
    }
}
