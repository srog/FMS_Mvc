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
            if (GlobalData.GameDetailsId == 0)
            {
                return View(new List<Player>());
            }

            var playerList = _playerData.GetAllPlayers();

            return View(playerList);
        }
    }
}
