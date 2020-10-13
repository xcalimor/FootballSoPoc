using LeagueApi.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace LeagueApi.Controllers
{
    [Route("fsopoc/api/[controller]")]
    [ApiController]
    public class LeagueController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public LeagueController(IHttpClientFactory  httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        //[HttpGet()]
        //public async Task<IEnumerable<League>> Get()
        //{
        //    var client = _httpClientFactory.CreateClient("LeagueResourceAccessClient");
        //    var leagues = await client.GetAsync("");
        //    return Ok(leagues);
        //}
    }
}
