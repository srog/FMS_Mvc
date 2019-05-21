using System.Data;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace FMS3.Utilities
{
    public class FmsDbContext : DbContext
    {
        private readonly string _connectionString = "server=(localdb)\\MSSQLLocalDB; Integrated Security=True; database=FMS";
        public IDbConnection Connection;

        public FmsDbContext()
        {
            if (Connection == null)
            {
                Connection = new SqlConnection(_connectionString);
            }
        }
    }
}