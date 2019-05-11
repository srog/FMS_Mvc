using FMS3.Models;

namespace FMS3.Data.Interfaces
{
    public interface IPlayerStatsData
    {
        PlayerStats GetPlayerStats(int playerId);
        int AddPlayerStats(PlayerStats playerStats);
        int UpdatePlayerStats(PlayerStats playerStats);
    }
}
