﻿using System.Collections.Generic;
using FMS3.DataAccess.Interfaces;
using FMS3.Models;

namespace FMS3.DataAccess.Queries
{
    public class SeasonQuery : ISeasonQuery
    {
        private const string GET_ALL_BY_GAME = "spGetSeasonsByGameId";
        private const string GET = "spGetSeasonById";
        private const string INSERT = "spInsertSeason";
        private const string UPDATE = "spUpdateSeason";
        private const string DELETE = "spDeleteSeason";

        private readonly IQuery _query;
        public SeasonQuery(IQuery query)
        {
            _query = query;
        }

        public IEnumerable<Season> GetByGame(int gameDetailsId)
        {
            return _query.GetAllById<Season>(GET_ALL_BY_GAME, "gameDetailsId", gameDetailsId);
        }
        public Season Get(int id)
        {
            return _query.GetSingle<Season>(GET, id);
        }
        public int Add(Season season)
        {
            return _query.Add(INSERT, new Dictionary<string, object>
                {
                    { "completed", season.Completed },
                    { "gameDetailsId", season.GameDetailsId },
                    { "startYear", season.StartYear }
                });
        }
        public int Update(Season season)
        {
            return _query.Update(UPDATE, new { season.Id, season.Completed, season.GameDetailsId, season.StartYear });
        }
        public int Delete(int id)
        {
            return _query.Delete(DELETE, id);
        }



    }
}
