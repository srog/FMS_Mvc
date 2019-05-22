using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.Services.Interfaces
{
    public interface IPlayerService
    {
        IEnumerable<Player> GetAllPlayersInGame();
        PlayerListDisplay GetAllPlayers(int? teamId = null);
        List<Player> GetTeamSquad(int teamId);
        List<Player> GetSelectedTeam(int teamId);
        int GetRandomPlayerFromTeam(int teamId, bool includeKeeper = true, bool includeInjured = true, bool includeSuspended = true);
        Player Get(int id);
        string GetPlayerName(int playerId);
        string GetPlayerShortName(int playerId);

        int Add(Player player);
        int Update(Player player);
        void RecalculateRatingAndValue(int playerId);
        void SetTeamSelection(Team team);
        int Retire(int id);
        int AdvanceSeason(int gameDetailsId);
        int AdvanceWeek();
        void Delete(int gameDetailsId);
    }
}
