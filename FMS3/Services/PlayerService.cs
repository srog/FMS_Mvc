using System.Collections.Generic;
using System.Linq;
using FMS3.Data.Cache;
using FMS3.DataAccess.Interfaces;
using FMS3.Enums;
using FMS3.Models;
using FMS3.Services.Interfaces;
using Microsoft.Extensions.Configuration;

namespace FMS3.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IConfiguration _configuration;
        private readonly IPlayerQuery _playerQuery;
        private readonly IPlayerAttributeService _playerAttributeService;
        private readonly ITeamService _teamService;

        private static Dictionary<int, List<int>> SquadCache = new Dictionary<int, List<int>>();
        
        public PlayerService(IPlayerQuery playerQuery, 
            IPlayerAttributeService playerAttributeService, 
            IConfiguration configuration,
            ITeamService teamService)
        {
            _playerQuery = playerQuery;
            _playerAttributeService = playerAttributeService;
            _configuration = configuration;
            _teamService = teamService;
        }
        #region Implementation of IPlayerService
        
        public PlayerListDisplay GetAllPlayers(int? teamId = null)
        {
          
            var playerInfo = new PlayerListDisplay();
            if (teamId == null)
            {
                playerInfo.PlayerList = GetAllPlayersInGame().ToList();
            }
            else
            {
                playerInfo.PlayerList = GetTeamSquad(teamId.Value).ToList();
            }
            switch (teamId)
            {
                case 0:
                    playerInfo.DisplayType = PlayerListDisplayTypeEnum.TransferMarket;
                    break;
                case null:
                    playerInfo.DisplayType = PlayerListDisplayTypeEnum.AllPlayers;
                    break;
                default:
                    playerInfo.DisplayType = teamId == GameCache.ManagedTeamId ?
                        PlayerListDisplayTypeEnum.MySquad :
                        PlayerListDisplayTypeEnum.OtherSquad;
                    break;
            }
            if (playerInfo.DisplayType == PlayerListDisplayTypeEnum.AllPlayers)
            {
                playerInfo.TeamFormationId = 0;
                playerInfo.TeamFormation = "";
                playerInfo.TeamName = "";
            }
            else
            {
                if (playerInfo.DisplayType != PlayerListDisplayTypeEnum.TransferMarket)
                {
                    var team = _teamService.Get(teamId.Value);
                    playerInfo.TeamFormationId = team.FormationId;
                    playerInfo.TeamFormation = GameCache.Formations.FormationList.First(f => f.Id == team.FormationId).Name;
                    playerInfo.TeamName = team.Name;
                }

            }

            playerInfo.IsPostSeason =  GameCache.CurrentWeek == 23;
            playerInfo.IsPreSeason = GameCache.CurrentWeek == 0;

            return playerInfo;
      
        }
        public IEnumerable<Player> GetAllPlayersInGame()
        {
            return _playerQuery.GetAll().ToList();
        }
        public List<Player> GetTeamSquad(int teamId)
        {
            return _playerQuery.GetAll(teamId)
                .OrderBy(p => p.Position)
                .ToList();
        }

        public List<Player> GetSelectedTeam(int teamId)
        {
            return _playerQuery.GetAll(teamId)
                .Where(p => p.IsSelected)
                .OrderBy(p => p.Position)
                .ToList();
        }

        public Player Get(int id)
        {
            return _playerQuery.Get(id);
        }

        public string GetPlayerName(int playerId)
        {
            if (!GameCache.PlayerFullNames.ContainsKey(playerId))
            {
                GameCache.PlayerFullNames.Add(playerId, Get(playerId).Name);
            }
            return GameCache.PlayerFullNames.GetValueOrDefault(playerId);
        }

        public string GetPlayerShortName(int playerId)
        {
            if (!GameCache.PlayerShortNames.ContainsKey(playerId))
            {
                GameCache.PlayerShortNames.Add(playerId, Get(playerId).ShortName);
            }
            return GameCache.PlayerShortNames.GetValueOrDefault(playerId);
        }

        public int Add(Player player)
        {
            return _playerQuery.Add(player);
        }

        public int Update(Player player)
        {
            return _playerQuery.Update(player);
        }
        
        // Primitive
        public void RecalculateRatingAndValue(int playerId)
        {
            var player = Get(playerId);
            var attributes = _playerAttributeService.GetByPlayer(playerId);
            var total = attributes.Sum(a => a.AttributeValue);
            player.Rating = total / attributes.Count;
            
            int mean = (int)(total / 12);

            if (mean > 80)
            {
                player.Value = mean * 1000000;
            }
            if (mean > 50)
            {
                player.Value = (mean - 50) * 15000;
            }
            if (mean < 25)
            {
                player.Value = 0;
            }
            player.Value = (mean * 500);

            Update(player);
        }

        public int Retire(int id)
        {
            return _playerQuery.RetirePlayer(id);
        }

        public int AdvanceSeason(int gameDetailsId)
        {
            return AdvanceAllAges(gameDetailsId);
        }

        public int AdvanceAllAges(int gameDetailsId)
        {
            return _playerQuery.AdvanceAllAges(gameDetailsId);
        }

        // advance injuries and suspensions. Recalculate team selections.
        // TODO - training, recalculate ratings, values
        public int AdvanceWeek()
        {
            var teamsChangedList = new List<int>();
            var injuredPlayerList = GetAllPlayersInGame().Where(p => p.InjuredWeeks > 0);
            foreach (var player in injuredPlayerList)
            {
                player.InjuredWeeks--;
                Update(player);
                if (!teamsChangedList.Contains(player.TeamId))
                {
                    teamsChangedList.Add(player.TeamId);
                }
            }
            var suspendedPlayerList = GetAllPlayersInGame().Where(p => p.SuspendedWeeks > 0);
            foreach (var player in suspendedPlayerList)
            {
                player.SuspendedWeeks--;
                Update(player);
                if (!teamsChangedList.Contains(player.TeamId))
                {
                    teamsChangedList.Add(player.TeamId);
                }
            }

            foreach(var team in teamsChangedList)
            {
                if (team != GameCache.ManagedTeamId)
                {
                    SetTeamSelection(_teamService.Get(team));
                }
            }
            return 1;
        }

        public int GetRandomPlayerFromTeam(int teamId, bool includeKeeper = true, bool includeInjured = true, bool includeSuspended = true)
        {
            if (!SquadCache.ContainsKey(teamId))
            {
                var players = GetTeamSquad(teamId);
                SquadCache.Add(teamId, players.Select(p => p.Id).ToList());
            }
            var playerList = SquadCache.GetValueOrDefault(teamId);

            var playerIndex = Utilities.Utilities.GetRandomNumber(0, playerList.Count - 1);
            return playerList[playerIndex];
        }

        // Primitive
        public void SetTeamSelection(Team team)
        {
            var formations = _configuration.GetSection("FormationSection").Get<Formations>();
            var teamFormation = formations.FormationList.First(f => f.Id == team.FormationId);

            var allPlayers = GetTeamSquad(team.Id);
            foreach (var player in allPlayers)
            {
                player.TeamSelection = 0;
            }

            // GK
            var playerSelected = GetNextAvailablePlayerForPosition(allPlayers, PositionEnum.Goalkeeper);
            if (playerSelected > 0)
            {
                allPlayers.First(p => p.Id == playerSelected).TeamSelection = 1;
            }

            // Def
            for (var def = 1; def <= teamFormation.Defenders; def++)
            {
                var defenderSelected = GetNextAvailablePlayerForPosition(allPlayers, PositionEnum.Defender);
                if (defenderSelected > 0)
                {
                    allPlayers.First(p => p.Id == defenderSelected).TeamSelection = 1 + def;
                }
            }

            // Mid
            for (var mid = 1; mid <= teamFormation.Midfielders; mid++)
            {
                var midSelected = GetNextAvailablePlayerForPosition(allPlayers, PositionEnum.Midfielder);
                if (midSelected > 0)
                {
                    allPlayers.First(p => p.Id == midSelected).TeamSelection = 1 + teamFormation.Defenders + mid;
                }
            }

            // Att
            for (var att = 1; att <= teamFormation.Attackers; att++)
            {
                var attSelected = GetNextAvailablePlayerForPosition(allPlayers, PositionEnum.Striker);
                if (attSelected > 0)
                {
                    allPlayers.First(p => p.Id == attSelected).TeamSelection = 1 + teamFormation.Defenders + teamFormation.Midfielders + att;
                }
            }

            // If any positions haven't been filled....do something !

            // Update with new selections
            foreach (var player in allPlayers)
            {
                Update(player);
            }

        }

        private int GetNextAvailablePlayerForPosition(IEnumerable<Player> playerList, PositionEnum position)
        {
            var playerSelected = 0;
            var playerSelectedRating = 0;
            foreach (var p in playerList.Where(p => p.Position == position.GetHashCode() && p.IsAvailable && p.TeamSelection == 0))
            {
                if (p.Rating > playerSelectedRating)
                {
                    playerSelected = p.Id;
                    playerSelectedRating = p.Rating;
                }
            }
            return playerSelected;
        }

        public void Delete(int gameDetailsId)
        {
            _playerQuery.Delete(gameDetailsId);
        }

        #endregion
    }
}
