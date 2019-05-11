using FMS3.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace FMS3.ViewComponents
{
    public class TeamsViewComponent : ViewComponent
    {
        private ITeamData _teamData { get; }
        public TeamsViewComponent(ITeamData teamData)
        {
            _teamData = teamData;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var teamList = _teamData.GetAllTeams();
      
            return View("TeamSelect",teamList);
        }

    }
}
