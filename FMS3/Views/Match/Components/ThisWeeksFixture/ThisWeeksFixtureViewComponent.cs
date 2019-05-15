using FMS3.Data.Cache;
using FMS3.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMS3.Views.Match.Components.ThisWeeksFixture
{
    public class ThisWeeksFixtureViewComponent : ViewComponent
    {
        private readonly IMatchData _matchData;
        private readonly IGameDetailsData _gameData;
        private readonly ITeamData _teamData;

        public ThisWeeksFixtureViewComponent(IMatchData matchData, IGameDetailsData gameData, ITeamData teamData)
        {
            _matchData = matchData;
            _gameData = gameData;
            _teamData = teamData;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var game = _gameData.GetById(GameCache.GameDetailsId);
            var team = _teamData.GetTeam(game.TeamId);
            var match = _matchData.GetThisWeeksMatch(team.DivisionId, team.Id, game.CurrentWeek);
            
            return View("ThisWeeksFixture", match);
        }
    }
}
