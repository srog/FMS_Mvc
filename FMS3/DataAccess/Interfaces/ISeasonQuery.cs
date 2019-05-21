using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.DataAccess.Interfaces
{
    public interface ISeasonQuery
    {
        IEnumerable<Season> GetByGame(int gameDetailsId);
        Season Get(int id);
        int Add(Season season);
        int Update(Season season);
        int Delete(int gameDetailsid);

    }
}