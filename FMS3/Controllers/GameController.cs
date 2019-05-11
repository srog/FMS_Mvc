using FMS3.Data;
using FMS3.Data.Cache;
using FMS3.Data.Interfaces;
using FMS3.Models;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Controllers
{
    public class GameController : Controller
    {
        private IGameDetailsData _gameDetailsData { get; }
        private ISeasonData _seasonData { get; }
        private ITeamSeasonData _teamSeasonData { get; }

        public GameController(IGameDetailsData gameDetailsData, ISeasonData seasonData, ITeamSeasonData teamSeasonData)
        {
            _gameDetailsData = gameDetailsData;
            _seasonData = seasonData;
            _teamSeasonData = teamSeasonData;
        }
        public IActionResult Start()
        {
            var game = _gameDetailsData.GetById(GameCache.GameDetailsId);

            return View("Index", game);
        }
               
        public IActionResult LoadGame(int id)
        {
            var game = _gameDetailsData.GetById(id);
            GameCache.GameDetailsId = id;
            GameCache.CurrentSeasonId = game.CurrentSeasonId;
         
            return View("Index", game);
        }

        public IActionResult Index()
        {
            if (GameCache.GameDetailsId == 0)
            {
                return RedirectToAction("Index", "Home");
            }

            var game = _gameDetailsData.GetById(GameCache.GameDetailsId);
            return View(game);
        }

        public IActionResult BeginSeason()
        {
            var game = _gameDetailsData.AdvanceWeek();
            return View("Index", game);
        }

        public IActionResult AdvanceWeek()
        {
            var game = _gameDetailsData.AdvanceWeek();
            return View("Index",game);
        }

        public IActionResult CompleteSeason()
        {
            var newYear = _seasonData.CompleteCurrentSeason();

            var newSeason = new Season {Completed = false, GameDetailsId = GameCache.GameDetailsId, StartYear = newYear };
            var newSeasonId = _seasonData.AddSeason(newSeason);

            _teamSeasonData.PromotionAndRelegation(GameCache.GameDetailsId, GameCache.CurrentSeasonId, newSeasonId);

            var game = _gameDetailsData.SetGameToNewSeason(newSeasonId);

            // set globals to new data
            GameCache.CurrentSeasonId = newSeasonId;

            return View("Index", game);
        }
    }
}
