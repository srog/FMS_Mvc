using FMS3.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace FMS3.Data
{
    public class GameDetailsData
    {
        private readonly IWebApi _webApi;
        private readonly string gameDetailsURL = "http://localhost:56822/api/gameDetails";
        private readonly string startNewGameURL = "http://localhost:56822/api/StartNewGame";

        public GameDetailsData()
        {
            if (_webApi == null)
            {
                _webApi = new WebApi();
            }
        }

        public int StartNewGame()
        {
            var response = _webApi.Post(startNewGameURL);
            var newGameId = 0;

            if (response.IsSuccessStatusCode)
            {
                newGameId = response.Content.ReadAsAsync<int>().Result;
            }
            else
            {
                var testerror = response;
            }

            // return new game id
            return newGameId;
        }

        public IEnumerable<GameDetails> GetAllGameDetails()
        {
            var response = _webApi.Get(gameDetailsURL);
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<GameDetails>>().Result;
            }
            else
            {
                var testerror = response;
            }
            return null;
        }

        public GameDetails GetGameDetails(int id)
        {
            var response = _webApi.GetByGameDetailsId(gameDetailsURL, id);

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<GameDetails>().Result;
            }
            else
            {
                var testerror = response;
            }
            return null;
        }

        public int AddGameDetails(GameDetails gameDetails)
        {
            var response = _webApi.Post(gameDetailsURL, gameDetails);

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

        public int UpdateGameDetails(GameDetails gameDetails)
        {
            var response = _webApi.Put(gameDetailsURL, gameDetails);

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

        public GameDetails SetGameToNewSeason(int seasonId)
        {
            var game = GetGameDetails(GlobalData.GameDetailsId);
            game.CurrentSeasonId = seasonId;
            game.CurrentWeek = 0;
            UpdateGameDetails(game);
            return game;
        }

        public GameDetails AdvanceWeek()
        {
            var game = GetGameDetails(GlobalData.GameDetailsId);
            game.CurrentWeek++;
            UpdateGameDetails(game);
            return game;
        }

        public GameDetails SetManagerName(string managerName)
        {
            var game = GetGameDetails(GlobalData.GameDetailsId);
            game.ManagerName = managerName;
            UpdateGameDetails(game);
            return game;
        }
    }
}
