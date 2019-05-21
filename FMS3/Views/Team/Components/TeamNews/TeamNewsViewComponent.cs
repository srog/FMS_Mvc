using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using FMS3.Services.Interfaces;

namespace FMS3.Views.Team.Components.TeamNews
{
    public class TeamNewsViewComponent : ViewComponent
    {
        private INewsService _newsService { get; }

        public TeamNewsViewComponent(INewsService newsService)
        {
            _newsService = newsService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int teamId)
        {
            var newsList = _newsService.GetForTeam(teamId).Take(5); // TODO - set this somewhere
            return View("TeamNews", newsList);
        }
    }
}
