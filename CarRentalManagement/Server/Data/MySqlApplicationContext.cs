using MySql.Data.MySqlClient;

namespace CarRentalManagement.Server.Data
{
    public class MySqlApplicationContext
    {
        public string ConnectionString { get; set; }

        public MySqlApplicationContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}