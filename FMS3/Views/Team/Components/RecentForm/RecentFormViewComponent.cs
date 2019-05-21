using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FMS3.Services.Interfaces;

namespace FMS3.Views.Team.Components.RecentForm
{
    public class RecentFormViewComponent : ViewComponent
    {
        private readonly IMatchService _matchService;
        public RecentFormViewComponent(IMatchService matchService)
        {
            _matchService = matchService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int teamId)
        {
            var matches = _matchService.GetForm(teamId);
            var displayString = "";
            foreach (var match in matches)
            {
                if ((match.HomeTeamId == teamId && match.HomeTeamScore > match.AwayTeamScore) ||
                    (match.AwayTeamId == teamId && match.HomeTeamScore < match.AwayTeamScore))
                {
                    displayString += "W ";
                }
                else
                {
                    if ((match.HomeTeamId == teamId && match.HomeTeamScore < match.AwayTeamScore) ||
                        (match.AwayTeamId == teamId && match.HomeTeamScore > match.AwayTeamScore))
                    {
                        displayString += "L ";
                    }
                    else
                    {
                        displayString += "D ";
                    }
                }
            }
            return View("RecentForm", displayString);
        }
    }
}
