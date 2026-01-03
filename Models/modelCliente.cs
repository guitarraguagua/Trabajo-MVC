using System;
using System.Data;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;

namespace Blockbuster.Models
{
    public class modelCliente : Database
    {
        public modelCliente()
        {
        }

        public DataTable GetTablaClientes()
        {
            DataTable table = new DataTable();

            string[] columnNames = { "ID", "NOMBRE" };

            foreach (string column in columnNames)
            {
                table.Columns.Add(column);
            }

            try{

                string query = "SELECT * FROM CLIENTES";
                MySqlCommand command = new MySqlCommand(query, GetConnection());
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    table.Rows.Add(reader["id"], reader["nombre"]);
                }

                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return table;
        }
        public void AddCliente(Clientes cliente)
        {
            try
            {

                string query = "INSERT INTO CLIENTES (NOMBRE) values ('" + cliente.nombre + "')";
                MySqlCommand command = new MySqlCommand(query, GetConnection());
                MySqlDataReader reader = command.ExecuteReader();

                reader.Close();

            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void DelCliente(int id)
        {
            try
            {

                string query = "DELETE FROM CLIENTES WHERE ID = " + id;
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