using System.Linq;
using FMS3.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FMS3.Views.Match.Components.MatchGoalDisplay
{
    public class MatchGoalDisplayViewComponent : ViewComponent
    {
        private IMatchGoalData _matchGoalData { get; }
        private IPlayerData _playerData { get; }
        public MatchGoalDisplayViewComponent(IMatchGoalData matchGoalData, IPlayerData playerData)
        {
            _matchGoalData = matchGoalData;
            _playerData = playerData;
        }

        public async Task<IViewComponentResult> InvokeAsync(int matchId, int teamId)
        {
            var goals = _matchGoalData.GetAllForMatch(matchId);
            var displayString = "";

            if (goals.Count() > 0)
            {
                foreach (var goal in goals)
                {
                    if (goal.TeamId == teamId)
                    {
                        displayString += _playerData.GetPlayerShortName(goal.PlayerId) + " (" + goal.Minute + ") ";
                    }
                }
            }
            return View("MatchGoalDisplay", displayString);
        }

    }
}
