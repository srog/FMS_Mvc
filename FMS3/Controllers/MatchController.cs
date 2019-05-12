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
            //var matches = _matchData.GetAllMatches();
         
            return View("Index", 1);
        }

        public IActionResult PlayMatch(int id)
        {
            _matchData.PlayMatch(id);
            return Index();
        }

    }
}
