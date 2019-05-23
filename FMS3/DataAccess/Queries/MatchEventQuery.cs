﻿using System.Collections.Generic;
using FMS3.DataAccess.Interfaces;
using FMS3.Models;

namespace FMS3.DataAccess.Queries
{
    public class MatchEventQuery : IMatchEventQuery
    {
        private const string GET_ALL = "spGetMatchEvents";
        private const string GET = "spGetMatchEventById";
        private const string INSERT = "spInsertMatchEvent";

        private readonly IQuery _query;
        public MatchEventQuery(IQuery query)
        {
            _query = query;
        }

        public MatchEvent Get(int id)
        {
            return _query.GetSingle<MatchEvent>(GET, id);
        }

        public IEnumerable<MatchEvent> GetAllForMatch(int matchId)
        {
            return _query.GetAll<MatchEvent>(GET_ALL, new { matchId });
        }

        public int Insert(MatchEvent matchEvent)
        {
            return _query.Add(INSERT, new Dictionary<string, object>
                {
                    { "matchId", matchEvent.MatchId },
                    { "teamId", matchEvent.TeamId },
                    { "minute", matchEvent.Minute },
                    { "playerId", matchEvent.PlayerId },
                    { "eventType", matchEvent.EventType }
                });
        }
    }
}