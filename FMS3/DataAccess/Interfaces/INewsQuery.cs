using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.DataAccess.Interfaces
{
    public interface INewsQuery
    {
        IEnumerable<News> GetAll(News news);
        News Get(int id);
        int Add(News news);
        void Delete(int gameDetailsId);
    }
}