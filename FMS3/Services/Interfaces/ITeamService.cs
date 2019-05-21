using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.Services.Interfaces
{
    public interface ITeamService
    {
        Team Get(int id);
        Team GetManagedTeam();
        int Add(Team team);
        int Update(Team team);
        void CreateAllTeamsForGame(int gameId);
        List<Team> GetTeamsForGame();
        string GetTeamName(int teamId);
    }
}