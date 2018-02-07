using System.Data.SqlClient;

namespace DatabaseDataProcessor
{
    public class DbConnector
    {
        private const string ServerName = "test";
        private const string DatabaseName = "test";
        private const string MyUsername = "test";
        private const string MyPassword = "test";
        private readonly string _connectionString = $"Server={ServerName}; Database={DatabaseName}; Uid={MyUsername}; Pwd={MyPassword}";
        private SqlConnection _conn;
        private bool _isConnectionOpen = false;

        public void EstablishConnection(string connectionString)
        {

//            // Closes and Disposes at the end of the using statement
//            using (var conn = new SqlConnection())
//            {
//                conn.ConnectionString = connectionString;
//                conn.Open();
//
//            }

            _conn.ConnectionString = connectionString;
            _conn.Open();

            _isConnectionOpen = true;
        }

        public void EstablishConnection()
        {
            EstablishConnection(_connectionString);
        }

        public void CloseConnection()
        {
            if (_isConnectionOpen)
            {
                _conn.Close();
                _conn.Dispose();

                _isConnectionOpen = false;
            }
        }
    }
}
