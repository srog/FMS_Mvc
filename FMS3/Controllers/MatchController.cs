using FMS3.Data;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Controllers
{
    public class MatchController : Controller
    {
        private readonly MatchData _matchData = new MatchData();

        public IActionResult Index()
        {
            var matches = _matchData.GetAllMatches(1, 1);
         
            return View("Matches",matches);
        }

    }
}
