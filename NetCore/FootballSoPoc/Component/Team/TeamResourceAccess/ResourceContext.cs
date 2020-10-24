using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using TeamResourceAccess.Entity;

namespace TeamResourceAccess
{
    public class ResourceContext : DbContext
    {
        public ResourceContext(DbContextOptions<ResourceContext> options) : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var londonId = Guid.NewGuid();
            var birminghamId = Guid.NewGuid();
            var brightonNHoveId = Guid.NewGuid();
            var burnleyId = Guid.NewGuid();
            var liverpoolId = Guid.NewGuid();
            var manchesterId = Guid.NewGuid();
            var LeedsId = Guid.NewGuid();
            var LeicesterId = Guid.NewGuid();
            var newcastleId = Guid.NewGuid();
            var sheffieldId = Guid.NewGuid();
            var southamptonId = Guid.NewGuid();
            var westBromwichId = Guid.NewGuid();
            var wolverhamptonId = Guid.NewGuid();

            modelBuilder.Entity<City>().HasData(
                new City { CityId = londonId, Name = "London", Population =  8982000},
                new City { CityId = birminghamId, Name = "Birmingham", Population = 1086000 },
                new City { CityId = brightonNHoveId, Name = "Brighton & Hove", Population = 229700 },
                new City { CityId = burnleyId, Name = "Burnley", Population = 87300 },
                new City { CityId = liverpoolId, Name = "Liverpool", Population = 552267 },
                new City { CityId = manchesterId, Name = "Manchester", Population = 5107467 },
                new City { CityId = LeedsId, Name = "Leeds", Population = 474632 },
                new City { CityId = LeicesterId, Name = "Leicester", Population = 329839 },
                new City { CityId = newcastleId, Name = "Newcastle", Population = 268064 },
                new City { CityId = sheffieldId, Name = "Sheffield", Population = 518090 },
                new City { CityId = southamptonId, Name = "Southampton", Population = 253651 },
                new City { CityId = westBromwichId, Name = "West Bromwich", Population = 77997 },
                new City { CityId = wolverhamptonId, Name = "Wolverhampton", Population = 77997 }
                );

            var allTeamsId = SoPocDataProducer.TeamProducer.GetAllTeams();

            modelBuilder.Entity<Team>().HasData(
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Arsenal").Id, Name = "Arsenal", CityId = londonId, ArenaName = "Emirates Stadium", ArenaCapacity = 60704 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Aston Villa").Id, Name = "Aston Villa", CityId = birminghamId, ArenaName = "Villa Park", ArenaCapacity = 42749 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Brighton & Hove Albion").Id, Name = "Brighton & Hove Albion", CityId = brightonNHoveId, ArenaName = "American Express Community Stadium", ArenaCapacity = 30750 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Burnley").Id, Name = "Burnley", CityId = burnleyId, ArenaName = "Turf Moor", ArenaCapacity = 21944 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Chelsea").Id, Name = "Chelsea", CityId = londonId, ArenaName = "Stamford Bridge", ArenaCapacity = 41631 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Crystal Palace").Id, Name = "Crystal Palace", CityId = londonId, ArenaName = "Selhurst Park", ArenaCapacity = 26125 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Everton").Id, Name = "Everton", CityId = liverpoolId, ArenaName = "Goodison Park", ArenaCapacity = 39572 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Fulham").Id, Name = "Fulham", CityId = londonId, ArenaName = "Craven Cottage", ArenaCapacity = 25700 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Leeds United").Id, Name = "Leeds United", CityId = LeedsId, ArenaName = "Elland Road", ArenaCapacity = 37890 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Leicester City").Id, Name = "Leicester City", CityId = LeicesterId, ArenaName = "King Power Stadium", ArenaCapacity = 32312 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Liverpool").Id, Name = "Liverpool", CityId = liverpoolId, ArenaName = "Anfield", ArenaCapacity = 54074 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Manchester City").Id, Name = "Manchester City", CityId = manchesterId, ArenaName = "Etihad Stadium", ArenaCapacity = 55097 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Manchester United").Id, Name = "Manchester United", CityId = manchesterId, ArenaName = "Old Trafford", ArenaCapacity = 74994 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Newcastle United").Id, Name = "Newcastle United", CityId = newcastleId, ArenaName = "St James' Park", ArenaCapacity = 52354 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Sheffield United").Id, Name = "Sheffield United", CityId = sheffieldId, ArenaName = "Bramall Lane", ArenaCapacity = 32609 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Southampton").Id, Name = "Southampton", CityId = southamptonId, ArenaName = "St Mary's Stadium", ArenaCapacity = 32505 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Tottenham Hotspur").Id, Name = "Tottenham Hotspur", CityId = londonId, ArenaName = "Tottenham Hotspur Stadium", ArenaCapacity = 62062 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "West Bromwich Albion").Id, Name = "West Bromwich Albion", CityId = westBromwichId, ArenaName = "The Hawthorns", ArenaCapacity = 26688 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "West Ham United").Id, Name = "West Ham United", CityId = londonId, ArenaName = "Londons Olympiastadion", ArenaCapacity = 60000 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Wolverhampton Wanderers").Id, Name = "Wolverhampton Wanderers", CityId = wolverhamptonId, ArenaName = "Molineux Stadium", ArenaCapacity = 32050 }
            );
        }
    }
}
