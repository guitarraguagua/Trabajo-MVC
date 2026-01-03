using System;
using MySql.Data.MySqlClient;


namespace Blockbuster.Models
{
    public class Database
    {
        private string db = "blockbuster";
        private string user = "mferrada";
        private string password = "martin0306";
        private string url;

        private MySqlConnection connection = null;

        public Database()
        {
            this.url = "Server=192.168.50.17;Database=" + this.db + ";Uid=" + this.user + ";Pwd=" + this.password;

            try
            {
                connection = new MySqlConnection(this.url);
                connection.Open();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public MySqlConnection GetConnection()
        {
            return this.connection;
        }
    }
}
