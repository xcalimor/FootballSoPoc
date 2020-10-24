using Microsoft.EntityFrameworkCore;
using PlayerResourceAccess.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PlayerResourceAccess
{
    public class ResourceContext : DbContext
    {
        public ResourceContext(DbContextOptions<ResourceContext> options) : base(options)
        {

        }

        DbSet<Player> Players { get; set; }
        DbSet<GoalStatsDetail> GoalStatsDetails { get; set; }
        DbSet<PlayerAggregatedStats> PlayerAggregatedStats { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            Random rnd = new Random();

            var allTeamsId = SoPocDataProducer.TeamProducer.GetAllTeams();
            var allFirstnames = SoPocDataProducer.PlayerProducer.GetAllFirstNames();
            var allSurnames = SoPocDataProducer.PlayerProducer.GetAllSurnames();

            List<Player> AllPlayers = new List<Player>();
            foreach(var t in allTeamsId)
            {
                AllPlayers.Add(new Player
                {
                    Id = Guid.NewGuid(),
                    TeamId = t.Id,
                    Age = rnd.Next(18, 42),
                    Firstname = allFirstnames[rnd.Next(0, allFirstnames.Count-1)],
                    Surname = allSurnames[rnd.Next(0, allSurnames.Count - 1)],
                    Height = rnd.Next(170,200),
                    Weight = rnd.Next(65,110),
                    Stamina = rnd.Next(90, 100),
                    Reaction = rnd.Next(90,100),
                    GameIQ = rnd.Next(90,100),
                    Offensive = rnd.Next(40,100),
                    Deffensive = rnd.Next(40, 100),
                });
            }

            foreach(var entity in AllPlayers)
            {
                modelBuilder.Entity<Player>().HasData(entity);
                modelBuilder.Entity<GoalStatsDetail>().HasData(new GoalStatsDetail {PlayerId = entity.Id, InLeagueId = Guid.NewGuid(), ForTeamId = entity.TeamId, At = DateTime.Now, GameTime = 73, GoalMadeNotSaved = true});
                modelBuilder.Entity<PlayerAggregatedStats>().HasData(new PlayerAggregatedStats { Id = Guid.NewGuid(), PlayerId = entity.Id, MinutesPlayed = 123, Assists = 12, GamesPlayed = 12, GoalsMade = 12, GoalsSaved = 21, });
            }
            
        }
    }
}
