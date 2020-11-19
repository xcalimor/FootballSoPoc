using Microsoft.EntityFrameworkCore;
using SoPocDataProducer;
using System;
using System.Collections.Generic;
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
        public DbSet<TeamManagerContract> TeamManagerContracts { get; set; }

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

            var contracts = new List<TeamManagerContract>();
            var allTeamEntities = new List<Team>
            {
                CreateTeam(allTeamsId.Single(t => t.Name == "Arsenal"), londonId, "Emirates Stadium", 60704, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Aston Villa"), birminghamId, "Villa Park", 42749, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Brighton & Hove Albion"), brightonNHoveId, "American Express Community Stadium", 30750, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Burnley"), burnleyId, "Turf Moor", 21944, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Chelsea"), londonId, "Stamford Bridge", 41631, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Crystal Palace"), londonId, "Selhurst Park", 26125, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Everton"), liverpoolId, "Goodison Park", 39572, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Fulham"), londonId, "Craven Cottage", 25700, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Leeds United"), LeedsId, "Elland Road", 37890, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Leicester City"), LeicesterId, "King Power Stadium", 32312, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Liverpool"), liverpoolId, "Anfield", 54074, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Manchester City"), manchesterId, "Etihad Stadium", 55097, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Manchester United"), manchesterId, "Old Trafford", 74994, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Newcastle United"), newcastleId, "St James' Park", 52354, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Sheffield United"), sheffieldId, "Bramall Lane", 32609, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Southampton"), southamptonId, "St Mary's Stadium", 32505, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Tottenham Hotspur"), londonId, "Tottenham Hotspur Stadium", 62062, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "West Bromwich Albion"), westBromwichId, "The Hawthorns", 26688, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "West Ham United"), londonId, "Londons Olympiastadion", 60000, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Wolverhampton Wanderers"), wolverhamptonId, "Molineux Stadium", 32050, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Reading"), readingId, "Madejski Stadium", 24161, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Bristol City"), bristolCityId, "Ashton Gate Stadium", 27000, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Watford"), watfordId, "Vicarage Road", 21577, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Bournemouth"), bournemouthId, "Vitality Stadium", 11364, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Norwich City"), norwichCityId, "Carrow Road", 27244, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Swansea City"), swanseaCityId, "Liberty Stadium", 21088, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Millwall"), londonId, "The Den", 20146, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Stoke City"), stokeCityId, "Bet365 Stadium", 30089, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Luton Town"), lutonTownId, "Kenilworth Road", 10356, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Blackburn Rovers"), blackburnRoversId, "Ewood Park", 31367, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Brentford"), londonId, "Brentford Community Stadium", 17250, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Preston North End"), PrestonNorthEndiD, "Deepdale", 23404, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Middlesbrough"), MiddlesbroughiD, "Riverside Stadium", 34742, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Huddersfield Town"), huddersfieldTownId, "John Smith's Stadium", 24500, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Cardiff City"), cardiffCityId, "Cardiff City Stadium", 33280, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Queens Park Rangers"), londonId, "Loftus Road", 18439, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Birmingham City"), londonId, "Loftus Road", 18439, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Rotherham United"), londonId, "Loftus Road", 18439, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Nottingham Forest"), londonId, "Loftus Road", 18439, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Coventry City"), londonId, "Loftus Road", 18439, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Barnsley"), londonId, "Loftus Road", 18439, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Derby County"), londonId, "Loftus Road", 18439, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Wycombe Wanderers"), londonId, "Loftus Road", 18439, ref contracts, Guid.NewGuid()),
                CreateTeam(allTeamsId.Single(t => t.Name == "Sheffield Wednesday"), londonId, "Loftus Road", 18439, ref contracts, Guid.NewGuid())
            };


            foreach(var c in contracts)
            {

            }
            
            //modelBuilder.Entity<TeamManagerContract>().HasData(contracts);
            modelBuilder.Entity<Team>().HasData(Teams);
        }
    
        private Team CreateTeam(TeamData TeamData, Guid cityId, string arenaName, int arenaCapacity, ref List<TeamManagerContract> contracts, Guid accountId)
        {
            var newContract = new TeamManagerContract
            {
                Id = Guid.NewGuid(),
                AccountId = accountId,
                InYears = 5,
                RemainingYears = 5
            };
            contracts.Add(newContract);
            return new Team { TeamId = TeamData.Id, Name = TeamData.Name, CityId = cityId, ArenaName = arenaName, ArenaCapacity = arenaCapacity, TeamManagerContractId = newContract.Id };
        }
    }


}
