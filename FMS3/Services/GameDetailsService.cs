using System.Collections.Generic;
using System.Linq;
using FMS3.Data.Cache;
using FMS3.DataAccess.Interfaces;
using FMS3.Models;
using FMS3.Services.Interfaces;
using Microsoft.Extensions.Configuration;

namespace FMS3.Services
{
    public class GameDetailsService : IGameDetailsService
    {
        private readonly IGameDetailsQuery _gameDetailsQuery;
        private readonly ISeasonService _seasonService;
        private readonly IConfiguration _configuration;

        public GameDetailsService(IGameDetailsQuery gameDetailsQuery, 
            ISeasonService seasonService,
            IConfiguration configuration)
        {
            _gameDetailsQuery = gameDetailsQuery;
            _seasonService = seasonService;
            _configuration = configuration;
        }

        public GameDetails GetCurrentGame()
        {
            return Get(GameCache.GameDetailsId);
        }

        public int GetCurrentWeek()
        {
            return GetCurrentGame().CurrentWeek;
        }


        #region Implementation of IGameDetailsService

        public GameDetails StartNewGame()
        {
            var newGame = new GameDetails { ManagerName = "", TeamId = 0, CurrentSeasonId = 0, CurrentWeek = 0 };

            var gameId = Insert(newGame);
            if (gameId > 0)
            {
                newGame.Id = gameId;

                var seasonId = _seasonService.AddNew(newGame.Id);

                newGame.CurrentSeasonId = seasonId;
                Update(newGame);

                
                return newGame;
                
                //var teamList = _teamService.GetTeamsForGame();

                //_teamService.CreateAllTeamsForGame(gameId);
                //_teamSeasonService.CreateForNewGame(teamList, seasonId, gameId);
                //_playerCreatorService.CreateAllPlayersForGame(teamList);
            }

            return null;
        }

        public GameDetails SetManagerName(string managerName)
        {
            var game = GetCurrentGame();
            game.ManagerName = managerName;
            Update(game);
            return game;
        }

        public GameDetails SetTeam(int teamId)
        {
            var game = GetCurrentGame();
            game.TeamId = teamId;
            Update(game);
            GameCache.ManagedTeamId = teamId;
            return game;
        }

        public GameDetails SetGameToNewSeason(int seasonId)
        {
            var game = GetCurrentGame();
            game.CurrentSeasonId = seasonId;
            game.CurrentWeek = 0;
            Update(game);
            return game;
        }

        public bool LoadStaticData()
        {

            //var response = _webApi.GetAll(formationsURL);
            //if (response.IsSuccessStatusCode)
            //{
            //    GameCache.Formations = response.Content.ReadAsAsync<Formations>().Result;
            //    if (GameCache.Formations != null)
            //        return true;
            //}

            GameCache.Formations = _configuration.GetSection("FormationSection").Get<Formations>();

            GameCache.TeamTemplates = _configuration.GetSection("TeamTemplateSection").Get<TeamTemplates>();

            return true;
        }

        public List<GameDetails> GetAll()
        {
            return _gameDetailsQuery.GetAll().ToList();
        }

        public GameDetails Get(int id)
        {
            return _gameDetailsQuery.Get(id);
        }

        public int Insert(GameDetails gameDetails)
        {
            return _gameDetailsQuery.Insert(gameDetails);
        }

        public int Update(GameDetails gameDetails)
        {
            return _gameDetailsQuery.Update(gameDetails);
        }


        public GameDetails AdvanceWeek()
        {
            var gameDetails = GetCurrentGame();
            gameDetails.CurrentWeek++;
            _gameDetailsQuery.Update(gameDetails);
            return gameDetails;
        }
        public int AdvanceSeason(GameDetails gameDetails)
        {
            // TODO 

            return 0;
        }

        public int Delete(int id)
        {
            return _gameDetailsQuery.Delete(id);
        }

        #endregion
    }
}
