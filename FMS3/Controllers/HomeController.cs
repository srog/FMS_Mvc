using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FMS3.Models;
using FMS3.Data;

namespace FMS3.Controllers
{
    public class HomeController : Controller
    {
        private readonly GameDetailsData _gameDetailsData = new GameDetailsData();
        private readonly NewsData _newsData = new NewsData();
      

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewGame()
        {            
            GlobalData.GameDetailsId = _gameDetailsData.StartNewGame();
            return View();
        }

        public IActionResult LoadGame()
        {
            var games = _gameDetailsData.GetAllGameDetails();
            return View(games);
        }

        public IActionResult SelectManager(string managerName)
        {
            var game = _gameDetailsData.SetManagerName(managerName);
            GlobalData.CurrentSeasonId = game.CurrentSeasonId;

            var _teamQuery = new TeamData();
            var team = _teamQuery.GetTeam(game.TeamId);
            var newsText = managerName + " has become manager of " + team.Name;

            _newsData.AddNews(new News
            {
                TeamId = team.Id,
                GameDetailsId = GlobalData.GameDetailsId,
                SeasonId = GlobalData.CurrentSeasonId,
                NewsText = newsText
            });

            return View("StartGame",game);
        }

        public IActionResult SelectTeam(int teamId)
        {
            var game = _gameDetailsData.GetGameDetails(GlobalData.GameDetailsId);
            game.TeamId = teamId;

            _gameDetailsData.UpdateGameDetails(game);

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
