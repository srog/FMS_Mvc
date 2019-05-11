using FMS3.Models;
using System.Collections.Generic;

namespace FMS3.Data.Interfaces
{
    public interface IPlayerAttributesData
    {
        IEnumerable<PlayerAttribute> GetPlayerAttributes(int playerId);
        int AddPlayerAttributes(PlayerAttribute playerAttribute);
        int UpdatePlayerAttributes(PlayerAttribute playerAttribute);

    }
}