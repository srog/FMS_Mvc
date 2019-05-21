using FMS3.Data.Cache;
using FMS3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using FMS3.Services.Interfaces;

namespace FMS3.Controllers
{
    public class TeamController : Controller
    {
        private ITeamService _teamService { get; }

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            if (GameCache.GameDetailsId == 0)
            {
                return View(new List<Team>());
            }
            var teamList = _teamService.GetTeamsForGame();
            return View(teamList);
        }

        public IActionResult TeamDetails(int id)
        { 
            if (id == 0)
            {
                return RedirectToAction("TransferMarket", "Player");
            }
            var team = _teamService.Get(id);
            return View(team);
        }

        public IActionResult Squad(int teamId)
        {
            return View(teamId);
        }
    }
}