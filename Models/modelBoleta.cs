using System;
using System.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace Blockbuster.Models
{
    internal class modelBoleta : Database
    {
        public modelBoleta()
        {
        }

        public int AddBoleta(Boleta boleta)
        {
            try
            {
                string query = "INSERT INTO BOLETAS (TOTAL) VALUES (" + boleta.Total + ")";
                MySqlCommand command = new MySqlCommand(query, GetConnection());
                MySqlDataReader reader = command.ExecuteReader();

                reader.Close();
                return (int)command.LastInsertedId;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }
        }

        public DataTable GetTablaBoleta()
        {
            DataTable table = new DataTable();

            string[] columnNames = { "ID", "TOTAL" };

            foreach (string column in columnNames)
            {
                table.Columns.Add(column);
            }

            try
            {
                string query = "SELECT * FROM BOLETA";
                MySqlCommand command = new MySqlCommand(query, GetConnection());
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    table.Rows.Add(reader["ID"], reader["TOTAL"]);
                }

                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return table;
        }  
    }
}
