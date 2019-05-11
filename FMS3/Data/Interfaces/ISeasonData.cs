using FMS3.Models;
using System.Collections.Generic;

namespace FMS3.Data.Interfaces
{
    public interface ISeasonData
    {
        IEnumerable<Season> GetAllSeasons();
        Season GetSeason(int id);
        int AddSeason(Season season);
        int UpdateSeason(Season season);
        int CompleteCurrentSeason();
        int GetSeasonYear(int seasonId);

    }
}
