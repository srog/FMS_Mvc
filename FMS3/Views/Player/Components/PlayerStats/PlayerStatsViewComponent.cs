using FMS3.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FMS3.Views.Player.Components.PlayerStats
{
    public class PlayerStatsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int playerId)
        {
            var playerStatsData = new PlayerStatsData();
            var stats = playerStatsData.GetPlayerStats(playerId);

            return View("PlayerStats", stats);
        }
    }
}
