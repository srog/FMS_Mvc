using FMS3.Data;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Controllers
{
    public class TeamController : Controller
    {
        private static readonly TeamData _teamData = new TeamData();

        public IActionResult Index()
        {
            var teamList = _teamData.GetAllTeams();
            return View(teamList);
        }

        public IActionResult TeamDetails(int id)
        {
            var team = _teamData.GetTeam(id);
            return View(team);
        }

    }
}