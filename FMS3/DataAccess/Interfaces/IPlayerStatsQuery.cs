using FMS3.Models;

namespace FMS3.DataAccess.Interfaces
{
    public interface IPlayerStatsQuery
    {
        PlayerStats Get(int playerId);
        int Add(PlayerStats playerStats);
        int Update(PlayerStats playerStats);
        void Delete(int id);
    }
}