using Microsoft.AspNetCore.SignalR.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeagueApi.Model
{
    public class League
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        List<LeagueTeam> Teams { get; set; }
    }
}
