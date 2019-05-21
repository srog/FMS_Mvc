using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.Services.Interfaces
{
    public interface IFixtureGenerator
    {
        void GenerateForSeason(IEnumerable<TeamSeason> teamSeasons);
    }
}