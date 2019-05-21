using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.Services.Interfaces
{
    public interface IPlayerAttributeService
    {
        List<PlayerAttribute> GetByPlayer(int playerId);
        PlayerAttribute Get(int id);
        int Add(PlayerAttribute playerAttribute);
        int Update(PlayerAttribute playerAttribute);
    }
}
