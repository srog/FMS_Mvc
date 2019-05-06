using FMS3.Data;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Controllers
{
    public class LeagueController : Controller
    {
        private readonly TeamSeasonData _teamSeasonData = new TeamSeasonData();

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
