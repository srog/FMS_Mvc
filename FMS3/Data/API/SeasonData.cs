using FMS3.Models;
using System.Collections.Generic;
using System.Net.Http;
using FMS3.Data.Interfaces;
using FMS3.Data.Cache;

namespace FMS3.Data.API
{
    public class SeasonData : ISeasonData
    {
        private IWebApi _webApi { get; }
        private readonly string seasonURL = "http://localhost:56822/api/season";

        public SeasonData(IWebApi webApi)
        {
            _webApi = webApi;
        }

        public int GetSeasonYear(int seasonId)
        {
            if (!GameCache.SeasonYear.ContainsKey(seasonId))
            {                
                GameCache.SeasonYear.Add(seasonId, GetSeason(seasonId).StartYear);
            }
            return GameCache.SeasonYear.GetValueOrDefault(seasonId);
        }

        public IEnumerable<Season> GetAllSeasons()
        {
            var paramList = new Dictionary<string, object>
            {
                {"gameDetailsId", GameCache.GameDetailsId}
            };

            var response = _webApi.GetAll(seasonURL, paramList);
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
            var response = _webApi.GetById(seasonURL, id);

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

        public int CompleteCurrentSeason()
        {
            var currentSeason = GetSeason(GameCache.CurrentSeasonId);
            currentSeason.Completed = true;
            UpdateSeason(currentSeason);

            return currentSeason.StartYear + 1;
        }
    }
}
