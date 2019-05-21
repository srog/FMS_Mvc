using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.Services.Interfaces
{
    public interface INewsService
    {
        List<News> GetAll(News news);
        IEnumerable<News> GetForGame();
        IEnumerable<News> GetForTeam(int teamId);

        News Get(int id);
        int Add(News news);
        void Delete(int gameDetailsId);

        void CreateSuspendedNewsItem(PlayerNews news, bool redCard = false);
        void CreateInjuredNewsItem(PlayerNews news);
        void CreateProRelNewsItem(PromotionNews news, bool promoted = true);

    }
}
