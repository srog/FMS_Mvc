using FMS3.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FMS3.Views.Shared.ViewComponents.TeamName
{
    public class TeamNameViewComponent : ViewComponent
    {
        private static TeamData _teamData = new TeamData();

        public async Task<IViewComponentResult> InvokeAsync(int teamId)
        {
            var teamName = teamId == 0 ? "Free Agent" :  _teamData.GetTeam(teamId).Name;
            return View("Default", teamName);
        }
    }
}
