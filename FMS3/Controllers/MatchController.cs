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
        private readonly IGameDetailsService _gameDetailsService;
        private readonly ITeamSeasonService _teamSeasonService;

        public MatchController(IMatchService matchService, 
            IMatchEventService matchEventService, 
            IMatchGoalService matchGoalService,
            IGameDetailsService gameDetailsService,
            ITeamSeasonService teamSeasonService)
        {
            _matchService = matchService;
            _matchEventService = matchEventService;
            _matchGoalService = matchGoalService;
            _gameDetailsService = gameDetailsService;
            _teamSeasonService = teamSeasonService;
        }
        public IActionResult Index()
        {

            return WeeklyFixtures(new FixtureInfo { SelectedWeek = _gameDetailsService.GetCurrentWeek().ToString() });
        }

        public IActionResult ThisWeeksFixtures()
        {
            var game = _gameDetailsService.GetCurrentGame();

            var fixtureInfo = new FixtureInfo
            {
                CurrentWeek = game.CurrentWeek,
                SelectedWeek = game.CurrentWeek.ToString()
            };
            return WeeklyFixtures(fixtureInfo);
        }
        public IActionResult WeeklyFixtures(FixtureInfo fixtureInfo)
        {
            fixtureInfo.Week = Int32.Parse(fixtureInfo.SelectedWeek);
            fixtureInfo.CurrentWeek = _gameDetailsService.GetCurrentWeek();
            for (var index = 1; index <= GameCache.NumberOfWeeksInSeason; index++)
            {
                fixtureInfo.WeekList.Add(new SelectListItem("Week " + index, index.ToString(), index == fixtureInfo.Week));
            }
            return View("Index", fixtureInfo);
        }

        public IActionResult TeamFixtures(int teamId, int divisionId = 0)
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

        public IActionResult PlayAllMatches(int divisionId, int seasonId, int week)
        {
            _matchService.PlayAllMatchesForDivision(seasonId, week, divisionId);

            // Note - assuming everyone plays every week - no need to recalc all if not. 
            _teamSeasonService.RecalculateAll(seasonId, divisionId);
            return Index();
        }

        public IActionResult PlayAllMatchesForWeek(int seasonId, int week)
        {
            _matchService.PlayAllMatchesForWeek(seasonId, week);

            // Note - assuming everyone plays every week - no need to recalc all if not. 
            4.TimesWithIndex((divisionId) => _teamSeasonService.RecalculateAll(seasonId, divisionId));

            return Index();
        }



    }
}
