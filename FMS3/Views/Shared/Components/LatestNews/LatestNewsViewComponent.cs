using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMS3.Views.Shared.Components.LatestNews
{
    public class LatestNewsViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var newsList = new List<FMS3.Models.News>();
            return View("LatestNews", newsList);
        }
    }
}
