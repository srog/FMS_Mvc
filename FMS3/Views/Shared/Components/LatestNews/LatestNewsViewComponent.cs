using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using FMS3.Services.Interfaces;

namespace FMS3.Views.Shared.Components.LatestNews
{
    public class LatestNewsViewComponent : ViewComponent
    {
        private INewsService _newsService { get; }

        public LatestNewsViewComponent(INewsService newsService)
        {
            _newsService = newsService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var newsList = _newsService.GetForGame().Take(5); // TODO - set this somewhere
            return View("LatestNews", newsList);
        }
    }
}
