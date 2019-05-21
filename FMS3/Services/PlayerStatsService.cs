using FMS3.DataAccess.Interfaces;
using FMS3.Models;
using FMS3.Services.Interfaces;

namespace FMS3.Services
{
    public class PlayerStatsService : IPlayerStatsService
    {
        private readonly IPlayerStatsQuery _playerStatsQuery;

        public PlayerStatsService(IPlayerStatsQuery playerStatsQuery)
        {
            _playerStatsQuery = playerStatsQuery;
        }
        #region Implementation of IPlayerStatsService

        public PlayerStats Get(int playerId)
        {
            return _playerStatsQuery.Get(playerId);
        }

        public int Add(PlayerStats playerStats)
        {
            return _playerStatsQuery.Add(playerStats);
        }

        public int Update(PlayerStats playerStats)
        {
            return _playerStatsQuery.Update(playerStats);
        }
        #endregion
    }
}
