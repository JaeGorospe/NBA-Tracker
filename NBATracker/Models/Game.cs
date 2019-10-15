using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBATracker.Models
{
    public class Game
    {
        public int GameID { get; set; }
        public string HomeTeamId { get; set; }
        public string AwayTeamId { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public int HomeScore { get; set; }
    }
}
