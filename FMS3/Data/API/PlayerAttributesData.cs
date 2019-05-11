using FMS3.Models;
using System.Net.Http;
using System.Collections.Generic;
using FMS3.Data.Interfaces;

namespace FMS3.Data.API
{
    public class PlayerAttributesData : IPlayerAttributesData
    {
        private IWebApi _webApi { get; }
        private readonly string playerAttributeURL = "http://localhost:56822/api/playerAttribute";

        public PlayerAttributesData(IWebApi webApi)
        {
            _webApi = webApi;
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
