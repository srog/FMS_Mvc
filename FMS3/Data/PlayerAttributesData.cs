using FMS3.Models;
using System.Net.Http;

namespace FMS3.Data
{
    public class PlayerAttributesData
    {
        private readonly IWebApi _webApi;
        private readonly string playerAttributesURL = "http://localhost:56822/api/playerAttributes";

        public PlayerAttributesData()
        {
            if (_webApi == null)
            {
                _webApi = new WebApi();
            }
        }

        public PlayerAttributes GetPlayerAttributes(int playerId)
        {
            var response = _webApi.Get(playerAttributesURL, playerId);

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<PlayerAttributes>().Result;
            }
            else
            {
                var testerror = response;
            }
            return null;
        }

        public int AddPlayerAttributes(PlayerAttributes playerAttributes)
        {
            var response = _webApi.Post(playerAttributesURL, playerAttributes);

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

        public int UpdatePlayerAttributes(PlayerAttributes playerAttributes)
        {
            var response = _webApi.Put(playerAttributesURL, playerAttributes);

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
