using FMS3.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Controllers
{
    public class MatchController : Controller
    {
        private IMatchData _matchData { get; }

        public MatchController(IMatchData matchData)
        {
            _matchData = matchData;
        }
        public IActionResult Index()
        {
            var matches = _matchData.GetAllMatches(1, 1);
         
            return View("Matches",matches);
        }

    }
}
