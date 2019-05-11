using FMS3.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FMS3.Views.Shared.ViewComponents.TeamName
{
    public class TeamNameViewComponent : ViewComponent
    {
        private ITeamData _teamData { get; }
        public TeamNameViewComponent(ITeamData teamData)
        {
            _teamData = teamData;
        }
        public async Task<IViewComponentResult> InvokeAsync(int teamId)
        {
            var team = new Models.Team
            {
                Id = teamId,
                Name = _teamData.GetTeamName(teamId)
            };
            
            return View("TeamName", team);
        }
    }
}
