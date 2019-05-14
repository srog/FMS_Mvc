using FMS3.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

namespace FMS3.Views.Team.Components.RecentForm
{
    public class RecentFormViewComponent : ViewComponent
    {
        private readonly IMatchData _matchData;
        public RecentFormViewComponent(IMatchData matchData)
        {
            _matchData = matchData;
        }
        public async Task<IViewComponentResult> InvokeAsync(int teamId)
        {
            var matches = _matchData.GetForm(teamId);
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
