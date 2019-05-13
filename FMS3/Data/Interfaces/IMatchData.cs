using FMS3.Models;
using System.Collections.Generic;

namespace FMS3.Data.Interfaces
{
    public interface IMatchData
    {
        IEnumerable<Match> GetAllMatches(int divisionId = 0, int week = 0);
        Match GetMatch(int id);
        int AddMatch(Match match);
        int PlayMatch(int id);
        int PlayAllMatchesForWeek(int seasonId, int week, int divisionId);
    }
}
