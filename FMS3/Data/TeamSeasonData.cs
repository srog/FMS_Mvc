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

        public int PromotionAndRelegation(int gameDetailsId, int oldSeasonId, int newSeasonId)
        {
            var response = _webApi.Post(teamSeasonURL, new { gameDetailsId, oldSeasonId, newSeasonId });

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<int>().Result;
            }
            else
            {
                var testerror = response;
            }
            return 0;


            //foreach (object division in Enum.GetValues(typeof(DivisionEnum)))
            //{
            //    var divisionId = division.GetHashCode();
            //    var teamSeasons = GetLeague(divisionId);
            //    //Recalculate ?

            //    // promotion
            //    if (divisionId != 1)
            //    {
            //        foreach()
            //    }


            //    // relegation
            //    if (divisionId != 4)
            //    {

            //    }
            //}
        }

    }
}
