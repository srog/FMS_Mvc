﻿using FMS3.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Controllers
{
    public class LeagueController : Controller
    {
        private ITeamSeasonData _teamSeasonData { get; }

        public LeagueController(ITeamSeasonData teamSeasonData)
        {
            _teamSeasonData = teamSeasonData;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Division(int id)
        {
            var teamSeasonList = _teamSeasonData.GetLeague(id);
            return View("League", teamSeasonList);
        }
    }
}
