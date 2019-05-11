using FMS3.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FMS3.Views.Shared.Components.TeamSummary
{
    public class TeamSummaryViewComponent : ViewComponent
    {
        private ITeamData _teamData { get; }
        public TeamSummaryViewComponent(ITeamData teamData)
        {
            _teamData = teamData;
        }
        public async Task<IViewComponentResult> InvokeAsync(int teamId)
        {
            var team = _teamData.GetTeam(teamId);
            return View("TeamSummary", team);
        }
    }
}
