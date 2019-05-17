using System;
using System.Linq;
using FMS3.Data.Cache;
using FMS3.Data.Interfaces;
using FMS3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FMS3.Controllers
{
    public class MatchController : Controller
    {
        private readonly IMatchData _matchData;
        private readonly IMatchEventData _matchEventData;
        private readonly IMatchGoalData _matchGoalData;
        private readonly IGameDetailsData _gameDetailsData;

        public MatchController(IMatchData matchData, 
            IMatchEventData matchEventData, 
            IMatchGoalData matchGoalData, 
            IGameDetailsData gameDetailsData)
        {
            _matchData = matchData;
            _matchEventData = matchEventData;
            _matchGoalData = matchGoalData;
            _gameDetailsData = gameDetailsData;
        }
        public IActionResult Index()
        {
            var game = _gameDetailsData.GetById(GameCache.GameDetailsId);

            return WeeklyFixtures(new FixtureInfo { SelectedWeek = game.CurrentWeek.ToString() });
        }

        public IActionResult ThisWeeksFixtures()
        {
            var game = _gameDetailsData.GetById(GameCache.GameDetailsId);

            var fixtureInfo = new FixtureInfo
            {
                CurrentWeek = game.CurrentWeek,
                SelectedWeek = game.CurrentWeek.ToString()
            };
            return WeeklyFixtures(fixtureInfo);
        }
        public IActionResult WeeklyFixtures(FixtureInfo fixtureInfo)
        {
            var game = _gameDetailsData.GetById(GameCache.GameDetailsId);
            fixtureInfo.Week = Int32.Parse(fixtureInfo.SelectedWeek);
            fixtureInfo.CurrentWeek = game.CurrentWeek;
            for (var index = 1; index <= GameCache.NumberOfWeeksInSeason; index++)
            {
                fixtureInfo.WeekList.Add(new SelectListItem("Week " + index, index.ToString(), index == fixtureInfo.Week));
            }
            return View("Index", fixtureInfo);
        }

        public IActionResult TeamFixtures(int teamId, int divisionId = 0)
        {
            var matches = _matchData.GetAllMatches(divisionId, -1).Where(m => m.HomeTeamId == teamId || m.AwayTeamId == teamId);

            return View("Matches", matches);
        }

        public IActionResult PlayMatch(int id)
        {
            _matchData.PlayMatch(id);
            return Index();
        }

        public IActionResult MatchDetail(int id)
        {
            var matchDetail = new MatchDetail();
            matchDetail.Match = _matchData.GetMatch(id);
            matchDetail.Events = _matchEventData.GetAllForMatch(id).OrderBy(e => e.Minute);
            matchDetail.Goals = _matchGoalData.GetAllForMatch(id).OrderBy(g => g.Minute);

            return View(matchDetail);
        }

        public IActionResult PlayAllMatches(int divisionId, int seasonId, int week)
        {
            _matchData.PlayAllMatchesForWeek(seasonId, week, divisionId);
            return Index();
        }

    }
}
