using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FMS3.Services.Interfaces;

namespace FMS3.Views.Match.Components.ThisWeeksFixture
{
    public class ThisWeeksFixtureViewComponent : ViewComponent
    {
        private readonly IMatchService _matchService;
        private readonly IGameDetailsService _gameDetailsService;

        public ThisWeeksFixtureViewComponent(IMatchService matchService, IGameDetailsService gameDetailsService)
        {
            _matchService = matchService;
            _gameDetailsService = gameDetailsService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var week = _gameDetailsService.GetCurrentWeek();
            var match = _matchService.GetThisWeeksForManagedTeam(week);
            
            return View("ThisWeeksFixture", match);
        }
    }
}
