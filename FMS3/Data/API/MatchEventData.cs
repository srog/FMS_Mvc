using System.Collections.Generic;
using System.Net.Http;
using FMS3.Data.Interfaces;
using FMS3.Models;

namespace FMS3.Data.API
{
    public class MatchEventData : IMatchEventData
    {
        private IWebApi _webApi { get; }
        private readonly string matchEventURL = "http://localhost:56822/api/MatchEvent";

        public MatchEventData(IWebApi webApi)
        {
            _webApi = webApi;
        }

        public IEnumerable<MatchEvent> GetAllForMatch(int matchId)
        {
            var response = _webApi.GetAll(matchEventURL, new Dictionary<string, object> { { "matchId", matchId } });

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<MatchEvent>>().Result;
            }
            else
            {
                var testerror = response;
            }
            return null;
        }
    }
}