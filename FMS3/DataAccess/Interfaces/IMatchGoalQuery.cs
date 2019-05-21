using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.DataAccess.Interfaces
{
    public interface IMatchGoalQuery
    {
        IEnumerable<MatchGoal> GetAllForMatch(int matchId);
        MatchGoal Get(int id);
        int Insert(MatchGoal matchGoal);
    }
}
