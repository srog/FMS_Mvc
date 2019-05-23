using System.Collections.Generic;
using FMS3.DataAccess.Interfaces;
using FMS3.Models;

namespace FMS3.DataAccess.Queries
{
    public class GameDetailsQuery : IGameDetailsQuery
    {
        private const string GET_ALL = "spGetAllGameDetails";
        private const string GET = "spGetGameDetailsById";
        private const string INSERT = "spInsertGameDetails";
        private const string UPDATE = "spUpdateGameDetails";
        private const string DELETE = "spDeleteGameDetails";

        private readonly IQuery _query;
        public GameDetailsQuery(IQuery query)
        {
            _query = query;
        }


        public IEnumerable<GameDetails> GetAll()
        {
            return _query.GetAll<GameDetails>(GET_ALL);
        }
        public GameDetails Get(int id)
        {
            return _query.GetSingle<GameDetails>(GET, id);
        }
        public int Insert(GameDetails gameDetails)
        {
            return _query.Add(INSERT, new Dictionary<string, object>
                {
                    { "managerName", gameDetails.ManagerName }
                });
        }
        public int Update(GameDetails gameDetails)
        {
            return _query.Update(UPDATE, new
                {
                    gameDetails.Id,
                    gameDetails.ManagerName,
                    gameDetails.CurrentSeasonId,
                    gameDetails.TeamId,
                    gameDetails.CurrentWeek
                });
        }
        public int Delete(int id)
        {
            return _query.Delete(DELETE, id);
        }

    }


}