using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        public bool EstablishConnection()
        {
            using (var conn = new SqlConnection())
            {
                
                conn.ConnectionString = $"Server={ServerName}; Database={DatabaseName}; Uid={MyUsername}; Pwd={MyPassword}";
            }

            return false;
        }
    }   

}
