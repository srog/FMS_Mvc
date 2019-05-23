using System;
using FMS3.Models;
using System.Collections.Generic;
using FMS3.DataAccess.Interfaces;

namespace FMS3.DataAccess.Queries
{    
    public class MatchQuery : IMatchQuery
    {
        private const string GET_ALL = "spGetMatches";
        private const string GET = "spGetMatchById";
        private const string INSERT = "spInsertMatch";
        private const string UPDATE = "spUpdateMatch";

        private readonly IQuery _query;
        public MatchQuery(IQuery query)
        {
            _query = query;
        }
        public IEnumerable<Match> GetAll(Match match)
        {
            var param = new
            {
                match.GameDetailsId,
                match.SeasonId,
                match.DivisionId,
                match.Week,
                match.HomeTeamId,
                match.AwayTeamId,
                match.Attendance,
                match.Completed
            };
            return _query.GetAll<Match>(GET_ALL, param);
        }

        public Match Get(int id)
        {
            return _query.GetSingle<Match>(GET, id);
        }

        public int Insert(Match match)
        {
            return _query.Add(INSERT, new Dictionary<string, object>
            {
                { "gameDetailsId", match.GameDetailsId },
                { "seasonId", match.SeasonId },
                { "divisionId", match.DivisionId },
                { "week", match.Week },
                { "homeTeamId", match.HomeTeamId },
                { "awayTeamId", match.AwayTeamId },
                { "homeTeamScore", match.HomeTeamScore },
                { "awayTeamScore", match.AwayTeamScore },
                { "attendance", match.Attendance }
            });
        }

        public int Update(Match match)
        {
            return _query.Update(UPDATE, new {
                match.Id, match.HomeTeamScore, match.AwayTeamScore, match.Attendance, match.Completed
            });
        }

        public void Delete(int gameDetailsId)
        {
            throw new NotImplementedException();
            //Delete(DELETE, gameDetailsId);
        }

    }
}
