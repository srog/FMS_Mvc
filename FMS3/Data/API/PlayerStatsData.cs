using FMS3.Data.Interfaces;
using FMS3.Models;
using System.Net.Http;

namespace FMS3.Data.API
{
    public class PlayerStatsData : IPlayerStatsData
    {
        private IWebApi _webApi { get; }
        private readonly string playerStatsURL = "http://localhost:56822/api/playerStats";

        public PlayerStatsData(IWebApi webApi)
        {
            _webApi = webApi;
        }

        public PlayerStats GetPlayerStats(int playerId)
        {
            var response = _webApi.GetById(playerStatsURL, playerId, true);

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

