using FMS3.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FMS3.Views.Shared.Components.TeamSummary
{
    public class TeamSummaryViewComponent : ViewComponent
    {
        private static TeamData _teamData = new TeamData();

        public async Task<IViewComponentResult> InvokeAsync(int teamId)
        {
            var team = _teamData.GetTeam(teamId);
            return View("TeamSummary", team);
        }
    }
}
