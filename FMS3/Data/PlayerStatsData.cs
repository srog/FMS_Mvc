using FMS3.Models;
using System.Net.Http;

namespace FMS3.Data
{
    public class PlayerStatsData
    {
        private readonly IWebApi _webApi;
        private readonly string playerStatsURL = "http://localhost:56822/api/playerStats";

        public PlayerStatsData()
        {
            if (_webApi == null)
            {
                _webApi = new WebApi();
            }
        }

        public PlayerStats GetPlayerStats(int playerId)
        {
            var response = _webApi.GetById(playerStatsURL, playerId);

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<PlayerStats>().Result;
            }
            else
            {
                var testerror = response;
            }
            return null;
        }

        public int AddPlayerStats(PlayerStats playerStats)
        {
            var response = _webApi.Post(playerStatsURL, playerStats);

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

        public int UpdatePlayerStats(PlayerStats playerStats)
        {
            var response = _webApi.Put(playerStatsURL, playerStats);

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

