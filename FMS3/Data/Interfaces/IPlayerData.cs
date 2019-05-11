using FMS3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FMS3.Data.Interfaces
{
    public interface IPlayerData
    {
        IEnumerable<Player> GetPlayersForTeam(int teamId);
        IEnumerable<Player> GetAllPlayersInGame();
        Player GetPlayer(int id);
        int AddPlayer(Player player);
        int UpdatePlayer(Player player);
        int DeletePlayer(int id);
    }
}
