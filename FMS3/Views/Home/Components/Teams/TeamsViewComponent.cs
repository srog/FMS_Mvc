using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FMS3.Services.Interfaces;

namespace FMS3.ViewComponents
{
    public class TeamsViewComponent : ViewComponent
    {
        private ITeamService _teamService { get; }
        public TeamsViewComponent(ITeamService teamService)
        {
            _teamService = teamService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var teamList = _teamService.GetTeamsForGame();
      
            return View("TeamSelect",teamList);
        }

    }
}
