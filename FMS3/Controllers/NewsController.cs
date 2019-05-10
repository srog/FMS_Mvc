using FMS3.Data;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Controllers
{
    public class NewsController : Controller
    {
        private readonly NewsData _newsData = new NewsData();

        public IActionResult Index()
        {
            var news = _newsData.GetGameNews();
            return View("News", news);
        }
    }
}
