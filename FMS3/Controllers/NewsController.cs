using FMS3.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FMS3.Controllers
{
    public class NewsController : Controller
    {
        private INewsService _newsService { get; }

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        public IActionResult Index()
        {
            var news = _newsService.GetForGame();
            return View("News", news);
        }
    }
}
