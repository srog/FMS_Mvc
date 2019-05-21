using System.Collections.Generic;
using System.Linq;
using FMS3.Data.Cache;
using FMS3.DataAccess.Interfaces;
using FMS3.Models;
using FMS3.Services.Interfaces;
using Microsoft.Extensions.Configuration;

namespace FMS3.Services
{
    public class SeasonService : ISeasonService
    {
        private readonly ISeasonQuery _seasonQuery;
        private IConfiguration Configuration { get; }

        public SeasonService(ISeasonQuery seasonQuery, IConfiguration configuration)
        {
            _seasonQuery = seasonQuery;
            Configuration = configuration;
        }
        #region Implementation of ISeasonService

        public List<Season> GetByGame(int gameDetailsId)
        {
            return _seasonQuery.GetByGame(gameDetailsId).ToList();
        }

        public Season Get(int id)
        {
            return _seasonQuery.Get(id);
        }

        public int Add(Season season)
        {
            return _seasonQuery.Add(season);
        }

        public int AddNew(int gameDetailsId)
        {
            return _seasonQuery.Add(new Season
                {
                    GameDetailsId = gameDetailsId,
                    StartYear = Configuration.GetValue<int>("GameStartYear"),
                    Completed = false
                });
        }

        public int Update(Season season)
        {
            return _seasonQuery.Update(season);
        }

        public int Delete(int gameDetailsid)
        {
            return _seasonQuery.Delete(gameDetailsid);
        }

        public int CompleteCurrentSeason()
        {
            var currentSeason = Get(GameCache.CurrentSeasonId);
            currentSeason.Completed = true;
            Update(currentSeason);

            return currentSeason.StartYear + 1;
        }

        public int GetSeasonYear(int seasonId)
        {
            if (!GameCache.SeasonYear.ContainsKey(seasonId))
            {
                GameCache.SeasonYear.Add(seasonId, Get(seasonId).StartYear);
            }
            return GameCache.SeasonYear.GetValueOrDefault(seasonId);
        }

        #endregion
    }
}
