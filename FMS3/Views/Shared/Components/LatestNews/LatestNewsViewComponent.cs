using FMS3.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMS3.Views.Shared.Components.LatestNews
{
    public class LatestNewsViewComponent : ViewComponent
    {
        private readonly NewsData _newsData = new NewsData();
        
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var newsList = _newsData.GetLatestNews();
            return View("LatestNews", newsList);
        }
    }
}
