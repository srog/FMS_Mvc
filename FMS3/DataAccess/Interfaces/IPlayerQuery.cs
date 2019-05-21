using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.DataAccess.Interfaces
{
    public interface IPlayerQuery
    {
        IEnumerable<Player> GetAll(Player player);
        Player Get(int id);
        int Add(Player player);
        int Update(Player player);
        int RetirePlayer(int id);
        int AdvanceAllAges(int gameDetailsId);
        void Delete(int gameDetailsId);
    }
}