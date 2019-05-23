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
        private readonly ITeamSeasonService _teamSeasonService;
        private readonly IPlayerCreatorService _playerCreatorService;
        private readonly ITeamService _teamService;
        private readonly INewsService _newsService;
        private readonly IPlayerService _playerService;


        public GameDetailsService(IGameDetailsQuery gameDetailsQuery, 
            ISeasonService seasonService,
            IConfiguration configuration,
            ITeamService teamService,
            ITeamSeasonService teamSeasonService,
            INewsService newsService,
            IPlayerCreatorService playerCreatorService,
            IPlayerService playerService)
        {
            _gameDetailsQuery = gameDetailsQuery;
            _seasonService = seasonService;
            _configuration = configuration;
            _teamService = teamService;
            _teamSeasonService = teamSeasonService;
            _playerCreatorService = playerCreatorService;
            _newsService = newsService;
            _playerService = playerService;
        }

        public GameDetails GetCurrentGame()
        {
            return Get(GameCache.GameDetailsId);
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

                GameCache.GameDetailsId = gameId;
                GameCache.CurrentWeek = 0;

                _teamService.CreateAllTeamsForGame(gameId);
                var teamList = _teamService.GetTeamsForGame();
                _teamSeasonService.CreateForNewGame(teamList, seasonId, gameId);
                _playerCreatorService.CreateAllPlayersForGame(teamList);

                return newGame;
            }

            return null;
        }

        public GameDetails SetManagerName(string managerName)
        {
            var game = GetCurrentGame();
            game.ManagerName = managerName;
            Update(game);
            GameCache.CurrentSeasonId = game.CurrentSeasonId;

            var newsText = managerName + " has become manager of " + _teamService.GetTeamName(game.TeamId);
            _newsService.Add(new News
                {
                    TeamId = game.TeamId,
                    GameDetailsId = game.Id,
                    SeasonId = game.CurrentSeasonId,
                    NewsText = newsText
                });

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

            GameCache.CurrentWeek = 0;
            GameCache.CurrentSeasonId = seasonId;
            return game;
        }

        public GameDetails LoadGame(int id)
        {
            var game = Get(id);
            GameCache.GameDetailsId = id;
            GameCache.CurrentSeasonId = game.CurrentSeasonId;
            GameCache.ManagedTeamId = game.TeamId;
            GameCache.CurrentWeek = game.CurrentWeek;

            return game;
        }

        public bool LoadStaticData()
        {
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
        
            _playerService.AdvanceWeek();

            GameCache.CurrentWeek = gameDetails.CurrentWeek;
            return gameDetails;
        }

        public GameDetails CompleteCurrentSeason()
        {
            var newYear = _seasonService.CompleteCurrentSeason();

            var newSeason = new Season { Completed = false, GameDetailsId = GameCache.GameDetailsId, StartYear = newYear };
            var newSeasonId = _seasonService.Add(newSeason);
            _teamSeasonService.PromotionAndRelegation(newSeasonId);

            return SetGameToNewSeason(newSeasonId); 
        }

        public int Delete(int id)
        {
            return _gameDetailsQuery.Delete(id);
        }

        #endregion
    }
}
