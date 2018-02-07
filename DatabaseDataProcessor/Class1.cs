using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseDataProcessor
{
    public class DbConnector
    {
        private const string ServerName = "test";
        private const string DatabaseName = "test";
        private const string MyUsername = "test";
        private const string MyPassword = "test";
        private readonly string _connectionString = $"Server={ServerName}; Database={DatabaseName}; Uid={MyUsername}; Pwd={MyPassword}";

        public void EstablishConnection(string connectionString)
        {
            var conn = new SqlConnection {ConnectionString = connectionString};
        }

        public void EstablishConnection()
        {
            EstablishConnection(_connectionString);
        }
    }   

}
