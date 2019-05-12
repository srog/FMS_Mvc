using FMS3.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FMS3.Views.Match.Components.FixtureList
{
    public class FixtureListViewComponent : ViewComponent
    {
        private IMatchData _matchData { get; }
        public FixtureListViewComponent(IMatchData matchData)
        {
            _matchData = matchData;
        }
        public async Task<IViewComponentResult> InvokeAsync(int divisionId, int week)
        {
            var matchList = _matchData.GetAllMatches(divisionId, week);

            return View("FixtureList", matchList);
        }
    }
}
