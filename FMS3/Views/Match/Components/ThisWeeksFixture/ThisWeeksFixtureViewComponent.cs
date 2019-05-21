using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
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

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var match = _matchService.GetThisWeeksForManagedTeam();
            
            return View("ThisWeeksFixture", match);
        }
    }
}
