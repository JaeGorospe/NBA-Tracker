using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NBATracker.Models;

namespace NBATracker.Clients
{
    public interface INbaApiHTTPClient
    {
        Task<IEnumerable<Team>> GetTeamsAsync();
        Task<IEnumerable<Game>> GetTodaysGamesAsync();

    }
}
