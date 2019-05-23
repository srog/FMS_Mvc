using FMS3.Models;
using System.Collections.Generic;
using FMS3.Data.Cache;
using FMS3.DataAccess.Interfaces;

namespace FMS3.DataAccess.Queries
{
    public class TeamQuery : ITeamQuery
    {
        private const string GET_ALL = "spGetAllTeams";
        private const string GET_ALL_BY_DIVISION = "spGetTeamsByDivision";
        private const string GET_ALL_BY_GAME = "spGetTeamsByGame";
        private const string GET = "spGetTeamById";
        private const string INSERT = "spInsertTeam";
        private const string UPDATE = "spUpdateTeam";
        private const string DELETE = "spDeleteTeam";

        private readonly IQuery _query;
        public TeamQuery(IQuery query)
        {
            _query = query;
        }

        public IEnumerable<Team> GetAll()
        {
            return _query.GetAll<Team>(GET_ALL);
        }

        public IEnumerable<Team> GetByGame(int gameDetailsId)
        {
            return _query.GetAllById<Team>(GET_ALL_BY_GAME, "gameDetailsId", gameDetailsId);
        }
        public Team Get(int id)
        {
            return _query.GetSingle<Team>(GET, id);
        }
        public int Add(Team team)
        {
            return _query.Add(INSERT, new Dictionary<string, object>
                {
                    { "cash", team.Cash },
                    { "divisionId", team.DivisionId },
                    { "name", team.Name },
                    { "stadiumCapacity", team.StadiumCapacity },
                    { "yearFormed", team.YearFormed },
                    { "gameDetailsId", team.GameDetailsId },
                    { "formationId", team.FormationId }
                });
        }
        public int Update(Team team)
        {
            return _query.Update(UPDATE, new { GameCache.GameDetailsId, team.Id, team.Cash, team.DivisionId, team.Name, team.StadiumCapacity, team.YearFormed, team.FormationId });
        }
        public int Delete(int id)
        {
            return _query.Delete(DELETE,id);
        }

    }


}