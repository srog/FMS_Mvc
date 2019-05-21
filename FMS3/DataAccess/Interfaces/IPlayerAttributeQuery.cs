using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.DataAccess.Interfaces
{
    public interface IPlayerAttributeQuery
    {
        IEnumerable<PlayerAttribute> GetByPlayer(int playerId);
        PlayerAttribute Get(int id);
        int Add(PlayerAttribute playerAttribute);
        int Update(PlayerAttribute playerAttribute);
        void Delete(int id);
    }
}