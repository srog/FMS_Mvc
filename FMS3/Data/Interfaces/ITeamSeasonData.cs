using FMS3.Models;
using System.Collections.Generic;

namespace FMS3.Data.Interfaces
{
    public interface ITeamSeasonData
    {
        IEnumerable<TeamSeason> GetLeague(int divisionId);
        int PromotionAndRelegation(int gameDetailsId, int oldSeasonId, int newSeasonId);
    }
}
