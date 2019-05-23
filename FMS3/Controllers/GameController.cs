using FMS3.Data.Cache;
using FMS3.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameDetailsService _gameDetailsService;

        public GameController(IGameDetailsService gameDetailsService)
        {
            _gameDetailsService = gameDetailsService;
   
        }
        public IActionResult Start()
        {
            var game = _gameDetailsService.Get(GameCache.GameDetailsId);

            return View("Index", game);
        }
               
        public IActionResult LoadGame(int id)
        {
            var game = _gameDetailsService.LoadGame(id);
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
            var game = _gameDetailsService.CompleteCurrentSeason();
            return View("Index", game);
        }
    }
}
