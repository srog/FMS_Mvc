using FMS3.Data;
using FMS3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FMS3.Controllers
{
    public class GameController : Controller
    {
        private readonly GameDetailsData _gameDetailsData = new GameDetailsData();

        public IActionResult Start()
        {
            var game = _gameDetailsData.GetGameDetails(GlobalData.GameDetailsId);

            return View("Index", game);
        }
               
        public IActionResult LoadGame(int id)
        {
            var game = _gameDetailsData.GetGameDetails(id);
            GlobalData.GameDetailsId = id;
            GlobalData.CurrentSeasonId = game.CurrentSeasonId;
            return View("Index", game);
        }

        public IActionResult Index()
        {
            if (GlobalData.GameDetailsId == 0)
            {
                return RedirectToAction("Index", "Home");
            }

            var game = _gameDetailsData.GetGameDetails(GlobalData.GameDetailsId);
            return View(game);
        }
    }
}
