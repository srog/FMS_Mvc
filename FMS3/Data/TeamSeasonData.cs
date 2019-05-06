
using FMS3.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace FMS3.Data
{
    public class TeamSeasonData
    {
        private readonly IWebApi _webApi;
        private readonly string teamSeasonURL = "http://localhost:56822/api/league";

        public TeamSeasonData()
        {
            if (_webApi == null)
            {
                _webApi = new WebApi();
            }
        }

        public IEnumerable<TeamSeason> GetLeague(int divisionId)
        {           
            var response = _webApi.Get(teamSeasonURL + "/" + GlobalData.GameDetailsId + "/" + GlobalData.CurrentSeasonId + "?divisionid=" + divisionId);
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<TeamSeason>>().Result;
            }
            else
            {
                var testerror = response;
            }
            return null;
        }

    }
}
