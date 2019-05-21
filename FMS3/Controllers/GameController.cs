using FMS3.Data.Cache;
using FMS3.Models;
using FMS3.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameDetailsService _gameDetailsService;

        private ISeasonService _seasonService { get; }
        private ITeamSeasonService _teamSeasonService { get; }

        public GameController(ISeasonService seasonService, ITeamSeasonService teamSeasonService, IGameDetailsService gameDetailsService)
        {
            _seasonService = seasonService;
            _teamSeasonService = teamSeasonService;
            _gameDetailsService = gameDetailsService;
        }
        public IActionResult Start()
        {
            var game = _gameDetailsService.Get(GameCache.GameDetailsId);

            return View("Index", game);
        }
               
        public IActionResult LoadGame(int id)
        {
            var game = _gameDetailsService.Get(id);
            GameCache.GameDetailsId = id;
            GameCache.CurrentSeasonId = game.CurrentSeasonId;
            GameCache.ManagedTeamId = game.TeamId;
            return View("Index", game);
        }

        public IActionResult Index()
        {
            if (GameCache.GameDetailsId == 0)
            {
                return RedirectToAction("Index", "Home");
            }

            var game = _gameDetailsService.Get(GameCache.GameDetailsId);
            return View(game);
        }

        public IActionResult BeginSeason()
        {
            var game = _gameDetailsService.AdvanceWeek();
            return View("Index", game);
        }

        public IActionResult AdvanceWeek()
        {
            var game = _gameDetailsService.AdvanceWeek();
            return View("Index",game);
        }

        public IActionResult CompleteSeason()
        {
            // TODO - _gameDetailsData.AdvanceSeason();

            var newYear = _seasonService.CompleteCurrentSeason();

            var newSeason = new Season {Completed = false, GameDetailsId = GameCache.GameDetailsId, StartYear = newYear };
            var newSeasonId = _seasonService.Add(newSeason);

            _teamSeasonService.PromotionAndRelegation(newSeasonId);

            var game = _gameDetailsService.SetGameToNewSeason(newSeasonId);

            // set globals to new data
            GameCache.CurrentSeasonId = newSeasonId;

            return View("Index", game);
        }
    }
}
