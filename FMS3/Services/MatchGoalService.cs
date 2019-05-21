using System.Collections.Generic;
using System.Linq;
using FMS3.DataAccess.Interfaces;
using FMS3.Models;
using FMS3.Services.Interfaces;

namespace FMS3.Services
{
    public class MatchGoalService : IMatchGoalService
    {
        private readonly IMatchGoalQuery _matchGoalQuery;

        public MatchGoalService(IMatchGoalQuery matchGoalQuery)
        {
            _matchGoalQuery = matchGoalQuery;
        }

        public List<MatchGoal> GetForMatch(int matchId)
        {
            return _matchGoalQuery.GetAllForMatch(matchId).ToList();
        }

        public int Insert(MatchGoal matchGoal)
        {
            return _matchGoalQuery.Insert(matchGoal);
        }
    }
}