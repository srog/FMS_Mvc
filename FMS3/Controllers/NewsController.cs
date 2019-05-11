using FMS3.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Controllers
{
    public class NewsController : Controller
    {
        private INewsData _newsData { get; }

        public NewsController(INewsData newsData)
        {
            _newsData = newsData;
        }

        public IActionResult Index()
        {
            var news = _newsData.GetGameNews();
            return View("News", news);
        }
    }
}
