using FMS3.Data;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Controllers
{
    public class PlayerController : Controller
    {
        private readonly PlayerData _playerData = new PlayerData();

        public IActionResult Index()
        {
            var playerList = _playerData.GetAllPlayers();

            return View(playerList);
        }
    }
}
