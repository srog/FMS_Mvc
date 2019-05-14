using FMS3.Data.Cache;
using FMS3.Data.Interfaces;
using FMS3.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using FMS3.Enums;

namespace FMS3.Data.API
{
    public class PlayerData : IPlayerData
    {
        private readonly IWebApi _webApi;
        private readonly IGameDetailsData _gameDetailsData;
        private readonly ITeamData _teamData;

        private readonly string playerURL = "http://localhost:56822/api/player";

        public PlayerData(IWebApi webApi, ITeamData teamData, IGameDetailsData gameDetailsData)
        {
            _webApi = webApi;
            _teamData = teamData;
            _gameDetailsData = gameDetailsData;
        }

        public PlayerListDisplay GetAllPlayers(int? teamId = null)
        {
            var paramList = new Dictionary<string, object>
                {
                    {"gameDetailsId",GameCache.GameDetailsId},
                    {"teamId",teamId}
                };
            var response = _webApi.GetAll(playerURL, paramList);
            if (response.IsSuccessStatusCode)
            {
                var playerInfo = new PlayerListDisplay();
                playerInfo.PlayerList = response.Content.ReadAsAsync<IEnumerable<Player>>().Result.ToList();
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
                        var team = _teamData.GetTeam(teamId.Value);
                        playerInfo.TeamFormationId = team.FormationId;
                        playerInfo.TeamFormation = GameCache.Formations.FormationList.First(f => f.Id == team.FormationId).Name;
                        playerInfo.TeamName = team.Name;
                    }
                    
                }

                var game = _gameDetailsData.GetById(GameCache.GameDetailsId);
                playerInfo.IsPostSeason = game.CurrentWeek == 23;
                playerInfo.IsPreSeason = game.CurrentWeek == 0;

                return playerInfo;
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

        public string GetPlayerShortName(int playerId)
        {
            if (!GameCache.PlayerShortNames.ContainsKey(playerId))
            {
                string name;
                name = GetPlayer(playerId).ShortName;
                
                GameCache.PlayerShortNames.Add(playerId, name);
            }
            return GameCache.PlayerShortNames.GetValueOrDefault(playerId);
        }

        public string GetPlayerFullName(int playerId)
        {
            if (!GameCache.PlayerFullNames.ContainsKey(playerId))
            {
                string name;
                name = GetPlayer(playerId).Name;

                GameCache.PlayerFullNames.Add(playerId, name);
            }
            return GameCache.PlayerFullNames.GetValueOrDefault(playerId);
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
