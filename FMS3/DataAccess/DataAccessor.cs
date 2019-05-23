using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace FMS3.DataAccess
{
    public class DataAccessor : IDataAccessor
    {
        private readonly IConfiguration _configuration;

        public DataAccessor(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection Connection => new SqlConnection(_configuration["ConnectionStrings:DefaultConnection"]);

        public int Execute(string storedProcName, object param = null)
        {
            using (IDbConnection conn = Connection)
            {
                conn.Open();

                return conn.Execute(storedProcName, param, commandType: CommandType.StoredProcedure);
            }
        }

        public IEnumerable<T> Query<T>(string storedProcName, object param = null)
        {
            using (IDbConnection conn = Connection)
            {
                conn.Open();
                return conn.Query<T>(storedProcName, param, commandType: CommandType.StoredProcedure);
            }
        }


        public T QuerySingle<T>(string storedProcName, object param = null)
        {
            using (IDbConnection conn = Connection)
            {
                conn.Open();
                return conn.QuerySingle<T>(storedProcName, param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}