using System;
using MySql.Data.MySqlClient;

namespace Repository
{
    public class ShlContext : IDisposable
    {
        public MySqlConnection Connection { get; set; }

        public ShlContext(string connectionString)
        {
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "209.182.219.138";
            conn_string.UserID = "admin_theshl";
            conn_string.Password = "BigSexyPony1";
            conn_string.Database = "admin_testdb";
            connectionString = conn_string.ToString();

            Connection = new MySqlConnection(connectionString);
        }

        public void Dispose()
        {
            Connection.Close();
        }
    }
}
