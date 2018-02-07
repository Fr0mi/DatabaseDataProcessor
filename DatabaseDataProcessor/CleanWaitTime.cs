using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace DatabaseDataProcessor
{
    public class CleanWaitTime
    {
        public CleanWaitTime()
        {
            var connector = new DbConnector();
            var sqlCommand = new SqlCommand("", DbConnector.Conn);

            connector.SelectSqlExecution(sqlCommand);

            connector.CloseConnection();
        }
    }
}