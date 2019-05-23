using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.Services.Interfaces
{
    public interface IGameDetailsService
    {
        List<GameDetails> GetAll();
        GameDetails Get(int id);
        GameDetails GetCurrentGame();
        int Insert(GameDetails gameDetails);
        int Update(GameDetails gameDetails);
        GameDetails AdvanceWeek();
        GameDetails CompleteCurrentSeason();
        int Delete(int id);
        GameDetails StartNewGame();
        GameDetails SetManagerName(string managerName);
        GameDetails SetTeam(int teamId);
        GameDetails SetGameToNewSeason(int seasonId);
        bool LoadStaticData();
        GameDetails LoadGame(int id);
    }
}
