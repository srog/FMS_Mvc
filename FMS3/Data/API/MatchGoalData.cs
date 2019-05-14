using System.Collections.Generic;
using System.Net.Http;
using FMS3.Data.Interfaces;
using FMS3.Models;

namespace FMS3.Data.API
{
    public class MatchGoalData : IMatchGoalData
    {
        private IWebApi _webApi { get; }
        private readonly string matchGoalURL = "http://localhost:56822/api/MatchGoal";

        public MatchGoalData(IWebApi webApi)
        {
            _webApi = webApi;
        }

        public IEnumerable<MatchGoal> GetAllForMatch(int matchId)
        {
            var response = _webApi.GetAll(matchGoalURL, new Dictionary<string, object>() {{ "matchId", matchId }});

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<MatchGoal>>().Result;
            }
            else
            {
                var testerror = response;
            }
            return null;
        }

    }
}