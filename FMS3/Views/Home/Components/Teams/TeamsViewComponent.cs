using FMS3.Data;
using FMS3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FMS3.ViewComponents
{
    public class TeamsViewComponent : ViewComponent
    {
        private static TeamData _teamData = new TeamData();

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var teamList = _teamData.GetAllTeams(GlobalData.GameDetailsId);
      
            return View(teamList);
        }

    }
}
