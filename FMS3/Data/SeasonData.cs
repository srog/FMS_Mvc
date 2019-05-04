﻿using FMS3.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace FMS3.Data
{
    public class SeasonData
    {
        private readonly IWebApi _webApi;
        private readonly string seasonURL = "http://localhost:56822/api/season";

        public SeasonData()
        {
            if (_webApi == null)
            {
                _webApi = new WebApi();
            }
        }

        public IEnumerable<Season> GetAllSeasons()
        {
            var response = _webApi.Get(seasonURL);
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<Models.Season>>().Result;
            }
            else
            {
                var testerror = response;
            }
            return null;
        }

        public Season GetSeason(int id)
        {
            var response = _webApi.Get(seasonURL, id);

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<Season>().Result;
            }
            else
            {
                var testerror = response;
            }
            return null;
        }

    
        public int AddSeason(Season season)
        {
            var response = _webApi.Post(seasonURL, season);

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

        public int UpdateSeason(Season season)
        {
            var response = _webApi.Put(seasonURL, season);

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
        public int DeleteSeason(int id)
        {
            var response = _webApi.Delete(seasonURL, id);
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<int>().Result;

            }
            else
            {
                return 0;
            }
        }
    }
}
