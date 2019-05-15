using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.Data.Interfaces
{
    public interface IMatchEventData
    {
        IEnumerable<MatchEvent> GetAllForMatch(int matchId);
    }
}