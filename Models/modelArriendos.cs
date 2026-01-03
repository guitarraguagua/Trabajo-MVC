using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Blockbuster.Models
{
    public class modelArriendos : Database
    {
        DataTable table = new DataTable();
        public modelArriendos()
        {
        }

        public DataTable GetTablaArriendos()
        {
            DataTable table = new DataTable();

            string[] columnNames = { "NOMBRE_PELICULA", "NOMBRE_CLIENTE", "FECHA" };

            foreach (string column in columnNames)
            {
                table.Columns.Add(column);
            }

            try{

                string query = "SELECT P.NOMBRE NOMBRE_PELICULA, C.NOMBRE NOMBRE_CLIENTE, A.FECHA FROM PELICULAS P JOIN ARRIENDOS A ON P.ID = A.ID_PELICULA JOIN CLIENTES C ON A.ID_CLIENTE = C.ID WHERE ESTADO = 1 ORDER BY FECHA";
                MySqlCommand command = new MySqlCommand(query, GetConnection());
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    table.Rows.Add(reader["NOMBRE_PELICULA"], reader["NOMBRE_CLIENTE"], reader["FECHA"]);
                }

                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return table;
        }

        public DataTable GetPeliculasPopulares()
        {
            DataTable table = new DataTable();

            string[] columnNames = { "NOMBRE_PELICULA", "CANTIDAD" };

            foreach (string column in columnNames)
            {
                table.Columns.Add(column);
            }

            try
            {

                string query = "SELECT P.NOMBRE NOMBRE_PELICULA, COUNT(P.NOMBRE) CANTIDAD FROM PELICULAS P JOIN ARRIENDOS A ON P.ID = A.ID_PELICULA WHERE ESTADO = 1 GROUP BY P.NOMBRE ORDER BY CANTIDAD DESC";
                MySqlCommand command = new MySqlCommand(query, GetConnection());
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    table.Rows.Add(reader["NOMBRE_PELICULA"], reader["CANTIDAD"]);
                }

                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return table;
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

                string query = "SELECT P.* FROM (SELECT * FROM (SELECT * FROM ARRIENDOS A WHERE A.FECHA IN (SELECT MAX(FECHA) FROM ARRIENDOS GROUP BY ID_PELICULA)) SA WHERE SA.FECHA IN (SELECT MAX(FECHA) FROM ARRIENDOS GROUP BY ID_PELICULA) GROUP BY ID_PELICULA) SSA, PELICULAS P WHERE SSA.ID_PELICULA = P.ID AND ESTADO = 0";
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

        public DataTable GetPeliculasClientes(int idCliente)
        {
            DataTable table = new DataTable();
            string[] columnNames = { "ID", "NOMBRE", "PRECIO" };

            foreach (string column in columnNames)
            {
                table.Columns.Add(column);
            }
            try
            {

                string query = "SELECT P.* FROM ARRIENDOS A JOIN PELICULAS P ON A.ID_PELICULA = P.ID WHERE ID_CLIENTE = " + idCliente +" AND FECHA IN(SELECT MAX(FECHA) FROM ARRIENDOS WHERE ID_CLIENTE = A.ID_CLIENTE group by ID_PELICULA) AND ESTADO = 1 group by ID_PELICULA";
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

        public void AddArriendo(Arriendos arriendo)
        {
            try
            {

               foreach(Peliculas p in arriendo.Peliculas)
                {
                    string query = "INSERT INTO ARRIENDOS (ID_CLIENTE, ID_PELICULA, FECHA, ID_BOLETA, ESTADO) VALUES (" + arriendo.IdCliente + ", " + p.Id + ", NOW(), " + arriendo.Boleta + ", " + arriendo.Estado + ")";
                    MySqlCommand command = new MySqlCommand(query, GetConnection());
                    MySqlDataReader reader = command.ExecuteReader();

                    reader.Close();
                }

            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public DataTable peliculasElegidas(List<Peliculas> elegidas) 
        {
            DataTable table = new DataTable();

            string[] columnNames = { "ID", "NOMBRE", "PRECIO" };

            foreach (string column in columnNames)
            {
                table.Columns.Add(column);
            }

            foreach (Peliculas pelicula in elegidas)
            {
                table.Rows.Add(pelicula.Id, pelicula.Nombre, pelicula.Precio);
            }

            return table;
        }

        public void DevolverPeliculas(int idCliente)
        {
            try
            {
                string query = "INSERT INTO ARRIENDOS ( SELECT ID_CLIENTE, ID_PELICULA, NOW() FECHA, ID_BOLETA, 0 ESTADO FROM ARRIENDOS A JOIN PELICULAS P ON A.ID_PELICULA = P.ID WHERE ID_CLIENTE = " + idCliente + " AND FECHA IN (SELECT MAX(FECHA) FROM ARRIENDOS WHERE ID_CLIENTE = A.ID_CLIENTE GROUP BY ID_PELICULA) AND ESTADO = 1 GROUP BY ID_PELICULA)";
                MySqlCommand command = new MySqlCommand(query, GetConnection());
                MySqlDataReader reader = command.ExecuteReader();

                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}