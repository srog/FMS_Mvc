using FMS3.Data;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Controllers
{
    public class PlayerController : Controller
    {
        private readonly PlayerData _playerData = new PlayerData();

        // All players in game
        public IActionResult Index()
        {
            var playerList = _playerData.GetAllPlayersInGame();

            return View(playerList);
        }

        // Players with TeamId = 0
        public IActionResult TransferMarket()
        {
            var playerList = _playerData.GetPlayersForTeam(0);

            return View("Index",playerList);
        }

        // Players in team
        public IActionResult Squad(int teamId)
        {
            var playerList = _playerData.GetPlayersForTeam(teamId);

            return View("Index",playerList);
        }

        public IActionResult Details(int playerId)
        {
            var player = _playerData.GetPlayer(playerId);
            return View(player);
        }
    }
}
