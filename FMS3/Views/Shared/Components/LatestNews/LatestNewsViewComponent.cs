using FMS3.Data;
using FMS3.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace FMS3.Views.Shared.Components.LatestNews
{
    public class LatestNewsViewComponent : ViewComponent
    {
        private INewsData _newsData { get; }

        public LatestNewsViewComponent(INewsData newsData)
        {
            _newsData = newsData;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var newsList = _newsData.GetGameNews().Take(5); // TODO - set this somewhere
            return View("LatestNews", newsList);
        }
    }
}
