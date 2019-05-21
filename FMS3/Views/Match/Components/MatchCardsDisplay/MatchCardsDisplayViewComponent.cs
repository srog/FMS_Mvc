using System.Threading.Tasks;
using FMS3.Enums;
using FMS3.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Views.Match.Components.MatchCardsDisplay
{
    public class MatchCardsDisplayViewComponent : ViewComponent
    {
        private IMatchEventService _matchEventService { get; }
        private IPlayerService _playerService { get; }
        public MatchCardsDisplayViewComponent(IMatchEventService matchEventService, IPlayerService playerService)
        {
            _matchEventService = matchEventService;
            _playerService = playerService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int matchId, int teamId)
        {
            var matchEvents = _matchEventService.GetForMatch(matchId);
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
                    displayString += "RED:" + _playerService.GetPlayerShortName(matchEvent.PlayerId) + " (" + matchEvent.Minute + "). ";
                }
            }
            displayString += (yellows + " Yellow Cards");

            return View("MatchCardsDisplay", displayString);
        }
    }
}
