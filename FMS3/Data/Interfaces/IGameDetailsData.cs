using FMS3.Models;
using System.Collections.Generic;

namespace FMS3.Data.Interfaces
{
    public interface IGameDetailsData
    {
        IEnumerable<GameDetails> GetAll();
        GameDetails GetById(int id);
        int StartNewGame();
        GameDetails SetManagerName(string managerName);
        GameDetails SetTeam(int teamId);
        GameDetails AdvanceWeek();
        GameDetails SetGameToNewSeason(int seasonId);
    }
}
