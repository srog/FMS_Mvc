using FMS3.Models;

namespace FMS3.Services.Interfaces
{
    public interface IPlayerStatsService
    {
        PlayerStats Get(int playerId);
        int Add(PlayerStats playerStats);
        int Update(PlayerStats playerStats);
    }
}
