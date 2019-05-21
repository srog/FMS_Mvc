using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.Services.Interfaces
{
    public interface ISeasonService
    {
        List<Season> GetByGame(int gameDetailsId);
        Season Get(int id);
        int Add(Season season);
        int AddNew(int gameDetailsId);
        int Update(Season season);
        int Delete(int gameDetailsid);
    
        int CompleteCurrentSeason();
        int GetSeasonYear(int seasonId);
    }
}
