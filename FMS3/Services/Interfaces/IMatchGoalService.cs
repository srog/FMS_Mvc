using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.Services.Interfaces
{
    public interface IMatchGoalService
    {
        List<MatchGoal> GetForMatch(int matchId);
        int Insert(MatchGoal matchGoal);
    }
}