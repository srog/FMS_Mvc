using FMS3.Models;
using System.Collections.Generic;
using FMS3.DataAccess.Interfaces;

namespace FMS3.DataAccess.Queries
{
    public class TeamSeasonQuery : ITeamSeasonQuery
    {
        private const string GET_ALL = "spGetTeamSeasons";
        private const string GET = "spGetTeamSeasonById";
        private const string INSERT = "spInsertTeamSeason";
        private const string UPDATE = "spUpdateTeamSeason";
        private const string RECALCULATE = "spRecalculateTeamSeason";
        private const string RECALCULATE_POSITIONS = "spRecalculateDivisionPositions";

        private readonly IQuery _query;
        public TeamSeasonQuery(IQuery query)
        {
            _query = query;
        }

        public IEnumerable<TeamSeason> GetByGame(int gameDetailsId)
        {
            return _query.GetAllById<TeamSeason>(GET_ALL, "gameDetailsId", gameDetailsId);
        }

        public IEnumerable<TeamSeason> GetByGameAndDivision(int gameDetailsId, int divisionId)
        {
            var param = new { gameDetailsId, divisionId };
            return _query.GetAll<TeamSeason>(GET_ALL, param);
        }

        public IEnumerable<TeamSeason> GetByGameSeasonAndDivision(int gameDetailsId, int divisionId, int seasonId)
        {
            var param = new { gameDetailsId, divisionId, seasonId };
            return _query.GetAll<TeamSeason>(GET_ALL, param);
        }

        public IEnumerable<TeamSeason> GetBySeasonAndDivision(int divisionId, int seasonId)
        {
            var param = new { divisionId, seasonId };
            return _query.GetAll<TeamSeason>(GET_ALL, param);
        }

        public IEnumerable<TeamSeason> GetByGameAndSeason(int gameDetailsId, int seasonId)
        {
            var param = new { gameDetailsId, seasonId };
            return _query.GetAll<TeamSeason>(GET_ALL, param);
        }

        public TeamSeason GetCurrentForTeam(int teamId)
        {
            return _query.GetSingleById<TeamSeason>(GET_ALL, "teamId", teamId);
        }

        public TeamSeason Get(int id)
        {
            return _query.GetSingle<TeamSeason>(GET, id);
        }

        public int Add(TeamSeason teamSeason)
        {
            return _query.Add(INSERT, new Dictionary<string, object>
                {
                    {"divisionId", teamSeason.DivisionId},
                    {"gameDetailsId", teamSeason.GameDetailsId},
                    {"seasonId", teamSeason.SeasonId},
                    {"teamId", teamSeason.TeamId},
                    {"position", teamSeason.Position}
                });
        }

        public int Update(TeamSeason teamSeason)
        {
            return _query.Update(UPDATE, new Dictionary<string, object>
                {
                    {"Id", teamSeason.Id},
                    {"position", teamSeason.Position}
                });
        }

        public int Recalculate(int id)
        {
            var result = _query.Update(RECALCULATE, new { id });
            return result;
        }

        public void RecalculateDivisionPositions(int seasonId, int divisionId)
        {
            _query.Update(RECALCULATE_POSITIONS, new { seasonId, divisionId });
        }
    }
}