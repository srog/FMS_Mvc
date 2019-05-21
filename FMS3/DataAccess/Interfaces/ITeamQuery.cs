using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.DataAccess.Interfaces
{
    public interface ITeamQuery
    {
        IEnumerable<Team> GetAll();
        IEnumerable<Team> GetByGame(int gameDetailsId);
        Team Get(int id);
        int Add(Team team);
        int Update(Team team);
        int Delete(int gameDetailsId);

    }
}