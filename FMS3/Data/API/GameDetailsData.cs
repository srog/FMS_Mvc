using FMS3.Data.Cache;
using FMS3.Data.Interfaces;
using FMS3.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace FMS3.Data.API
{
    public class GameDetailsData : IGameDetailsData
    {
        private IWebApi _webApi { get; }
        private readonly string gameDetailsURL = "http://localhost:56822/api/gameDetails";
        private readonly string startNewGameURL = "http://localhost:56822/api/StartNewGame";

        public GameDetailsData(IWebApi webApi)
        {
            _webApi = webApi;
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

        public IEnumerable<GameDetails> GetAll()
        {
            var response = _webApi.GetAll(gameDetailsURL);
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

        public GameDetails GetById(int id)
        {
            var response = _webApi.GetById(gameDetailsURL, id, true);

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

        private int UpdateGameDetails(GameDetails gameDetails)
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
            var game = GetById(GameCache.GameDetailsId);
            game.CurrentSeasonId = seasonId;
            game.CurrentWeek = 0;
            UpdateGameDetails(game);
            return game;
        }

        public GameDetails AdvanceWeek()
        {
            var game = GetById(GameCache.GameDetailsId);
            game.CurrentWeek++;
            UpdateGameDetails(game);
            return game;
        }

        public GameDetails SetManagerName(string managerName)
        {
            var game = GetById(GameCache.GameDetailsId);
            game.ManagerName = managerName;
            UpdateGameDetails(game);
            return game;
        }

        public GameDetails SetTeam(int teamId)
        {
            var game = GetById(GameCache.GameDetailsId);
            game.TeamId = teamId;
            UpdateGameDetails(game);
            return game;
        }
    }
}
