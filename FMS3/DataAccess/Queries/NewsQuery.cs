using System.Collections.Generic;
using FMS3.Data.Cache;
using FMS3.DataAccess.Interfaces;
using FMS3.Models;

namespace FMS3.DataAccess.Queries
{
    public class NewsQuery : INewsQuery
    {
        private const string GET_ALL = "spGetNews";
        private const string GET = "spGetNewsById";
        private const string INSERT = "spInsertNews";

        private readonly IQuery _query;
        public NewsQuery(IQuery query)
        {
            _query = query;
        }

        public IEnumerable<News> GetAll()
        {
            return GetAll(new News());
        }

        public IEnumerable<News> GetAll(News news)
        {
            var param = new
                {
                    GameDetailsId = GameCache.GameDetailsId,
                    news.SeasonId,
                    news.DivisionId,
                    news.Week,
                    news.TeamId,
                    news.PlayerId
                };
            return _query.GetAll<News>(GET_ALL, param);
        }
        
        public News Get(int id)
        {
            return _query.GetSingle<News>(GET, id);
        }
        public int Add(News news)
        {
            return _query.Add(INSERT, new Dictionary<string, object>
                {
                    { "divisionId", news.DivisionId },
                    { "gameDetailsId", news.GameDetailsId },
                    { "seasonId", news.SeasonId },
                    { "teamId", news.TeamId },
                    { "playerId", news.PlayerId },
                    { "week", news.Week },
                    { "newsText", news.NewsText }
                });
        }

        public void Delete(int gameDetailsId)
        {
            throw new System.NotImplementedException();
        }
    }
}
