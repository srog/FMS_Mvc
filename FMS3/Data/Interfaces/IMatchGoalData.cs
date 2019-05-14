using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.Data.Interfaces
{
    public interface IMatchGoalData
    {
        IEnumerable<MatchGoal> GetAllForMatch(int matchId);
    }
}