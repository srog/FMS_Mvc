using FMS3.Models;
using System.Collections.Generic;

namespace FMS3.DataAccess.Interfaces
{
    public interface IMatchQuery
    {
        IEnumerable<Match> GetAll(Match match);
        Match Get(int id);
        int Insert(Match match);
        int Update(Match match);
        void Delete(int gameDetailsId);
    }
}
