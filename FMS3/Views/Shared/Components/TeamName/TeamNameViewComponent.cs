using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FMS3.Services.Interfaces;

namespace FMS3.Views.Shared.ViewComponents.TeamName
{
    public class TeamNameViewComponent : ViewComponent
    {
        private ITeamService _teamService { get; }
        public TeamNameViewComponent(ITeamService teamService)
        {
            _teamService = teamService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int teamId)
        {
            var team = new Models.Team
            {
                Id = teamId,
                Name = _teamService.GetTeamName(teamId)
            };
            
            return View("TeamName", team);
        }
    }
}
