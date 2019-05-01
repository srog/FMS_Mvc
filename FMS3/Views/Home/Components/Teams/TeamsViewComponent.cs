using FMS3.Data;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FMS3.ViewComponents
{
    public class TeamsViewComponent : ViewComponent
    {
        private static TeamData _teamData = new TeamData();

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var teams = _teamData.GetAllTeams();
            return View(teams);
        }

    }
}
