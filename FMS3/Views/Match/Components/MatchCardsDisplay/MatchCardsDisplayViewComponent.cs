using System.Threading.Tasks;
using FMS3.Data.Interfaces;
using FMS3.Enums;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Views.Match.Components.MatchCardsDisplay
{
    public class MatchCardsDisplayViewComponent : ViewComponent
    {
        private IMatchEventData _matchEventData { get; }
        private IPlayerData _playerData { get; }
        public MatchCardsDisplayViewComponent(IMatchEventData matchEventData, IPlayerData playerData)
        {
            _matchEventData = matchEventData;
            _playerData = playerData;
        }

        public async Task<IViewComponentResult> InvokeAsync(int matchId, int teamId)
        {
            var matchEvents = _matchEventData.GetAllForMatch(matchId);
            var displayString = "";
            var yellows = 0;

            foreach (var matchEvent in matchEvents)
            {
                if (matchEvent.EventType == MatchEventTypesEnum.YellowCard.GetHashCode() && matchEvent.TeamId == teamId)
                {
                    yellows++;
                }
                if (matchEvent.EventType == MatchEventTypesEnum.RedCard.GetHashCode() && matchEvent.TeamId == teamId)
                {
                    displayString += "RED:" + _playerData.GetPlayerShortName(matchEvent.PlayerId) + " (" + matchEvent.Minute + "). ";
                }
            }
            displayString += (yellows + " Yellow Cards");

            return View("MatchCardsDisplay", displayString);
        }
    }
}
