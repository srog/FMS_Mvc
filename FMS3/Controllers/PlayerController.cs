using FMS3.Data;
using FMS3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FMS3.Controllers
{
    public class PlayerController : Controller
    {
        private readonly PlayerData _playerData = new PlayerData();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int playerId)
        {
            var player = _playerData.GetPlayer(playerId);
            return View(player);
        }
    }
}
