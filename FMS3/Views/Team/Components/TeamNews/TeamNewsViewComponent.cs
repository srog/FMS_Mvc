using FMS3.Data;
using FMS3.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace FMS3.Views.Team.Components.TeamNews
{
    public class TeamNewsViewComponent : ViewComponent
    {
        private INewsData _newsData { get; }

        public TeamNewsViewComponent(INewsData newsData)
        {
            _newsData = newsData;
        }
        public async Task<IViewComponentResult> InvokeAsync(int teamId)
        {
            var newsList = _newsData.GetTeamNews(teamId).Take(5); // TODO - set this somewhere
            return View("TeamNews", newsList);
        }
    }
}
