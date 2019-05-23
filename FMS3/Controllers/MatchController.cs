﻿using System;
using System.Linq;
using FMS3.Data.Cache;
using FMS3.Models;
using FMS3.Services.Interfaces;
using FMS3.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FMS3.Controllers
{
    public class MatchController : Controller
    {
        private readonly IMatchService _matchService;
        private readonly IMatchEventService _matchEventService;
        private readonly IMatchGoalService _matchGoalService;
        private readonly ITeamSeasonService _teamSeasonService;

        public MatchController(IMatchService matchService, 
            IMatchEventService matchEventService, 
            IMatchGoalService matchGoalService,
            ITeamSeasonService teamSeasonService)
        {
            _matchService = matchService;
            _matchEventService = matchEventService;
            _matchGoalService = matchGoalService;
            _teamSeasonService = teamSeasonService;
        }
        public IActionResult Index()
        {
            return WeeklyFixtures(new FixtureInfo { SelectedWeek = GameCache.CurrentWeek.ToString() });
        }

        public IActionResult ThisWeeksFixtures()
        {
            var fixtureInfo = new FixtureInfo
            {
                CurrentWeek = GameCache.CurrentWeek,
                SelectedWeek = GameCache.CurrentWeek.ToString()
            };
            return WeeklyFixtures(fixtureInfo);
        }
        public IActionResult WeeklyFixtures(FixtureInfo fixtureInfo)
        {
            fixtureInfo.Week = Int32.Parse(fixtureInfo.SelectedWeek);
            fixtureInfo.WeekString = Utilities.Utilities.GetWeekDisplay(fixtureInfo.Week);
            fixtureInfo.CurrentWeek = GameCache.CurrentWeek;
            for (var index = 0; index <= GameCache.NumberOfWeeksInSeason + 1; index++)
            {
                var weekString = Utilities.Utilities.GetWeekDisplay(index);
                fixtureInfo.WeekList.Add(new SelectListItem(weekString, index.ToString(), index == fixtureInfo.Week));
            }
            return View("Index", fixtureInfo);
        }

        public IActionResult TeamFixtures(int teamId, int? divisionId = null)
        {
            var matches = _matchService.GetAll(new Match {DivisionId = divisionId})
                .Where(m => m.HomeTeamId == teamId || m.AwayTeamId == teamId);

            return View("Matches", matches);
        }

        public IActionResult PlayMatch(int id)
        {
            _matchService.PlayMatch(id);
            return Index();
        }

        public IActionResult MatchDetail(int id)
        {
            var matchDetail = new MatchDetail();
            matchDetail.Match = _matchService.Get(id);
            matchDetail.Events = _matchEventService.GetForMatch(id).OrderBy(e => e.Minute);
            matchDetail.Goals = _matchGoalService.GetForMatch(id).OrderBy(g => g.Minute);

            return View(matchDetail);
        }

        public IActionResult PlayAllMatches(int seasonId, int week, int? divisionId = null)
        {
            if (divisionId == null)
            {
                _matchService.PlayAllMatchesForWeek(seasonId, week);
                4.TimesWithIndex((div) => _teamSeasonService.RecalculateAll(seasonId, div+1));
            }
            else
            {
                _matchService.PlayAllMatchesForDivision(seasonId, week, divisionId.Value);
                // Note - assuming everyone plays every week - no need to recalc all if not. 
                _teamSeasonService.RecalculateAll(seasonId, divisionId.Value);
            }

            return Index();
        }
    }
}
