using FMS3.Data.Cache;
using FMS3.Data.Interfaces;
using FMS3.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace FMS3.Data.API
{
    public class MatchData : IMatchData
    {
        private IWebApi _webApi { get; }
        private readonly string matchURL = "http://localhost:56822/api/match";

        public MatchData(IWebApi webApi)
        {
            _webApi = webApi;
        }

        public IEnumerable<Match> GetAllMatches(int divisionId = 0, int week = 0)
        {
            var paramList = new Dictionary<string, object>
                {
                    {"gameDetailsId", GameCache.GameDetailsId},
                    {"seasonId", GameCache.CurrentSeasonId}
                };
            if (divisionId > 0)
            {
                paramList.Add("divisionId", divisionId);

                if (week > 0)
                {
                    paramList.Add("week", week);
                }
            }

            var response = _webApi.GetAll(matchURL, paramList);

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<Match>>().Result;
            }
            else
            {
                var testerror = response;
            }
            return null;
        }


        public Match GetMatch(int id)
        {
            var response = _webApi.GetById(matchURL, id);

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<Match>().Result;
            }
            else
            {
                var testerror = response;
            }
            return null;
        }

        public int AddMatch(Match match)
        {
            var response = _webApi.Post(matchURL, match);

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

        public int PlayMatch(int id)
        {
            var response = _webApi.Put(matchURL + "/" + id, null);

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

        public int PlayAllMatchesForWeek(int seasonId, int week, int divisionId)
        {
            var actualUrl = matchURL + "/" + seasonId + "/" + week + "/" + divisionId;

            var response = _webApi.Put(actualUrl, null);

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

        public int UpdateMatch(Match match)
        {
            var response = _webApi.Put(matchURL, match);

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
