using FMS3.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FMS3.Views.Team.Components.SquadSummary
{
    public class SquadSummaryViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int teamId)
        {
            var playerData = new PlayerData();
            var playerList = playerData.GetPlayersForTeam(teamId);

            return View("SquadSummary", playerList);
        }
    }
}
