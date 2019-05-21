using System.Collections.Generic;
using System.Linq;
using FMS3.DataAccess.Interfaces;
using FMS3.Models;
using FMS3.Services.Interfaces;

namespace FMS3.Services
{
    public class PlayerAttributeService : IPlayerAttributeService
    {
        private readonly IPlayerAttributeQuery _playerAttributeQuery;

        public PlayerAttributeService(IPlayerAttributeQuery playerAttributeQuery)
        {
            _playerAttributeQuery = playerAttributeQuery;
        }
        #region Implementation of IPlayerAttributeService

        public List<PlayerAttribute> GetByPlayer(int playerId)
        {
            return _playerAttributeQuery.GetByPlayer(playerId).ToList();
        }

        public PlayerAttribute Get(int id)
        {
            return _playerAttributeQuery.Get(id);
        }

        public int Add(PlayerAttribute playerAttribute)
        {
            return _playerAttributeQuery.Add(playerAttribute);
        }

        public int Update(PlayerAttribute playerAttribute)
        {
            return _playerAttributeQuery.Update(playerAttribute);
        }

        #endregion
    }
}
