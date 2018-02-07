using System;
using System.Data.SqlClient;

namespace DatabaseDataProcessor
{
    public class DbConnector
    {
        private const string ServerName = "test";
        private const string DatabaseName = "test";
        private const string Port = "test";
        private const string MyUsername = "test";
        private const string MyPassword = "test";
        private static readonly string ConnectionString = $"Server={ServerName}; Port={Port};" +
                                                          $" Database={DatabaseName}; Uid={MyUsername}; Pwd={MyPassword}";

        public static SqlConnection Conn { get; private set; }

        public bool IsConnectionOpen { get; private set; } = false;

        public DbConnector(string connectionString)
        {
//            // Closes and Disposes at the end of the using statement
//            using (var conn = new SqlConnection())
//            {
//                conn.ConnectionString = connectionString;
//                conn.Open();
//
//            }
            
            Conn = new SqlConnection(connectionString);
            Conn.Open();

            IsConnectionOpen = true;
        }

        public DbConnector() : this(ConnectionString) { }

        public void CloseConnection()
        {
            if (IsConnectionOpen)
            {
                Conn.Close();
                Conn.Dispose();

                IsConnectionOpen = false;
            }
        }

        /// <summary>
        /// Reads from the Database with a select command
        /// </summary>
        /// <param name="command">Needs to be a select command</param>
        public void SelectSqlExecution(SqlCommand command)
        {

            try
            {
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Do something..
                    }
                }
            }
            catch (SqlException er)
            {
                Console.WriteLine(er);
                throw;
            }
            
        }
    }
}
