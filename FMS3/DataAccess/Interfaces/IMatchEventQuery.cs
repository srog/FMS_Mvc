using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.DataAccess.Interfaces
{
    public interface IMatchEventQuery
    {
        IEnumerable<MatchEvent> GetAllForMatch(int matchId);
        MatchEvent Get(int id);
        int Insert(MatchEvent matchEvent);
    }
}