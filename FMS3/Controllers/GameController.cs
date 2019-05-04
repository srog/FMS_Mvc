using FMS3.Data;
using FMS3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FMS3.Controllers
{
    public class GameController : Controller
    {
        private readonly GameDetailsData _gameDetailsData = new GameDetailsData();

        public IActionResult Start(int id)
        {
            GlobalData.GameDetailsId = id;
            var game = _gameDetailsData.GetGameDetails(GlobalData.GameDetailsId);

            SetUpGlobalData(game);

            return View("Index", game);
        }

        private void SetUpGlobalData(GameDetails game)
        {
            GlobalData.CurrentSeasonId = game.CurrentSeasonId;

            var _teamData = new TeamData();
            GlobalData.GameTeamIdList = _teamData.GetAllTeams(game.Id).Select(t => t.Id);
        }

        public IActionResult Index()
        {
            var game = _gameDetailsData.GetGameDetails(GlobalData.GameDetailsId);
            return View(game);
        }
    }
}
