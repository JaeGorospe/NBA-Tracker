using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NBATracker.Models;
using NBATracker.Clients;

namespace NBATracker.Controllers
{
    public class HomeController : Controller
    {
        private readonly INbaApiHTTPClient _nbaClient;

        public HomeController(INbaApiHTTPClient nbaClient)
        {
            _nbaClient = nbaClient;
        }
        public async Task<IActionResult> Index()
        {
            HomeViewModel view = new HomeViewModel
            {
                Teams = await _nbaClient.GetTeamsAsync(),
                TodaysGames = await _nbaClient.GetTodaysGamesAsync()
            };
            return View(view);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
