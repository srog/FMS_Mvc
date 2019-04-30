using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FMS3.Models;
using System.Threading.Tasks;

namespace FMS3.Controllers
{
    public class HomeController : Controller
    {
        private static FmsService.FmsServiceClient _fmsServiceClient = new FmsService.FmsServiceClient();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewGame()
        {
            // Set up new game variables
            //_fmsServiceClient.NewGame();

            // Display initial new game screen
            var teamList = _fmsServiceClient.GetAllTeamsAsync().Result;

            return View(teamList);
        }

        public IActionResult LoadGame()
        {
            var games = _fmsServiceClient.GetAllGameDetailsAsync().Result;
            return View(games);
        }

        public IActionResult StartGame(int teamId)
        {
            var startGameTask = DoStartGame(teamId);
            startGameTask.Wait();

            var gameDetails = _fmsServiceClient.GetAllGameDetailsAsync().Result;
            return View(gameDetails[gameDetails.Length-1]);
        }

        public async Task DoStartGame(int teamId)
        {
            await _fmsServiceClient.StartGameAsync(teamId, "Ron Manager");
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
