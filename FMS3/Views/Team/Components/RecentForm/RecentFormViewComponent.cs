using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

namespace FMS3.Views.Team.Components.RecentForm
{
    public class RecentFormViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int teamId)
        {
            //var matchData = new MatchData();
            //var matches = matchData.GetMatches(teamId);

            return View("RecentForm");
        }
    }
}
