using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.DataAccess.Interfaces
{
    public interface IGameDetailsQuery
    {
        IEnumerable<GameDetails> GetAll();
        GameDetails Get(int id);
        int Insert(GameDetails gameDetails);
        int Update(GameDetails gameDetails);
        int Delete(int id);
    }
}