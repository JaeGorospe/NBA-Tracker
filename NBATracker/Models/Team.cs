using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NBATracker.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public string FullName { get; set; }
        public string TriCode { get; set; }
        [JsonProperty("win")]
        public int Wins { get; set; }
        [JsonProperty("loss")]
        public int Losses { get; set; }
        public bool IsCurrentlyPlaying { get; set; }
        public int? Score { get; set; }

    }
}
