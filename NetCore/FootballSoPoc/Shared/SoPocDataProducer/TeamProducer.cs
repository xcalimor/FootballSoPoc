using System;
using System.Collections.Generic;

namespace SoPocDataProducer
{
    public static class TeamProducer
    {
        public static List<TeamData> GetAllTeams()
        {
            return new List<TeamData>
            {
                new TeamData { Id = Guid.Parse("29090939-1D95-4AC2-AB29-DE91A2DB1368"), Name = "Arsenal" },
                new TeamData { Id = Guid.Parse("091EAB68-B90D-4E2C-AD39-87B06B9E46EB"), Name = "Aston Villa" },
                new TeamData { Id = Guid.Parse("D9B1B83D-4E3D-45A1-BC68-C7828B92AAD4"), Name = "Brighton & Hove Albion" },
                new TeamData { Id = Guid.Parse("8C7E4657-C9BC-4CAB-B825-E749CD42C358"), Name = "Burnley" },
                new TeamData { Id = Guid.Parse("6512A227-B8B0-4AAB-95A4-62F44E264BC8"), Name = "Chelsea" },
                new TeamData { Id = Guid.Parse("EF6AB149-CA29-4EC1-9F22-8875A4AA6BDF"), Name = "Crystal Palace" },
                new TeamData { Id = Guid.Parse("13C721DD-C33F-4519-BA1F-712237A06323"), Name = "Everton" },
                new TeamData { Id = Guid.Parse("1A1DC4DB-08CB-4ADE-A7F4-F8843013C857"), Name = "Fulham" },
                new TeamData { Id = Guid.Parse("2B0100F3-18B7-42C5-87E1-6805923F352D"), Name = "Leeds United" },
                new TeamData { Id = Guid.Parse("7F61B85F-6C4F-453C-BA64-9D00DF45BA8A"), Name = "Leicester City" },
                new TeamData { Id = Guid.Parse("52BFF2FF-B926-4F4A-8C0B-3EE37B245E2D"), Name = "Liverpool" },
                new TeamData { Id = Guid.Parse("F5779213-14B6-45DF-8033-D99355B8315C"), Name = "Manchester City" },
                new TeamData { Id = Guid.Parse("72AD2911-1718-4196-8BBE-CC75C59318C0"), Name = "Manchester United" },
                new TeamData { Id = Guid.Parse("9DE989DA-E454-46AF-9FAA-2F281CAFA48B"), Name = "Newcastle United" },
                new TeamData { Id = Guid.Parse("793F4D54-481E-42AE-80AA-1E714FD72A45"), Name = "Sheffield United" },
                new TeamData { Id = Guid.Parse("E748C6A4-74A1-442A-8D04-3D5309F04129"), Name = "Southampton" },
                new TeamData { Id = Guid.Parse("159136EF-515E-472C-BBB7-CA74D5129AE7"), Name = "Tottenham Hotspur" },
                new TeamData { Id = Guid.Parse("A4772A68-55F2-4D03-BF18-1BFE313D2935"), Name = "West Bromwich Albion" },
                new TeamData { Id = Guid.Parse("04E9D666-DFCB-4692-8D87-F4840B8549D5"), Name = "West Ham United" },
                new TeamData { Id = Guid.Parse("0D5E25BF-F764-4644-BBF3-CF7AB2CFF0AD"), Name = "Wolverhampton Wanderers" }
            };
        }
    }

    public class TeamData
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

}
