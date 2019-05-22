using System.Collections.Generic;
using System.Linq;
using FMS3.Data.Cache;
using FMS3.DataAccess.Interfaces;
using FMS3.Models;
using FMS3.Services.Interfaces;
using Microsoft.Extensions.Configuration;

namespace FMS3.Services
{
    public class TeamService : ITeamService
    {
        private readonly ITeamQuery _teamQuery;
        private readonly IConfiguration _configuration;

        public static Dictionary<int, string> TeamNames = new Dictionary<int, string>();

        public TeamService(ITeamQuery teamQuery, IConfiguration config)
        {
            _teamQuery = teamQuery;
            _configuration = config;
        }

        public Team Get(int id)
        {
            return _teamQuery.Get(id);
        }

        public Team GetManagedTeam()
        {
            return Get(GameCache.ManagedTeamId);
        }

        public int Add(Team team)
        {
            return _teamQuery.Add(team);
        }

        public int Update(Team team)
        {
            return _teamQuery.Update(team);
        }

        public void CreateAllTeamsForGame(int gameId)
        {
            var numberOfDivisions = _configuration.GetValue<int>("NumberOfDivisions");
            var numberOfTeamsInDivision = _configuration.GetValue<int>("TeamsInDivision");

            for (var division = 1; division <= numberOfDivisions; division++)
            {
                for (var teamIndex = 1; teamIndex <= numberOfTeamsInDivision; teamIndex++)
                {
                    var cash = Utilities.Utilities.GetRandomNumber(((5 - division) * 20000), (5 - division) * 1000000);
                    if (division == 1)
                    {
                        cash += Utilities.Utilities.GetRandomNumber(1, 100000000);
                    }
                    var stadiumCapacity = Utilities.Utilities.GetRandomNumber((5 - division) * 1000, (5 - division) * 20000);

                    var newTeam = new Team
                        {
                            DivisionId = division,
                            GameDetailsId = gameId,
                            Cash = cash,
                            FormationId = Utilities.Utilities.GetRandomNumber(1, 5),
                            Name = GameCache.TeamTemplates.Teams[(division - 1) * numberOfTeamsInDivision + (teamIndex - 1)].Name,
                            YearFormed = Utilities.Utilities.GetRandomNumber(1870, 1950),
                            StadiumCapacity = stadiumCapacity
                    };
                    _teamQuery.Add(newTeam);
                }
            }
        }

        public List<Team> GetTeamsForGame()
        {
            return _teamQuery.GetByGame(GameCache.GameDetailsId).ToList();
        }

        public string GetTeamName(int teamId)
        {
            if (!TeamNames.ContainsKey(teamId))
            {
                string name;
                if (teamId == 0)
                {
                    name = "(Unattached)";
                }
                else
                {
                    name = Get(teamId).Name;
                }
                TeamNames.Add(teamId, name);
            }
            return TeamNames.GetValueOrDefault(teamId);
        }
    }
}
