using FMS3.Data.Cache;
using FMS3.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FMS3.Views.Match.Components.FixtureList
{
    public class FixtureListViewComponent : ViewComponent
    {
        private readonly IMatchData _matchData;
        private readonly IGameDetailsData _gameDetailsData;

        public FixtureListViewComponent(IMatchData matchData, IGameDetailsData gameDetailsData)
        {
            _matchData = matchData;
            _gameDetailsData = gameDetailsData;
        }
        public async Task<IViewComponentResult> InvokeAsync(int divisionId, int week)
        {
            var fixtureList = new Models.FixtureList();
            fixtureList.Fixtures = _matchData.GetAllMatches(divisionId, week);
            fixtureList.CurrentWeek = _gameDetailsData.GetById(GameCache.GameDetailsId).CurrentWeek;
            return View("FixtureList", fixtureList);
        }
    }
}
