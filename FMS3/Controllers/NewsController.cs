using FMS3.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMS3.Controllers
{
    public class NewsController : Controller
    {
        private readonly NewsData _newsData = new NewsData();

        public IActionResult Index()
        {
            var news = _newsData.GetLatestNews();
            return View("News", news);
        }

     
    }
}
