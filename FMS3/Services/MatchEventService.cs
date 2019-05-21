using System.Collections.Generic;
using System.Linq;
using FMS3.DataAccess.Interfaces;
using FMS3.Models;
using FMS3.Services.Interfaces;

namespace FMS3.Services
{
    public class MatchEventService : IMatchEventService
    {
        private readonly IMatchEventQuery _matchEventQuery;

        public MatchEventService(IMatchEventQuery matchEventQuery)
        {
            _matchEventQuery = matchEventQuery;
        }

        #region Implementation of IMatchEventService

        public List<MatchEvent> GetForMatch(int matchId)
        {
            return _matchEventQuery.GetAllForMatch(matchId).ToList();
        }

        public int Insert(MatchEvent matchEvent)
        {
            return _matchEventQuery.Insert(matchEvent);
        }


        #endregion
    }
}