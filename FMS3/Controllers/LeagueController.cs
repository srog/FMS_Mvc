using FMS3.Data.Cache;
using FMS3.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Controllers
{
    public class LeagueController : Controller
    {
        private ITeamSeasonService _teamSeasonService { get; }

        public LeagueController(ITeamSeasonService teamSeasonService)
        {
            _teamSeasonService = teamSeasonService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Division(int id)
        {
            var teamSeasonList = _teamSeasonService.GetByGameAndDivision(GameCache.GameDetailsId, id);
            return View("League", teamSeasonList);
        }
    }
}
