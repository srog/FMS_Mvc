using FMS3.Data.Cache;
using FMS3.Data.Interfaces;
using FMS3.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace FMS3.Data.API
{
    public class TeamData : ITeamData
    {
        private IWebApi _webApi { get; }
        private readonly string teamURL = "http://localhost:56822/api/team";

        public TeamData(IWebApi webApi)
        {
            _webApi = webApi;
        }

        public string GetTeamName(int teamId)
        {
            if (!GameCache.TeamNames.ContainsKey(teamId))
            {
                string name;
                if (teamId == 0)
                {
                    name = "(Unattached)";
                }
                else
                {
                    name = GetTeam(teamId).Name;    
                }
                GameCache.TeamNames.Add(teamId, name);
            }
            return GameCache.TeamNames.GetValueOrDefault(teamId);

        }

        public IEnumerable<Team> GetAllTeams()
        {
            var paramList = new Dictionary<string, object>
            {
                {"gameDetailsId", GameCache.GameDetailsId}
            };

        var response = _webApi.GetAll(teamURL, paramList);
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<Team>>().Result;
            }
            else
            {
                var testerror = response;
            }
            return null;
        }

        public Team GetTeam(int id)
        {
            var response = _webApi.GetById(teamURL, id);

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<Team>().Result;
            }
            else
            {
                var testerror = response;
            }
            return null;
        }

        public int AddTeam(Team team)
        {
            var response = _webApi.Post(teamURL, team);

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<int>().Result;
            }
            else
            {
                var testerror = response;
            }
            return 0;
        }

        public int UpdateTeam(Team team)
        {
            var response = _webApi.Put(teamURL, team);

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<int>().Result;
            }
            else
            {
                var testerror = response;
            }
            return 0;
        }
        public int DeleteTeam(int id)
        {
            var response = _webApi.Delete(teamURL, id);
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<int>().Result;

            }
            else
            {
                return 0;
            }
        }
    }
}
