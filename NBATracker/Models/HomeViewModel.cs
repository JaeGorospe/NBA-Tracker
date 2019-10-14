using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBATracker.Models
{
    public class HomeViewModel
    {
        public IEnumerable<Team> Teams { get; set; }
    }
}
