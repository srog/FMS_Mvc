using System.Collections.Generic;
using FMS3.Data.Cache;
using FMS3.DataAccess.Interfaces;
using FMS3.Models;

namespace FMS3.DataAccess.Queries
{
    public class TransferQuery : ITransferQuery
    {
        private const string GET_ALL = "spGetTransfers";
        private const string GET = "spGetTransfer";
        private const string INSERT = "spInsertTransfer";
        private const string UPDATE = "spUpdateTransfer";

        private readonly IQuery _query;
        public TransferQuery(IQuery query)
        {
            _query = query;
        }

        #region Implementation of ITransferQuery

        public IEnumerable<Transfer> GetAllForGame()
        {
            return _query.GetAll<Transfer>(GET_ALL, new { GameCache.GameDetailsId});
        }

        public IEnumerable<Transfer> GetAll(Transfer transfer)
        {
            var param = new
                {
                    GameCache.GameDetailsId,
                    transfer.PlayerId,
                    transfer.SeasonId,
                    transfer.TeamFromId,
                    transfer.TeamToId,
                    transfer.Week,
                    transfer.Status
                };

            return _query.GetAll<Transfer>(GET_ALL, param);
        }

        public Transfer Get(int id)
        {
            return _query.GetSingle<Transfer>(GET, id);
        }

        public int Insert(Transfer transfer)
        {
            return _query.Add(INSERT, new Dictionary<string, object>()
                {
                    {"gameDetailsId", GameCache.GameDetailsId},
                    {"playerId", transfer.PlayerId},
                    {"seasonId", transfer.SeasonId},
                    {"teamFromId", transfer.TeamFromId},
                    {"teamToId", transfer.TeamToId},
                    {"week", transfer.Week},
                    {"transferValue", transfer.TransferValue},
                    {"status", transfer.Status}
                });
        }

        public int Update(Transfer transfer)
        {
            return _query.Update(UPDATE, new
                {
                    GameCache.GameDetailsId,
                    transfer.PlayerId,
                    transfer.SeasonId,
                    transfer.TeamFromId,
                    transfer.TeamToId,
                    transfer.Week,
                    transfer.TransferValue,
                    transfer.Status
                });
        }

        #endregion
    }
}