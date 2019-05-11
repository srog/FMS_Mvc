using FMS3.Models;
using System.Collections.Generic;

namespace FMS3.Data.Interfaces
{
    public interface ITeamData
    {
        string GetTeamName(int teamId);
        IEnumerable<Team> GetAllTeams();
        Team GetTeam(int id);
        int AddTeam(Team team);
        int UpdateTeam(Team team);
        int DeleteTeam(int id);

    }
}
