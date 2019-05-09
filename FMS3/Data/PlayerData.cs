using FMS3.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace FMS3.Data
{
    public class PlayerData
    {
        private readonly IWebApi _webApi;
        private readonly string playerURL = "http://localhost:56822/api/player";

        public PlayerData()
        {
            if (_webApi == null)
            {
                _webApi = new WebApi();
            }
        }

        public IEnumerable<Player> GetPlayersForTeam(int teamId)
        {
            var url = playerURL + "/" + teamId + "/" + GlobalData.GameDetailsId;
            var response = _webApi.Get(url);
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<Player>>().Result;
            }
            else
            {
                var testerror = response;
            }
            return null;
        }

        public IEnumerable<Player> GetAllPlayersInGame()
        {
            var url = playerURL + "?gameDetailsId=" + GlobalData.GameDetailsId;

            var response = _webApi.Get(url);
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<Player>>().Result;
            }
            else
            {
                var testerror = response;
            }
            return null;
        }

        public Player GetPlayer(int id)
        {
            var response = _webApi.GetById(playerURL, id);

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<Player>().Result;
            }
            else
            {
                var testerror = response;
            }
            return null;
        }

        public int AddPlayer(Player player)
        {
            var response = _webApi.Post(playerURL, player);

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

        public int UpdatePlayer(Player player)
        {
            var response = _webApi.Put(playerURL, player);

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
        public int DeletePlayer(int id)
        {
            var response = _webApi.Delete(playerURL, id);
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<int>().Result;

            }
            else
            {
                return 0;
            }
        }
    }
}
