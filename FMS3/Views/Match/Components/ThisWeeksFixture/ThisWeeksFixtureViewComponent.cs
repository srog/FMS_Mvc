using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FMS3.Data.Cache;
using FMS3.Services.Interfaces;

namespace FMS3.Views.Match.Components.ThisWeeksFixture
{
    public class ThisWeeksFixtureViewComponent : ViewComponent
    {
        private readonly IMatchService _matchService;

        public ThisWeeksFixtureViewComponent(IMatchService matchService)
        {
            _matchService = matchService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int teamId = 0)
        {
            var week = GameCache.CurrentWeek;
            if (teamId == 0)
            {
                teamId = GameCache.ManagedTeamId;
            }
            var match = _matchService.GetThisWeeksFixture(teamId);
            
            return View("ThisWeeksFixture", match);
        }
    }
}
