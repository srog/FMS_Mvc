using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FMS3.Models;
using FMS3.Data;

namespace FMS3.Controllers
{
    public class HomeController : Controller
    {
        private readonly GameDetailsData _gameDetailsData = new GameDetailsData();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewGame()
        {
            // Set up new game variables
            //_fmsServiceClient.NewGame();

            // Display initial new game screen
            //var teamList = _fmsServiceClient.GetAllTeamsAsync().Result;

            return View();
        }

        public IActionResult LoadGame()
        {
            var games = _gameDetailsData.GetAllGameDetails();
            return View(games);
        }

        public IActionResult StartGame(int teamId, string managerName)
        {
            var gameId = _gameDetailsData.AddGameDetails(new GameDetails
            {
                CurrentYear = 2020,
                CurrentWeek = 0,
                TeamId = teamId,
                ManagerName = managerName
            });

            var gameDetails = _gameDetailsData.GetGameDetails(gameId);

            _gameDetailsData.StartNewGame(gameDetails);

            return View(gameDetails);

     
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
