
using FmsService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FMS3.Controllers
{
    public class TeamController : Controller
    {
        private static FmsService.FmsServiceClient _fmsServiceClient = new FmsService.FmsServiceClient();

        public IActionResult Index()
        {
            var teamList = _fmsServiceClient.GetAllTeamsAsync().Result;

            return View(teamList);
        }

        public IActionResult TeamDetails(int id)
        {
            var team = _fmsServiceClient.GetTeamAsync(id).Result;
            return View(team);
        }


        public IEnumerable<Team> GetAllTeams()
        {
            return _fmsServiceClient.GetAllTeamsAsync().Result;
        }

    }
}