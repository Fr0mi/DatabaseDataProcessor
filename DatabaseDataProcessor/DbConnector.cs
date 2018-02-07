using System.Data.SqlClient;

namespace DatabaseDataProcessor
{
    public class DbConnector
    {
        private const string ServerName = "test";
        private const string DatabaseName = "test";
        private const string MyUsername = "test";
        private const string MyPassword = "test";
        private static readonly string ConnectionString = $"Server={ServerName}; Database={DatabaseName}; Uid={MyUsername}; Pwd={MyPassword}";
        private static SqlConnection _conn;
        private bool _isConnectionOpen = false;

        public DbConnector(string connectionString)
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

        public DbConnector() : this(ConnectionString) { }

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
