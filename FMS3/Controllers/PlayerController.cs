using FMS3.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Controllers
{
    public class PlayerController : Controller
    {
        private IPlayerData _playerData { get; }
        public PlayerController(IPlayerData playerData)
        {
            _playerData = playerData;
        }

        // All players in game
        public IActionResult Index()
        {
            var playerListDisplay = _playerData.GetAllPlayers();

            return View(playerListDisplay);
        }

        // Players with TeamId = 0
        public IActionResult TransferMarket()
        {
            var playerListDisplay = _playerData.GetAllPlayers(0);

            return View("Index", playerListDisplay);
        }

        // Players in team
        public IActionResult Squad(int teamId)
        {
            var playerListDisplay = _playerData.GetAllPlayers(teamId);

            return View("Index", playerListDisplay);
        }

        public IActionResult Details(int playerId)
        {
            var player = _playerData.GetPlayer(playerId);
            return View(player);
        }
    }
}
