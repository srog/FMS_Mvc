using FMS3.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMS3.Controllers
{
    public class GameController : Controller
    {
        private readonly GameDetailsData _gameDetailsData = new GameDetailsData();

        public IActionResult Start(int id)
        {
            GlobalData.GameDetailsId = id;
            var game = _gameDetailsData.GetGameDetails(GlobalData.GameDetailsId);

            return View("Index", game);
        }

        public IActionResult Index()
        {
            var game = _gameDetailsData.GetGameDetails(GlobalData.GameDetailsId);
            return View(game);
        }
    }
}
