using FMS3.Models;
using System.Net.Http;
using System.Collections.Generic;

namespace FMS3.Data
{
    public class PlayerAttributesData
    {
        private readonly IWebApi _webApi;
        private readonly string playerAttributeURL = "http://localhost:56822/api/playerAttribute";

        public PlayerAttributesData()
        {
            if (_webApi == null)
            {
                _webApi = new WebApi();
            }
        }

        public IEnumerable<PlayerAttribute> GetPlayerAttributes(int playerId)
        {
            var paramList = new Dictionary<string, object>
                {
                    {"playerId", playerId}
                };
            var response = _webApi.GetAll(playerAttributeURL, paramList);

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<PlayerAttribute>>().Result;
            }
            else
            {
                var testerror = response;
            }
            return null;
        }

        public int AddPlayerAttributes(PlayerAttribute playerAttribute)
        {
            var response = _webApi.Post(playerAttributeURL, playerAttribute);

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

        public int UpdatePlayerAttributes(PlayerAttribute playerAttribute)
        {
            var response = _webApi.Put(playerAttributeURL, playerAttribute);

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
