using System.Collections.Generic;
using FMS3.DataAccess.Interfaces;
using FMS3.Models;

namespace FMS3.DataAccess.Queries
{
    public class PlayerStatsQuery : Query, IPlayerStatsQuery
    {
        private const string GET = "spGetPlayerStats";
        private const string INSERT = "spInsertPlayerStats";
        private const string UPDATE = "spUpdatePlayerStats";

        public PlayerStats Get(int playerId)
        {
            return GetSingleById<PlayerStats>(GET, "id", playerId);
        }

        public int Add(PlayerStats playerStats)
        {
            return Add(INSERT, new Dictionary<string, object>
                {
                    {"playerId", playerStats.PlayerId}
                });
        }
        public int Update(PlayerStats playerStats)
        {
            return Update(UPDATE, new { playerStats.Assists, playerStats.CleanSheets, playerStats.Games, playerStats.Goals, playerStats.PlayerId, playerStats.RedCards, playerStats.YellowCards });
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }


}