using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FMS3.Models;
using FMS3.Data.Cache;
using FMS3.Services.Interfaces;

namespace FMS3.Controllers
{
    public class HomeController : Controller
    {
        private static bool StaticDataLoaded { get; set; }

        private IGameDetailsService _gameDetailsService { get; }
        private INewsService _newsService {get;}
        private ITeamService _teamService { get; }

        public HomeController(IGameDetailsService gameDetailsService, INewsService newsService, ITeamService teamService)
        {
            _gameDetailsService = gameDetailsService;
            _newsService = newsService;
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            if (!StaticDataLoaded)
            {
                var result = _gameDetailsService.LoadStaticData();
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
            GameCache.GameDetailsId = _gameDetailsService.StartNewGame();
            return View();
        }

        public IActionResult LoadGame()
        {
            var games = _gameDetailsService.GetAll();
            return View(games);
        }

        public IActionResult SelectManager(string managerName)
        {
            var game = _gameDetailsService.SetManagerName(managerName);
            GameCache.CurrentSeasonId = game.CurrentSeasonId;
           
            //var team = _teamData.GetTeam(game.TeamId);
            var newsText = managerName + " has become manager of " + _teamService.GetTeamName(game.TeamId);

            _newsService.Add(new News
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
            var game = _gameDetailsService.SetTeam(teamId); 
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
