using System.Collections.Generic;
using FMS3.Data.Cache;
using FMS3.DataAccess.Interfaces;
using FMS3.Models;

namespace FMS3.DataAccess.Queries
{
    public class PlayerQuery : IPlayerQuery
    {
        private const string GET_ALL = "spGetAllPlayers";
        private const string GET = "spGetPlayerById";
        private const string INSERT = "spInsertPlayer";
        private const string UPDATE = "spUpdatePlayer";
        private const string DELETE = "spDeletePlayer";

        // experimental
        private const string RETIRE_PLAYER = "spRetirePlayer";
        private const string ADVANCE_ALL_PLAYER_AGES = "spAdvanceAllPlayerAges";

        private readonly IQuery _query;
        public PlayerQuery(IQuery query)
        {
            _query = query;
        }

        public IEnumerable<Player> GetAll(int? teamId = null)
        {
            var param = new
                {
                    GameCache.GameDetailsId,
                    teamId
                };
            return _query.GetAll<Player>(GET_ALL, param);
        }

        public Player Get(int id)
        {
            return _query.GetSingle<Player>(GET, id);
        }
        public int Add(Player player)
        {
            return _query.Add(INSERT, new Dictionary<string, object>
                {
                    { "age", player.Age },
                    { "injuredWeeks", player.InjuredWeeks },
                    { "suspendedWeeks", player.SuspendedWeeks },
                    { "position", player.Position },
                    { "name", player.Name },
                    { "rating", player.Rating },
                    { "retired", player.Retired },
                    { "teamId", player.TeamId },
                    { "value", player.Value },
                    { "gameDetailsId", player.GameDetailsId }
                });

      }
        public int Update(Player player)
        {
            return _query.Update(UPDATE, new
                {
                    player.Id,
                    player.Age,
                    player.InjuredWeeks,
                    player.SuspendedWeeks,
                    player.Position,
                    player.Name,
                    player.Rating,
                    player.Retired,
                    player.TeamId,
                    player.Value,
                    player.TeamSelection
                });
        }
  
        public int RetirePlayer(int id)
        {
            return _query.UpdateSingleColumn(RETIRE_PLAYER, "id", id);
        }

        public int AdvanceAllAges(int gameDetailsId)
        {
            return _query.UpdateSingleColumn(ADVANCE_ALL_PLAYER_AGES, "gameDetailsId", gameDetailsId);
        }

        public void Delete(int gameDetailsId)
        {
            _query.Delete(DELETE, gameDetailsId);
        }
    }


}