﻿using System.Collections.Generic;
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
        private readonly IPlayerService _playerService;
        private readonly ITeamService _teamService;
        private readonly ISeasonService _seasonService;
        private readonly ITeamSeasonService _teamSeasonService;
        private readonly IPlayerCreatorService _playerCreatorService;
        private readonly IConfiguration _configuration;

        public GameDetailsService(IGameDetailsQuery gameDetailsQuery, 
            IPlayerService playerService,
            ITeamService teamService,
            ISeasonService seasonService,
            ITeamSeasonService teamSeasonService,
            IPlayerCreatorService playerCreatorService,
            IConfiguration configuration)
        {
            _gameDetailsQuery = gameDetailsQuery;
            _playerService = playerService;
            _teamService = teamService;
            _seasonService = seasonService;
            _teamSeasonService = teamSeasonService;
            _playerCreatorService = playerCreatorService;
            _configuration = configuration;
        }

        public GameDetails GetCurrentGame()
        {
            return Get(GameCache.GameDetailsId);
        }


        #region Implementation of IGameDetailsService

        public int StartNewGame()
        {
            var newGame = new GameDetails { ManagerName = "", TeamId = 0, CurrentSeasonId = 0, CurrentWeek = 0 };

            var gameId = Insert(newGame);
            if (gameId > 0)
            {
                newGame.Id = gameId;

                var seasonId = _seasonService.AddNew(newGame.Id);

                newGame.CurrentSeasonId = seasonId;
                Update(newGame);

                _teamService.CreateAllTeamsForGame(gameId);
                var teamList = _teamService.GetTeamsForGame();

                _teamSeasonService.CreateForNewGame(teamList, seasonId, gameId);
                _playerCreatorService.CreateAllPlayersForGame(teamList);
            }

            return gameId;
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

            GameCache.TeamTemplates = _configuration.GetSection("TeamTemplates").Get<List<string>>();

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
            _playerService.AdvanceWeek(gameDetails);
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
