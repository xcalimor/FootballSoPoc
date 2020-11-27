using Microsoft.EntityFrameworkCore;
using PlayerResourceAccess.Entity;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;

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

            modelBuilder.Entity<PlayerContract>()
                .HasKey(c => new { c.TeamId, c.PlayerId });

            Random rnd = new Random();

            var allTeamsId = SoPocDataProducer.TeamProducer.GetAllTeams();
            var allFirstnames = SoPocDataProducer.PlayerProducer.GetAllFirstNames();
            var allSurnames = SoPocDataProducer.PlayerProducer.GetAllSurnames();

            List<PlayerContract> contracts = new List<PlayerContract>();
            List<Player> allPlayers = new List<Player>();
            foreach(var t in allTeamsId)
            {
                for(int i = 0; i< 32; i++)
                {
                    var newPlayer = new Player
                    {
                        Id = Guid.NewGuid(),
                        Age = rnd.Next(18, 42),
                        Firstname = allFirstnames[rnd.Next(0, allFirstnames.Count - 1)],
                        Surname = allSurnames[rnd.Next(0, allSurnames.Count - 1)],
                        Height = rnd.Next(170, 200),
                        Weight = rnd.Next(65, 110),
                        Stamina = rnd.Next(90, 100),
                        Reaction = rnd.Next(90, 100),
                        GameIQ = rnd.Next(90, 100),
                        Offensive = rnd.Next(40, 100),
                        Deffensive = rnd.Next(40, 100),
                    };
                    allPlayers.Add(newPlayer);
                    contracts.Add(new PlayerContract { PlayerId = newPlayer.Id, TeamId = t.Id, InYears = 10, Salary = 30000 });
                }
            }
            modelBuilder.Entity<Player>().HasData(allPlayers);
            modelBuilder.Entity<PlayerContract>().HasData(contracts);
        }
    }
}
