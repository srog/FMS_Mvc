using System.Collections.Generic;
using FMS3.Models;

namespace FMS3.Services.Interfaces
{
    public interface ITransferService
    {
        IEnumerable<Transfer> GetAllForGame();
        IEnumerable<Transfer> GetAll(Transfer transfer);
        IEnumerable<Transfer> GetAllByStatus(int status);
        IEnumerable<Transfer> GetAllInAndOutForTeam(Transfer transfer);

        Transfer Get(int id);
        int Add(Transfer transfer);
        int Update(Transfer transfer);
        
    }
}