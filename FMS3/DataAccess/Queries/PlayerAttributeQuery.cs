using System.Collections.Generic;
using FMS3.DataAccess.Interfaces;
using FMS3.Models;

namespace FMS3.DataAccess.Queries
{
    public class PlayerAttributeQuery : IPlayerAttributeQuery
    {
        private const string GET = "spGetPlayerAttribute";
        private const string GET_FOR_PLAYER = "spGetPlayerAttributes";
        private const string INSERT = "spInsertPlayerAttribute";
        private const string UPDATE = "spUpdatePlayerAttribute";

        private readonly IQuery _query;
        public PlayerAttributeQuery(IQuery query)
        {
            _query = query;
        }

        public IEnumerable<PlayerAttribute> GetByPlayer(int playerId)
        {
            return _query.GetAllById<PlayerAttribute>(GET_FOR_PLAYER, "playerId", playerId);
        }

        public PlayerAttribute Get(int id)
        {
            return _query.GetSingle<PlayerAttribute>(GET, id);
        }

        public int Add(PlayerAttribute playerAttribute)
        {
            return _query.Add(INSERT, new Dictionary<string, object>
                {
                    {"playerId", playerAttribute.PlayerId },
                    {"attributeId", playerAttribute.AttributeId },
                    {"attributeValue", playerAttribute.AttributeValue }

                });

        }
        public int Update(PlayerAttribute playerAttribute)
        {
            return _query.Update(UPDATE, new { playerAttribute.Id, playerAttribute.AttributeValue });
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }


}