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
            var readingId = Guid.NewGuid();
            var bristolCityId = Guid.NewGuid();
            var watfordId = Guid.NewGuid();
            var bournemouthId = Guid.NewGuid();
            var norwichCityId = Guid.NewGuid();
            var swanseaCityId = Guid.NewGuid();
            var millwallId = Guid.NewGuid();
            var lutonTownId = Guid.NewGuid();
            var stokeCityId = Guid.NewGuid();
            var blackburnRoversId = Guid.NewGuid();
            var PrestonNorthEndiD = Guid.NewGuid();
            var MiddlesbroughiD = Guid.NewGuid();
            var huddersfieldTownId = Guid.NewGuid();
            var cardiffCityId = Guid.NewGuid();

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
                new City { CityId = wolverhamptonId, Name = "Wolverhampton", Population = 77997 },
                new City { CityId = readingId, Name = "Reading", Population = 77997 },
                new City { CityId = bristolCityId, Name = "Bristol", Population = 535907 },
                new City { CityId = watfordId, Name = "Watford", Population = 120960 },
                new City { CityId = bournemouthId, Name = "Bournemouth", Population = 187503 },
                new City { CityId = norwichCityId, Name = "Norwich", Population = 174047 },
                new City { CityId = swanseaCityId, Name = "Swansea", Population = 179485 },
                new City { CityId = lutonTownId, Name = "Luton", Population = 258018 },
                new City { CityId = stokeCityId, Name = "Stoke-on-Trent", Population = 275000 },
                new City { CityId = blackburnRoversId, Name = "Blackburn", Population = 117963 },
                new City { CityId = PrestonNorthEndiD, Name = "Preston", Population = 148836 },
                new City { CityId = MiddlesbroughiD, Name = "Middlesbrough", Population = 140398 },
                new City { CityId = huddersfieldTownId, Name = "Huddersfield", Population = 162949 },
                new City { CityId = cardiffCityId, Name = "Cardiff", Population = 327706 }
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
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Wolverhampton Wanderers").Id, Name = "Wolverhampton Wanderers", CityId = wolverhamptonId, ArenaName = "Molineux Stadium", ArenaCapacity = 32050 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Reading").Id, Name = "Reading", CityId = readingId, ArenaName = "Madejski Stadium", ArenaCapacity = 24161 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Bristol City").Id, Name = "Bristol City", CityId = bristolCityId, ArenaName = "Ashton Gate Stadium", ArenaCapacity = 27000 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Watford").Id, Name = "Watford", CityId = watfordId, ArenaName = "Vicarage Road", ArenaCapacity = 21577 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Bournemouth").Id, Name = "Bournemouth", CityId = bournemouthId, ArenaName = "Vitality Stadium", ArenaCapacity = 11364 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Norwich City").Id, Name = "Norwich City", CityId = norwichCityId, ArenaName = "Carrow Road", ArenaCapacity = 27244 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Swansea City").Id, Name = "Swansea City", CityId = swanseaCityId, ArenaName = "Liberty Stadium", ArenaCapacity = 21088 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Millwall").Id, Name = "Millwall", CityId = londonId, ArenaName = "The Den", ArenaCapacity = 20146 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Stoke City").Id, Name = "Stoke City", CityId = stokeCityId, ArenaName = "Bet365 Stadium", ArenaCapacity = 30089 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Luton Town").Id, Name = "Luton Town", CityId = lutonTownId, ArenaName = "Kenilworth Road", ArenaCapacity = 10356 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Blackburn Rovers").Id, Name = "Blackburn Rovers", CityId = blackburnRoversId, ArenaName = "Ewood Park", ArenaCapacity = 31367 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Brentford").Id, Name = "Brentford", CityId = londonId, ArenaName = "Brentford Community Stadium", ArenaCapacity = 17250 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Preston North End").Id, Name = "Preston North End", CityId = PrestonNorthEndiD, ArenaName = "Deepdale", ArenaCapacity = 23404 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Middlesbrough").Id, Name = "Middlesbrough", CityId = MiddlesbroughiD, ArenaName = "Riverside Stadium", ArenaCapacity = 34742 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Huddersfield Town").Id, Name = "Huddersfield Town", CityId = huddersfieldTownId, ArenaName = "John Smith's Stadium", ArenaCapacity = 24500 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Cardiff City").Id, Name = "Cardiff City", CityId = cardiffCityId, ArenaName = "Cardiff City Stadium", ArenaCapacity = 33280 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Queens Park Rangers").Id, Name = "Queens Park Rangers", CityId = londonId, ArenaName = "Loftus Road", ArenaCapacity = 18439 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Birmingham City").Id, Name = "Birmingham City", CityId = londonId, ArenaName = "Loftus Road", ArenaCapacity = 18439 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Rotherham United").Id, Name = "Rotherham United", CityId = londonId, ArenaName = "Loftus Road", ArenaCapacity = 18439 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Nottingham Forest").Id, Name = "Nottingham Forest", CityId = londonId, ArenaName = "Loftus Road", ArenaCapacity = 18439 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Coventry City").Id, Name = "Coventry City", CityId = londonId, ArenaName = "Loftus Road", ArenaCapacity = 18439 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Barnsley").Id, Name = "Barnsley", CityId = londonId, ArenaName = "Loftus Road", ArenaCapacity = 18439 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Derby County").Id, Name = "Derby County", CityId = londonId, ArenaName = "Loftus Road", ArenaCapacity = 18439 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Wycombe Wanderers").Id, Name = "Wycombe Wanderers", CityId = londonId, ArenaName = "Loftus Road", ArenaCapacity = 18439 },
                new Team { TeamId = allTeamsId.Single(t => t.Name == "Sheffield Wednesday").Id, Name = "Sheffield Wednesday", CityId = londonId, ArenaName = "Loftus Road", ArenaCapacity = 18439 }
               );



        }
    }
}
