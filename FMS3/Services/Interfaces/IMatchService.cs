using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.Services.Interfaces
{
    public interface IMatchService
    {
        Match PlayMatch(int id);
        void PlayAllMatchesForDivision(int seasonId, int week, int divisionId);

        void PlayAllMatchesForWeek(int seasonId, int week);
        List<Match> GetAll(Match match);
        Match GetThisWeeksForManagedTeam(int week);
        IEnumerable<Match> GetForm(int teamId);
        Match Get(int id);
        int Insert(Match match);
        int Update(Match match);
    }
}