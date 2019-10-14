using NBATracker.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace NBATracker.Clients
{
    public class NbaApiHTTPClient : INbaApiHTTPClient
    {
        private readonly IHttpClientFactory _clientFactory;

        public NbaApiHTTPClient(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<IEnumerable<Team>> GetTeamsAsync()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
                "prod/v1/2019/teams.json");
            var client = _clientFactory.CreateClient("nba");
            var response = await client.SendAsync(request);
            IList<Team> teamListObject = new List<Team>();
            if (response.IsSuccessStatusCode)
            {
                JObject jsonResults = JObject.Parse(await response.Content.ReadAsStringAsync());
                IList<JToken> teamListResult = jsonResults["league"]["standard"].Children().ToList();
                foreach (JToken token in teamListResult)
                {
                    Team team = token.ToObject<Team>();
                    teamListObject.Add(team);
                }
            }
            return teamListObject;
        }
    }
}
