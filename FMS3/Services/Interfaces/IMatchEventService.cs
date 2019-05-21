using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.Services.Interfaces
{
    public interface IMatchEventService
    {
        List<MatchEvent> GetForMatch(int matchId);
        int Insert(MatchEvent matchEvent);
    }
}