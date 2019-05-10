using FMS3.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace FMS3.Data
{
    public class MatchData
    {
        private readonly IWebApi _webApi;
        private readonly string matchURL = "http://localhost:56822/api/match";

        public MatchData()
        {
            if (_webApi == null)
            {
                _webApi = new WebApi();
            }
        }

        public IEnumerable<Match> GetAllMatches(int divisionId = 0, int week = 0)
        {
            var paramList = new Dictionary<string, object>
                {
                    {"gameDetailsId", GlobalData.GameDetailsId},
                    {"seasonId", GlobalData.CurrentSeasonId}
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

    }
}
