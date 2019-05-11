using FMS3.Data.Cache;
using FMS3.Data.Interfaces;
using FMS3.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace FMS3.Data.API
{
    public class NewsData : INewsData
    {
        private IWebApi _webApi { get; }
        private readonly string newsURL = "http://localhost:56822/api/news";

        public NewsData(IWebApi webApi)
        {
            _webApi = webApi;
        }

        public IEnumerable<News> GetGameNews(int seasonId = 0, int divisionId = 0)
        {
            var paramList = new Dictionary<string, object>
                {
                    {"gameDetailsId", GameCache.GameDetailsId}
                };
            if (seasonId > 0)
            {
                paramList.Add("seasonId", seasonId);

                if (divisionId > 0)
                {
                    paramList.Add("divisionId", divisionId);
                }
            }

            var response = _webApi.GetAll(newsURL, paramList);
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

        public IEnumerable<News> GetTeamNews(int teamId)
        {
            var paramList = new Dictionary<string, object>
                {
                    {"teamId", teamId}
                };

            var response = _webApi.GetAll(newsURL, paramList);

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
            var response = _webApi.GetById(newsURL, id);

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
