using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FMS3.Services.Interfaces;

namespace FMS3.Views.Match.Components.MatchGoalDisplay
{
    public class MatchGoalDisplayViewComponent : ViewComponent
    {
        private IMatchGoalService _matchGoalService { get; }
        private IPlayerService _playerService { get; }
        public MatchGoalDisplayViewComponent(IMatchGoalService matchGoalService, IPlayerService playerService)
        {
            _matchGoalService = matchGoalService;
            _playerService = playerService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int matchId, int teamId)
        {
            var goals = _matchGoalService.GetForMatch(matchId);
            var displayString = "";

            if (goals.Count > 0)
            {
                foreach (var goal in goals)
                {
                    if (goal.TeamId == teamId)
                    {
                        displayString += _playerService.GetPlayerShortName(goal.PlayerId) + " (" + goal.Minute + ") ";
                    }
                }
            }
            return View("MatchGoalDisplay", displayString);
        }

    }
}
