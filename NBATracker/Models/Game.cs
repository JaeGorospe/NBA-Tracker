using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NBATracker.Models
{
    public class Game
    {
        public int GameID { get; set; }
        [JsonProperty("hTeam")]
        public Team HomeTeam { get; set; }
        [JsonProperty("vTeam")]
        public Team AwayTeam { get; set; }
        public string StartTimeEastern { get; set; }
        [JsonProperty("clock")]
        public string Clock { get; set; }
        public DateTimeOffset? StartTimeUTC { get; set; }
    }
}
