using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FMS3.Models;
using FMS3.Data.Interfaces;
using FMS3.Data.Cache;

namespace FMS3.Controllers
{
    public class HomeController : Controller
    {
        private static bool StaticDataLoaded { get; set; }

        private IGameDetailsData _gameDetailsData { get; }
        private INewsData _newsData {get;}
        private ITeamData _teamData { get; }

        public HomeController(IGameDetailsData gameDetailsData, INewsData newsData, ITeamData teamData)
        {
            _gameDetailsData = gameDetailsData;
            _newsData = newsData;
            _teamData = teamData;
        }

        public IActionResult Index()
        {
            if (!StaticDataLoaded)
            {
                var result = _gameDetailsData.LoadStaticData();
                if (!result)
                {
                    throw new Exception("Failed to load static data");
                }
                StaticDataLoaded = true;
            }
            return View();
        }

        public IActionResult NewGame()
        {            
            GameCache.GameDetailsId = _gameDetailsData.StartNewGame();
            return View();
        }

        public IActionResult LoadGame()
        {
            var games = _gameDetailsData.GetAll();
            return View(games);
        }

        public IActionResult SelectManager(string managerName)
        {
            var game = _gameDetailsData.SetManagerName(managerName);
            GameCache.CurrentSeasonId = game.CurrentSeasonId;
           
            //var team = _teamData.GetTeam(game.TeamId);
            var newsText = managerName + " has become manager of " + _teamData.GetTeamName(game.TeamId);

            _newsData.AddNews(new News
            {
                TeamId = game.TeamId,
                GameDetailsId = game.Id,
                SeasonId = game.CurrentSeasonId,
                NewsText = newsText
            });

            return View("StartGame",game);
        }

        public IActionResult SelectTeam(int teamId)
        {
            var game = _gameDetailsData.SetTeam(teamId); 
            return View("SelectManager",game);     
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
