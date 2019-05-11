using FMS3.Models;
using System.Collections.Generic;

namespace FMS3.Data.Interfaces
{
    public interface INewsData
    {
        IEnumerable<News> GetGameNews(int seasonId = 0, int divisionId = 0);
        IEnumerable<News> GetTeamNews(int teamId);
        News GetNews(int id);
        int AddNews(News news);
    }
}
