using FMS3.Models;
using System.Collections.Generic;
using System.Net.Http;

namespace FMS3.Data
{
    public class TeamData
    {
        private readonly IWebApi _webApi;
        private readonly string teamURL = "http://localhost:56822/api/team";

        public TeamData()
        {
            if (_webApi == null)
            {
                _webApi = new WebApi();
            }
        }

        public IEnumerable<Team> GetAllTeams()
        {
            var response = _webApi.Get(teamURL);
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<Models.Team>>().Result;
            }
            else
            {
                var testerror = response;
            }
            return null;
        }

        public Team GetTeam(int id)
        {
            var response = _webApi.Get(teamURL, id);

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
