using FMS3.Data.Cache;
using FMS3.Data.Interfaces;
using FMS3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FMS3.Controllers
{
    public class TeamController : Controller
    {
        private ITeamData _teamData { get; }

        public TeamController(ITeamData teamData)
        {
            _teamData = teamData;
        }

        public IActionResult Index()
        {
            if (GameCache.GameDetailsId == 0)
            {
                return View(new List<Team>());
            }
            var teamList = _teamData.GetAllTeams();
            return View(teamList);
        }

        public IActionResult TeamDetails(int id)
        { 
            if (id == 0)
            {
                return RedirectToAction("TransferMarket", "Player");
            }
            var team = _teamData.GetTeam(id);
            return View(team);
        }

        public IActionResult Squad(int teamId)
        {
            return View(teamId);
        }
    }
}