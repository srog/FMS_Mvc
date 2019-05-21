using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.Services.Interfaces
{
    public interface IPlayerCreatorService
    {
        void CreateAllPlayersForGame(IEnumerable<Team> teamList);
    }
}