using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.DataAccess.Interfaces
{
    public interface ITransferQuery
    {
        IEnumerable<Transfer> GetAllForGame();
        IEnumerable<Transfer> GetAll(Transfer transfer);
        Transfer Get(int id);
        int Insert(Transfer transfer);
        int Update(Transfer transfer);
    }
}