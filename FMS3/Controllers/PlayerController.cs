using FMS3.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Controllers
{
    public class PlayerController : Controller
    {
        private IPlayerService _playerService { get; }
        public PlayerController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        // All players in game
        public IActionResult Index()
        {
            var playerListDisplay = _playerService.GetAllPlayers();

            return View(playerListDisplay);
        }

        // Players with TeamId = 0
        public IActionResult TransferMarket()
        {
            var playerListDisplay = _playerService.GetAllPlayers(0);

            return View("Index", playerListDisplay);
        }

        // Players in team
        public IActionResult Squad(int teamId)
        {
            var playerListDisplay = _playerService.GetAllPlayers(teamId);

            return View("Index", playerListDisplay);
        }

        public IActionResult Details(int playerId)
        {
            var player = _playerService.Get(playerId);
            return View(player);
        }
    }
}
