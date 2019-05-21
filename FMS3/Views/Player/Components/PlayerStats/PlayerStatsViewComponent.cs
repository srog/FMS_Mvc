using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FMS3.Services.Interfaces;

namespace FMS3.Views.Player.Components.PlayerStats
{
    public class PlayerStatsViewComponent : ViewComponent
    {
        private IPlayerStatsService _playerStatsService { get; }
        public PlayerStatsViewComponent(IPlayerStatsService playerStatsService)
        {
            _playerStatsService = playerStatsService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int playerId)
        {
            var stats = _playerStatsService.Get(playerId);

            return View("PlayerStats", stats);
        }
    }
}
