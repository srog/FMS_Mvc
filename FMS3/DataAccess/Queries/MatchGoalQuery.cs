using System.Collections.Generic;
using FMS3.DataAccess.Interfaces;
using FMS3.Models;

namespace FMS3.DataAccess.Queries
{
    public class MatchGoalQuery : IMatchGoalQuery
    {
        private const string GET_ALL = "spGetMatchGoals";
        private const string GET = "spGetMatchGoalById";
        private const string INSERT = "spInsertMatchGoal";

        private readonly IQuery _query;
        public MatchGoalQuery(IQuery query)
        {
            _query = query;
        }

        public MatchGoal Get(int id)
        {
            return _query.GetSingle<MatchGoal>(GET, id);
        }

        public IEnumerable<MatchGoal> GetAllForMatch(int matchId)
        {
            return _query.GetAll<MatchGoal>(GET_ALL, new {matchId});
        }

        public int Insert(MatchGoal matchGoal)
        {
            return _query.Add(INSERT, new Dictionary<string, object>
                {
                    { "matchId", matchGoal.MatchId },
                    { "teamId", matchGoal.TeamId },
                    { "minute", matchGoal.Minute },
                    { "playerId", matchGoal.PlayerId },
                    { "assistPlayerId", matchGoal.AssistPlayerId },
                    { "ownGoal", matchGoal.OwnGoal }
                });
        }
    }
}
