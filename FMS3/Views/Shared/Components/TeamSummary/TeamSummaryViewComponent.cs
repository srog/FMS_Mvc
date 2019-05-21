using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FMS3.Services.Interfaces;

namespace FMS3.Views.Shared.Components.TeamSummary
{
    public class TeamSummaryViewComponent : ViewComponent
    {
        private ITeamService _teamService { get; }
        public TeamSummaryViewComponent(ITeamService teamService)
        {
            _teamService = teamService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int teamId)
        {
            var team = _teamService.Get(teamId);
            return View("TeamSummary", team);
        }
    }
}
