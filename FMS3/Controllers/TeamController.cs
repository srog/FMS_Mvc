using FMS3.Data;
using FMS3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FMS3.Controllers
{
    public class TeamController : Controller
    {
        private static readonly TeamData _teamData = new TeamData();

        public IActionResult Index()
        {
            if (GlobalData.GameDetailsId == 0)
            {
                return View(new List<Team>());
            }
            var teamList = _teamData.GetAllTeams(GlobalData.GameDetailsId);
            return View(teamList.Select(t => t.GameDetailsId == GlobalData.GameDetailsId));
        }

        public IActionResult TeamDetails(int id)
        {
            var team = _teamData.GetTeam(id);
            return View(team);
        }

    }
}