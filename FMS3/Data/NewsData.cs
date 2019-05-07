﻿using FMS3.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace FMS3.Data
{
    public class NewsData
    {
        private readonly IWebApi _webApi;
        private readonly string newsURL = "http://localhost:56822/api/news";

        public NewsData()
        {
            if (_webApi == null)
            {
                _webApi = new WebApi();
            }
        }

        public IEnumerable<News> GetLatestNews()
        {
            var response = _webApi.GetBySeasonId(newsURL, GlobalData.CurrentSeasonId);
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<News>>().Result;
            }
            else
            {
                var testerror = response;
            }
            return null;
        }

        public News GetNews(int id)
        {
            var response = _webApi.Get(newsURL, id);

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<News>().Result;
            }
            else
            {
                var testerror = response;
            }
            return null;
        }


        public int AddNews(News news)
        {
            var response = _webApi.Post(newsURL, news);

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<int>().Result;
            }
            else
            {
                var testerror = response;
            }
            return 0;
        }

    }
}
