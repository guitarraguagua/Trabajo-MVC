using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace Blockbuster.Models
{
    public class modelPelicula : Database
    {
        public modelPelicula()
        {
        }

        public DataTable GetTablaPeliculas()
        {
            DataTable table = new DataTable();

            string[] columnNames = { "ID", "NOMBRE", "PRECIO" };

            foreach (string column in columnNames)
            {
                table.Columns.Add(column);
            }

            try{

                string query = "SELECT * FROM PELICULAS";
                MySqlCommand command = new MySqlCommand(query, GetConnection());
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    table.Rows.Add(reader["ID"], reader["NOMBRE"], reader["PRECIO"]);
                }

                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return table;
        }

        public void AddPelicula(Peliculas pelicula)
        {
            try
            {

                string query = "INSERT INTO PELICULAS (NOMBRE, PRECIO) values ('" + pelicula.Nombre + "', '" + pelicula.Precio + "')";
                MySqlCommand command = new MySqlCommand(query, GetConnection());
                MySqlDataReader reader = command.ExecuteReader();

                reader.Close();

            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void DelPelicula(int id)
        {
            try
            {

                string query = "DELETE FROM PELICULAS WHERE ID = " + id;
                MySqlCommand command = new MySqlCommand(query, GetConnection());
                MySqlDataReader reader = command.ExecuteReader();

                reader.Close();

            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}