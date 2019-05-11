using FMS3.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FMS3.Views.Player.Components.PlayerStats
{
    public class PlayerStatsViewComponent : ViewComponent
    {
        private IPlayerStatsData _playerStatsData { get; }
        public PlayerStatsViewComponent(IPlayerStatsData playerStatsData)
        {
            _playerStatsData = playerStatsData;
        }
        public async Task<IViewComponentResult> InvokeAsync(int playerId)
        {
            var stats = _playerStatsData.GetPlayerStats(playerId);

            return View("PlayerStats", stats);
        }
    }
}
