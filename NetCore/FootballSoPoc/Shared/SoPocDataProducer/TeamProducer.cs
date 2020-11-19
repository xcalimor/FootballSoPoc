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
                new TeamData { Id = Guid.Parse("29090939-1D95-4AC2-AB29-DE91A2DB1368"), DivisionRank = 1, Name = "Arsenal" },
                new TeamData { Id = Guid.Parse("091EAB68-B90D-4E2C-AD39-87B06B9E46EB"), DivisionRank = 1, Name = "Aston Villa" },
                new TeamData { Id = Guid.Parse("D9B1B83D-4E3D-45A1-BC68-C7828B92AAD4"), DivisionRank = 1, Name = "Brighton & Hove Albion" },
                new TeamData { Id = Guid.Parse("8C7E4657-C9BC-4CAB-B825-E749CD42C358"), DivisionRank = 1, Name = "Burnley" },
                new TeamData { Id = Guid.Parse("6512A227-B8B0-4AAB-95A4-62F44E264BC8"), DivisionRank = 1, Name = "Chelsea" },
                new TeamData { Id = Guid.Parse("EF6AB149-CA29-4EC1-9F22-8875A4AA6BDF"), DivisionRank = 1, Name = "Crystal Palace" },
                new TeamData { Id = Guid.Parse("13C721DD-C33F-4519-BA1F-712237A06323"), DivisionRank = 1, Name = "Everton" },
                new TeamData { Id = Guid.Parse("1A1DC4DB-08CB-4ADE-A7F4-F8843013C857"), DivisionRank = 1, Name = "Fulham" },
                new TeamData { Id = Guid.Parse("2B0100F3-18B7-42C5-87E1-6805923F352D"), DivisionRank = 1, Name = "Leeds United" },
                new TeamData { Id = Guid.Parse("7F61B85F-6C4F-453C-BA64-9D00DF45BA8A"), DivisionRank = 1, Name = "Leicester City" },
                new TeamData { Id = Guid.Parse("52BFF2FF-B926-4F4A-8C0B-3EE37B245E2D"), DivisionRank = 1, Name = "Liverpool" },
                new TeamData { Id = Guid.Parse("F5779213-14B6-45DF-8033-D99355B8315C"), DivisionRank = 1, Name = "Manchester City" },
                new TeamData { Id = Guid.Parse("72AD2911-1718-4196-8BBE-CC75C59318C0"), DivisionRank = 1, Name = "Manchester United" },
                new TeamData { Id = Guid.Parse("9DE989DA-E454-46AF-9FAA-2F281CAFA48B"), DivisionRank = 1, Name = "Newcastle United" },
                new TeamData { Id = Guid.Parse("793F4D54-481E-42AE-80AA-1E714FD72A45"), DivisionRank = 1, Name = "Sheffield United" },
                new TeamData { Id = Guid.Parse("E748C6A4-74A1-442A-8D04-3D5309F04129"), DivisionRank = 1, Name = "Southampton" },
                new TeamData { Id = Guid.Parse("159136EF-515E-472C-BBB7-CA74D5129AE7"), DivisionRank = 1, Name = "Tottenham Hotspur" },
                new TeamData { Id = Guid.Parse("A4772A68-55F2-4D03-BF18-1BFE313D2935"), DivisionRank = 1, Name = "West Bromwich Albion" },
                new TeamData { Id = Guid.Parse("04E9D666-DFCB-4692-8D87-F4840B8549D5"), DivisionRank = 1, Name = "West Ham United" },
                new TeamData { Id = Guid.Parse("0D5E25BF-F764-4644-BBF3-CF7AB2CFF0AD"), DivisionRank = 1, Name = "Wolverhampton Wanderers" },
                new TeamData { Id = Guid.Parse("A3F8EEF4-8A92-407A-9402-D7DAE78A7499"), DivisionRank = 2, Name = "Reading" },
                new TeamData { Id = Guid.Parse("BF852FA5-60F6-4104-94DD-71746B309D1B"), DivisionRank = 2, Name = "Bristol City" },
                new TeamData { Id = Guid.Parse("D45E9DFB-7032-40E9-B871-18901F791536"), DivisionRank = 2, Name = "Watford" },
                new TeamData { Id = Guid.Parse("7FD4962C-A1E0-4C18-B7C5-1E2C9748DEBF"), DivisionRank = 2, Name = "Bournemouth" },
                new TeamData { Id = Guid.Parse("3FD0E4D7-5574-4DE4-957F-41DA87B26F5D"), DivisionRank = 2, Name = "Norwich City" },
                new TeamData { Id = Guid.Parse("CE43F7EA-F0D8-4354-B2AC-C411B216A87B"), DivisionRank = 2, Name = "Swansea City" },
                new TeamData { Id = Guid.Parse("7E560E4B-CDC0-4D3D-998B-DF9053813467"), DivisionRank = 2, Name = "Millwall" },
                new TeamData { Id = Guid.Parse("76AB740D-8BD5-428A-A2A5-3D63779805F2"), DivisionRank = 2, Name = "Stoke City" },
                new TeamData { Id = Guid.Parse("7BE361B9-46BB-4797-98B5-12D985492302"), DivisionRank = 2, Name = "Luton Town" },
                new TeamData { Id = Guid.Parse("BA6D5954-364C-45CF-A55D-8A207C369761"), DivisionRank = 2, Name = "Blackburn Rovers" },
                new TeamData { Id = Guid.Parse("A596DA7E-8406-42AB-AB87-9F103EE47272"), DivisionRank = 2, Name = "Brentford" },
                new TeamData { Id = Guid.Parse("3B52B592-A4BC-4B1C-8F7C-4FE467810DAC"), DivisionRank = 2, Name = "Preston North End" },
                new TeamData { Id = Guid.Parse("676AA12B-2D46-4E4D-8DC9-67FECCCD2BA5"), DivisionRank = 2, Name = "Middlesbrough" },
                new TeamData { Id = Guid.Parse("AE927C9D-FCD1-4BFC-8259-F8014E74B2E5"), DivisionRank = 2, Name = "Huddersfield Town" },
                new TeamData { Id = Guid.Parse("EF0E5227-F51F-4F7F-9D24-9A6A208C3A15"), DivisionRank = 2, Name = "Cardiff City" },
                new TeamData { Id = Guid.Parse("ED671605-1872-4089-8F2E-4CD9A9F68B72"), DivisionRank = 2, Name = "Queens Park Rangers" },
                new TeamData { Id = Guid.Parse("78D33450-F3DC-4BFD-A01F-1A0E91B75F1A"), DivisionRank = 2, Name = "Birmingham City" },
                new TeamData { Id = Guid.Parse("38C2BCE5-DE53-42E4-B61F-B64113C9D463"), DivisionRank = 2, Name = "Rotherham United" },
                new TeamData { Id = Guid.Parse("446090DC-4EDF-49EF-BE12-0F337CAA5C39"), DivisionRank = 2, Name = "Nottingham Forest" },
                new TeamData { Id = Guid.Parse("CCC7F427-9B43-4149-9D30-D381A86A146D"), DivisionRank = 2, Name = "Coventry City" },
                new TeamData { Id = Guid.Parse("787ABA1D-E768-4C7E-9128-E04FC7F25564"), DivisionRank = 2, Name = "Barnsley" },
                new TeamData { Id = Guid.Parse("3BA8507E-90DE-4C09-97AD-EEC460368C6C"), DivisionRank = 2, Name = "Derby County" },
                new TeamData { Id = Guid.Parse("0C1C9D69-7D41-4A85-840B-13CFF90FC467"), DivisionRank = 2, Name = "Wycombe Wanderers" },
                new TeamData { Id = Guid.Parse("F9E13D86-CDDD-4400-90D5-43571530B7DB"), DivisionRank = 2, Name = "Sheffield Wednesday" }
            };
        }

    }

    public class TeamData
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int DivisionRank { get; set; }
    }

}
