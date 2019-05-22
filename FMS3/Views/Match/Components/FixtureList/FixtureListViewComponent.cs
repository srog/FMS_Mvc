using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FMS3.Services.Interfaces;

namespace FMS3.Views.Match.Components.FixtureList
{
    public class FixtureListViewComponent : ViewComponent
    {
        private readonly IMatchService _matchService;
        private readonly IGameDetailsService _gameDetailsService;

        public FixtureListViewComponent(IMatchService matchService, 
            IGameDetailsService gameDetailsService)
        {
            _matchService = matchService;
            _gameDetailsService = gameDetailsService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int divisionId, int week)
        {
            var fixtureList = new Models.FixtureList();
            var game = _gameDetailsService.GetCurrentGame();
            fixtureList.Fixtures = _matchService.GetAll(new Models.Match
                {
                    GameDetailsId = game.Id,
                    SeasonId = game.CurrentSeasonId,
                    DivisionId = divisionId,
                    Week = week
                });
            fixtureList.CurrentWeek = game.CurrentWeek;
            return View("FixtureList", fixtureList);
        }
    }
}
