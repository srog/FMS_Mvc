using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FMS3.Views.Shared.ViewComponents.TeamName
{
    public class TeamNameViewComponent : ViewComponent
    {
        private readonly FmsService.FmsServiceClient _fmsService;

        public TeamNameViewComponent(FmsService.FmsServiceClient fmsServiceClient)
        {
            _fmsService = fmsServiceClient;
        }

        public async Task<IViewComponentResult> InvokeAsync(int teamId)
        {
            var teamName = teamId == 0 ? "Free Agent" :  _fmsService.GetTeamAsync(teamId).Result.Name;
            return View("Default", teamName);
        }
    }
}
