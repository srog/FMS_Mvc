using System;
using System.Diagnostics;
using FMS3.Data.Cache;
using Microsoft.AspNetCore.Mvc;
using FMS3.Models;
using FMS3.Services.Interfaces;

namespace FMS3.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGameDetailsService _gameDetailsService;

        public HomeController(IGameDetailsService gameDetailsService)
        {
            _gameDetailsService = gameDetailsService;
        }

        public IActionResult Index()
        {
            if (!GameCache.StaticDataLoaded)
            {
                var result = _gameDetailsService.LoadStaticData();
                if (!result)
                {
                    throw new Exception("Failed to load static data");
                }
                GameCache.StaticDataLoaded = true;
            }
            return View();
        }

        public IActionResult NewGame()
        {            
            var game = _gameDetailsService.StartNewGame();
            if (game != null)
            {
                return View();
            }
            else
            {
                return View("Index");
            }
        }

        public IActionResult LoadGame()
        {
            var games = _gameDetailsService.GetAll();
            return View(games);
        }

        public IActionResult SelectManager(string managerName)
        {
            var game = _gameDetailsService.SetManagerName(managerName);
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
